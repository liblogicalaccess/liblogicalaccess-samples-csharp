using LibLogicalAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class RWCard : Form
    {
        public RWCard()
        {
            InitializeComponent();
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

        private string ReadData(string tmp , IChip chip, ILocation location, IAccessInfo aiToUse, IAccessInfo aiToWrite)
        {
            string ret = string.Empty;
            ICardService storage = chip.GetService(CardServiceType.CST_STORAGE);

            if (storage != null)
            {
                byte[] data = (byte[])(storage as StorageCardService).ReadData(location, aiToWrite, 16, CardBehavior.CB_DEFAULT);
                ret = GetString(data);

                MessageBox.Show("Read succeeded", "Info:", MessageBoxButtons.OK);
            }
            else
                throw new Exception("Impossible to get card service.");
            return ret;
        }

        private string WriteData(string data, IChip chip, ILocation location, IAccessInfo aiToUse, IAccessInfo aiToWrite)
        {
            ICardService storage = chip.GetService(CardServiceType.CST_STORAGE);

            if (storage != null)
            {
                if (chip.GenericType == "DESFire")
                {
                    DESFireKey defaultKey = new DESFireKey();
                    defaultKey.Value = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00";

                    (chip.Commands as DESFireCommands).SelectApplication(0);
                    (chip.Commands as DESFireCommands).Authenticate(0, defaultKey);
                    (chip.Commands as DESFireCommands).Erase();
                }

               byte[] arrayData = GetBytes(data);
               Array.Resize(ref arrayData, 16);
               (storage as StorageCardService).WriteData(location, aiToUse, aiToWrite, arrayData, 16, CardBehavior.CB_DEFAULT);

               MessageBox.Show("Write succeeded", "Info:", MessageBoxButtons.OK);
            }
            else
                throw new Exception("Impossible to get card service.");

            return string.Empty;
        }

        private string PCSCAction(Func<string, IChip, ILocation, IAccessInfo, IAccessInfo, string> action, string data)
        {
            string ret = null;

            try
            {
                IReaderProvider readerProvider = new PCSCReaderProvider();
                object[] readers = readerProvider.GetReaderList() as object[];
                if (readers == null || readers.Length == 0)
                    throw new Exception("No readers found.");
                IReaderUnit readerUnit = readerProvider.CreateReaderUnit();

                if (readerUnit.ConnectToReader())
                {
                    if (readerUnit.WaitInsertion(5000))
                    {
                        if (readerUnit.Connect())
                        {
                            IChip chip = readerUnit.GetSingleChip();
                            if (chip != null)
                            {
                                string cardUIDCSN = chip.ChipIdentifier; //UID/CSN
                                ILocation location = chip.CreateLocation();
                                IAccessInfo aiToUse = chip.CreateAccessInfo();
                                IAccessInfo aiToWrite = chip.CreateAccessInfo();

                                if (chip.GenericType == "DESFire")
                                {
                                    IDESFireLocation dlocation = (location as IDESFireLocation);
                                    dlocation.aid = 0x000555;
                                    dlocation.File = 0;

                                    IDESFireAccessInfo daiToWrite = (aiToWrite as IDESFireAccessInfo);
                                    DESFireKey desfireKey2 = new DESFireKey();
                                    desfireKey2.Value = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 aa";
                                    DESFireKey desfireKey1 = new DESFireKey();
                                    desfireKey1.Value = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 bb";
                                    DESFireKey masterKey = new DESFireKey();
                                    masterKey.Value = "00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 cc";

                                    daiToWrite.ReadKey = desfireKey2;
                                    daiToWrite.ReadKeyNo = 2;

                                    daiToWrite.WriteKey = desfireKey1;
                                    daiToWrite.WriteKeyNo = 1;
                                    daiToWrite.MasterApplicationKey = masterKey;
                                }

                                ret = action(data, chip, location, aiToUse, aiToWrite);
                            }
                            readerUnit.Disconnect();
                        }
                        readerUnit.WaitRemoval(2000);
                    }
                    else
                        MessageBox.Show("No card detected !", "Error:", MessageBoxButtons.OK);
                    readerUnit.DisconnectFromReader();
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
