using LibLogicalAccess;
using LibLogicalAccess.Card;
using LibLogicalAccess.Crypto;
using System;
using System.Collections.Specialized;
using System.Security.Cryptography;
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
        private DESFireEV2Commands cmdev2 = null;
        private DESFireEV3Commands cmdev3 = null;
        private NameValueCollection sdmParameters = new();

        private void ShowError(string msg)
        {
            MessageBox.Show(msg, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnConnectToReader_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            if (!ru.connectToReader())
                ShowError("Cannot connect to the reader");
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
                ShowError("No card has been inserted");
        }

        private void btnWaitRemoval_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            if (!ru.waitRemoval(dfparams.GetTimeout()))
                ShowError("The card has not been removed");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
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
                    if (ct == "DESFireEV2" || ct == "DESFireEV3")
                    {
                        cmdev2 = (chip as DESFireEV2Chip).getDESFireEV2Commands();
                        if (ct == "DESFireEV3")
                        {
                            cmdev3 = (chip as DESFireEV3Chip).getDESFireEV3Commands();
                        }
                    }
                }
                else
                    throw new Exception("This sample requires at least DESFire EV1 version");
            }
            catch (Exception ex)
            {
                ShowError(ex.Message);
            }
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
            RunCmdEV1(cmd =>
            {
                cmdev1.selectApplication(dfparams.GetApplicationID());
            });
        }

        private void btnAuthenticate_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                cmd.authenticate(dfparams.GetKeyNo(), keyparams.GetKey());
            });
        }

        private void btnCreateApplication_Click(object sender, EventArgs e)
        {
            RunCmdEV1(cmd =>
            {
                cmd.createApplication(dfparams.GetApplicationID(), DESFireKeySettings.KS_DEFAULT, 2, keyparams.GetCryptoMethod());
            });
        }

        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                cmd.deleteApplication(dfparams.GetApplicationID());
            });
        }

        private void btnCreateStdDataFile_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                var rights = new DESFireAccessRights();
                cmdev1.createStdDataFile(dfparams.GetFileNo(), EncryptionMode.CM_ENCRYPT, rights, 32);
            });
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                cmd.deleteFile(dfparams.GetFileNo());
            });
        }

        private void btnChangeKey_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                cmd.changeKey(dfparams.GetKeyNo(), keyparams.GetKey());
            });
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                cmd.erase();
            });
        }

        private void btnWriteData_Click(object sender, EventArgs e)
        {
            var datastr = "Just a demo.";
            var data = System.Text.Encoding.ASCII.GetBytes(datastr);
            cmd.writeData(dfparams.GetFileNo(), 0, new ByteVector(data), EncryptionMode.CM_ENCRYPT);
        }

        private void btnReadData_Click(object sender, EventArgs e)
        {
            RunCmd(cmd =>
            {
                var data = cmd.readData(dfparams.GetFileNo(), 0, 32, EncryptionMode.CM_ENCRYPT);
                var datastr = System.Text.Encoding.ASCII.GetString(data.ToArray());
                MessageBox.Show(datastr);
                datastr = Convert.ToHexString(data.ToArray());
                MessageBox.Show(datastr);
            });
        }

        private void RunCmd(Action<DESFireCommands> action)
        {
            if (cmd != null)
            {
                try
                {
                    action(cmd);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RunCmdEV1(Action<DESFireEV1Commands> action)
        {
            if (cmdev1 != null)
            {
                try
                {
                    action(cmdev1);
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
        }

        private void btnGetCardType_Click(object sender, EventArgs e)
        {
            if (chip != null)
            {
                MessageBox.Show(chip.getCardType());
            }
        }

        private void btnGetCSN_Click(object sender, EventArgs e)
        {
            if (chip != null)
            {
                var csndata = chip.getChipIdentifier();
                var csn = Convert.ToHexString(csndata.ToArray());
                MessageBox.Show(csn);
            }
        }

        private void btnReadNdef_Click(object sender, EventArgs e)
        {
            if (chip != null)
            {
                var nfcsvc = chip.getService(CardServiceType.CST_NFC_TAG) as ISO7816NFCTag4CardService;
                if (nfcsvc != null)
                {
                    var ndef = nfcsvc.readNDEF();
                    if (ndef != null && ndef.getRecordCount() > 0)
                    {
                        foreach (var record in ndef.getRecords())
                        {
                            var recordType = record.getType();
                            if (recordType.Count > 0 && recordType[0] == (byte)NdefType.Uri)
                            {
                                var r = new UriRecord();
                                r.init(record.getTnf(), r.getType(), r.getId(), record.getPayload());
                                MessageBox.Show(r.getUri(), "NDEF Record (URI)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                try
                                {
                                    var uri = new Uri(r.getUri());
                                    sdmParameters = System.Web.HttpUtility.ParseQueryString(uri.Query);
                                }
                                catch (Exception ex)
                                {
                                    ShowError(ex.Message);
                                }
                            }
                            else if (recordType.Count > 0 && recordType[0] == (byte)NdefType.Text)
                            {
                                var t = new TextRecord();
                                t.setPayload(record.getPayload());
                                MessageBox.Show(t.getCleanPayload(), "NDEF Record (Text)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                ShowError("Unsupported NDEF record type.");
                            }
                        }
                    }
                    else
                    {
                        ShowError("No NDEF message found.");
                    }
                }
            }
        }

        private void btnSdmUncipherPicc_Click(object sender, EventArgs e)
        {
            if (sdmParameters.HasKeys() && sdmParameters["picc"] != null)
            {
                try
                {
                    var picc = Convert.FromHexString(sdmParameters["picc"]);
                    var aes = Aes.Create();
                    // SDMMetaRead key
                    aes.Key = Convert.FromHexString(keyparams.GetKey().getString().Replace(" ", ""));
                    var decipheredData = aes.DecryptCbc(picc, new byte[16], PaddingMode.None);
                    MessageBox.Show(Convert.ToHexString(decipheredData), "PICC Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bool hasVcuid = (decipheredData[0] & 0x80) != 0;
                    bool hasReadCtr = (decipheredData[0] & 0x40) != 0;
                    int vcuidLength = decipheredData[0] & 0xf;
                    int offset = 1;
                    if (hasVcuid && vcuidLength > 0)
                    {
                        MessageBox.Show(Convert.ToHexString(decipheredData[offset..(offset+vcuidLength)]), "VCUID", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        offset += vcuidLength;
                    }
                    if (hasReadCtr)
                    {
                        int readCtr = decipheredData[offset++] |
                            (decipheredData[offset++] << 8) |
                            (decipheredData[offset++] << 16);
                        MessageBox.Show(readCtr.ToString(), "Read Counter", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    ShowError(ex.Message);
                }
            }
            else
            {
                ShowError("No SDM parameters found.");
            }
        }
    }
}
