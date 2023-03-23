using LibLogicalAccess;
using LibLogicalAccess.Card;
using System;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class CardStorageServiceSample : Form
    {
        public CardStorageServiceSample()
        {
            InitializeComponent();
        }

        public ReaderConfiguration ReaderConfig { get; set; }

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

        private void btnWrite_Click(object sender, EventArgs e)
        {
            var task = new CardServiceTask(ReaderConfig);
            task.Run<string>(WriteData, textBox1.Text);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var task = new CardServiceTask(ReaderConfig);
            task.Run<string>(ReadData);
        }
    }
}
