using LibLogicalAccess;
using LibLogicalAccess.Card;
using LibLogicalAccess.Reader;
using System;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class RWCard : Form
    {
        public RWCard()
        {
            InitializeComponent();
        }

        static ByteVector GetBytes(string str, int padsize = 0)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            if (padsize > 0)
            {
                Array.Resize(ref bytes, padsize);
            }
            return new ByteVector(bytes);
        }

        static string GetString(ByteVector vector)
        {
            var bytes = vector.ToArray();
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private string ReadData(string tmp , IChip chip, Location location, AccessInfo aiToUse, AccessInfo aiToWrite)
        {
            string ret = string.Empty;
            CardService storage = chip.getService(CardServiceType.CST_STORAGE);

            if (storage != null)
            {
                var data = (storage as StorageCardService).readData(location, aiToWrite, 16, CardBehavior.CB_DEFAULT);
                ret = GetString(data);

                MessageBox.Show("Read succeeded", "Info:", MessageBoxButtons.OK);
            }
            else
                throw new Exception("Impossible to get card service.");
            return ret;
        }

        private string WriteData(string data, IChip chip, Location location, AccessInfo aiToUse, AccessInfo aiToWrite)
        {
            CardService storage = chip.getService(CardServiceType.CST_STORAGE);

            if (storage != null)
            {
                if (chip.getGenericCardType() == "DESFire")
                {
                    DESFireKey defaultKey = new DESFireKey();
                    defaultKey.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");

                    var dfcmd = chip.getCommands() as DESFireCommands;
                    dfcmd.selectApplication(0);
                    dfcmd.authenticate(0, defaultKey);
                    dfcmd.erase();
                }

               var arrayData = GetBytes(data, 16);
               (storage as StorageCardService).writeData(location, aiToUse, aiToWrite, arrayData, CardBehavior.CB_DEFAULT);

               MessageBox.Show("Write succeeded", "Info:", MessageBoxButtons.OK);
            }
            else
                throw new Exception("Impossible to get card service.");

            return string.Empty;
        }

        private string PCSCAction(Func<string, IChip, Location, AccessInfo, AccessInfo, string> action, string data)
        {
            string ret = null;

            try
            {
                ReaderProvider readerProvider = PCSCReaderProvider.createInstance();
                var readers = readerProvider.getReaderList();
                if (readers == null || readers.Count == 0)
                    throw new Exception("No readers found.");
                ReaderUnit readerUnit = readerProvider.createReaderUnit();

                if (readerUnit.connectToReader())
                {
                    if (readerUnit.waitInsertion(5000))
                    {
                        if (readerUnit.connect())
                        {
                            IChip chip = readerUnit.getSingleChip();
                            if (chip != null)
                            {
                                var cardUIDCSN = chip.getChipIdentifier(); //UID/CSN
                                Location location = null;
                                AccessInfo aiToUse = null;
                                AccessInfo aiToWrite = null;

                                if (chip.getGenericCardType() == "DESFire")
                                {
                                    location = new DESFireLocation();
                                    aiToUse = new DESFireAccessInfo();
                                    aiToWrite = new DESFireAccessInfo();

                                    DESFireLocation dlocation = (location as DESFireLocation);
                                    dlocation.aid = 0x000555;
                                    dlocation.file = 0;

                                    DESFireAccessInfo daiToWrite = (aiToWrite as DESFireAccessInfo);
                                    DESFireKey desfireKey2 = new DESFireKey();
                                    desfireKey2.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 aa");
                                    DESFireKey desfireKey1 = new DESFireKey();
                                    desfireKey1.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 bb");
                                    DESFireKey masterKey = new DESFireKey();
                                    masterKey.fromString("00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 cc");

                                    daiToWrite.readKey = desfireKey2;
                                    daiToWrite.readKeyno = 2;

                                    daiToWrite.writeKey = desfireKey1;
                                    daiToWrite.writeKeyno = 1;
                                    daiToWrite.masterApplicationKey = masterKey;
                                }

                                ret = action(data, chip, location, aiToUse, aiToWrite);
                            }
                            readerUnit.disconnect();
                        }
                        readerUnit.waitRemoval(2000);
                    }
                    else
                        MessageBox.Show("No card detected !", "Error:", MessageBoxButtons.OK);
                    readerUnit.disconnectFromReader();
                }
                else
                    throw new Exception("Impossible to connect to the PCSC reader.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error:", MessageBoxButtons.OK);
            }

            return ret;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PCSCAction(WriteData, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = PCSCAction(ReadData, string.Empty);
        }
    }
}
