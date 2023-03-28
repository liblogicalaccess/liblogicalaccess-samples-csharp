using LibLogicalAccess;
using LibLogicalAccess.Card;
using System;
using System.Text;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class DESFireCommandsSample : LLASample
    {
        public DESFireCommandsSample()
        {
            InitializeComponent();
        }

        private Chip chip = null;
        private DESFireCommands cmd = null;
        private DESFireEV1Commands cmdev1 = null;

        private void btnConnectToReader_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            if (!ru.connectToReader())
                throw new Exception("Cannot connect to the reader");
        }

        private void btnDisconnectFromReader_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            ru.disconnectFromReader();
        }

        private void btnWaitInsertion_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            if (!ru.waitInsertion(dfparams.GetTimeout()))
                throw new Exception("No card has been inserted");
        }

        private void btnWaitRemoval_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            if (!ru.waitRemoval(dfparams.GetTimeout()))
                throw new Exception("The card has not been removed");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            if (!ru.connect())
                throw new Exception("Cannot connect to the card");

            chip = ru.getSingleChip();
            if (chip.getGenericCardType() != "DESFire")
                throw new Exception("DESFire chip required");

            cmd = (chip as DESFireChip).getDESFireCommands();
            var ct = chip.getCardType();
            if (ct == "DESFireEV1" || ct == "DESFireEV2" || ct == "DESFireEV3")
            {
                cmdev1 = (chip as DESFireEV1Chip).getDESFireEV1Commands();
            }
            else
                throw new Exception("This sample requires at least DESFire EV1 version");
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            ru.disconnect();

            cmdev1 = null;
            cmd = null;
            chip = null;
        }

        private void btnSelectApplication_Click(object sender, EventArgs e)
        {
            cmdev1.selectApplication(dfparams.GetApplicationID());
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            cmd.authenticate(dfparams.GetKeyNo(), dfparams.GetKey());
        }

        private void btnCreateApplication_Click(object sender, EventArgs e)
        {
            cmdev1.createApplication(dfparams.GetApplicationID(), DESFireKeySettings.KS_DEFAULT, 2, dfparams.GetCryptoMethod());
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            cmd.deleteApplication(dfparams.GetApplicationID());
        }

        private void btnCreateStdDataFile_Click(object sender, EventArgs e)
        {
            var rights = new DESFireAccessRights();
            cmdev1.createStdDataFile(dfparams.GetFileNo(), EncryptionMode.CM_ENCRYPT, rights, 32);
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            cmd.deleteFile(dfparams.GetFileNo());
        }

        private void btnChangeKey_Click(object sender, EventArgs e)
        {
            cmd.changeKey(dfparams.GetKeyNo(), dfparams.GetKey());
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            cmd.erase();
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            var datastr = "Just a demo.";
            var data = System.Text.Encoding.ASCII.GetBytes(datastr);
            cmd.writeData(dfparams.GetFileNo(), 0, new ByteVector(data), EncryptionMode.CM_ENCRYPT);
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            var data = cmd.readData(dfparams.GetFileNo(), 0, 32, EncryptionMode.CM_ENCRYPT);
            var datastr = System.Text.Encoding.ASCII.GetString(data.ToArray());
            MessageBox.Show(datastr);
        }

        private void btnGetCardType_Click(object sender, EventArgs e)
        {
            MessageBox.Show(chip.getCardType());
        }

        private void btnGetCSN_Click(object sender, EventArgs e)
        {
            var csndata = chip.getChipIdentifier();
            var csn = BitConverter.ToString(csndata.ToArray());
            MessageBox.Show(csn);
        }
    }
}
