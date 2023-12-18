using LibLogicalAccess;
using LibLogicalAccess.Card;
using LibLogicalAccess.Reader;
using System;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class AuthWithSAMSample : LLASample
    {
        public AuthWithSAMSample()
        {
            InitializeComponent();
        }

        private DESFireCommands cmd = null;

        public byte GetUnlockKeyNo()
        {
            return (byte)nupKeyNo.Value;
        }

        public DESFireKey GetUnlockKey()
        {
            var key = new DESFireKey();
            key.setKeyType(DESFireKeyType.DF_KEY_AES);
            key.fromString(KeyHelper.FormatKeyString(tbxKeyValue.Text));
            return key;
        }

        public byte GetKeySlot()
        {
            return (byte)nupKeySlot.Value;
        }

        public byte GetKeyVersion()
        {
            return (byte)nupKeyVersion.Value;
        }

        private void btnInit_Click(object sender, System.EventArgs e)
        {
            try
            {
                var samConfig = readerSelectionControl.GetReaderConfiguration();

                var ru = ReaderConfig.getReaderUnit() as ISO7816ReaderUnit;
                if (ru == null)
                    throw new Exception("The Reader Unit needs to be of type ISO7816.");

                // We let know the contactless reader about the SAM reader settings
                var ruConfig = ru.getConfiguration() as ISO7816ReaderUnitConfiguration;
                ruConfig.setSAMReaderName(samConfig.getReaderUnit().getName());
                ruConfig.setSAMUnlockKey(GetUnlockKey(), GetUnlockKeyNo());
                ruConfig.setSAMType("SAM_AV2");
                ru.setConfiguration(ruConfig);

                // This is going to connect/unlock the SAM reader/chip as well
                ru.setCardType("DESFireEV1");
                ru.connectToReader();
                if (ru.waitInsertion(dfparams.GetTimeout()))
                {
                    ru.connect();
                    var chip = ru.getSingleChip();
                    if (chip.getGenericCardType() != "DESFire")
                        throw new Exception("DESFire chip required");

                    cmd = (chip as DESFireChip).getDESFireCommands();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRunAuthenticate_Click(object sender, System.EventArgs e)
        {
            try
            {
                cmd.selectApplication(dfparams.GetApplicationID());

                var key = keyparams.GetKey();
                // Here is where we define to use the SAM for furthers key usage (authenticate/changeKey commands)
                var ks = new SAMKeyStorage();
                ks.setKeySlot(GetKeySlot());
                key.setKeyVersion(GetKeyVersion());
                key.setKeyStorage(ks);

                cmd.authenticate(dfparams.GetKeyNo(), key);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnInit_Click(object sender, System.EventArgs e)
        {
            try
            {
                var ru = ReaderConfig.getReaderUnit();
                ru.disconnect();
                ru.waitRemoval(dfparams.GetTimeout());
                // Will release SAM resources too
                ru.disconnectFromReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            try
            {
                var data = cmd.readData(dfparams.GetFileNo(), 0, 8, EncryptionMode.CM_ENCRYPT);
                MessageBox.Show(Convert.ToHexString(data.ToArray()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
