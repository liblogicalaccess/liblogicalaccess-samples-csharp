using LibLogicalAccess;
using LibLogicalAccess.Card;
using LibLogicalAccess.Reader;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml;

namespace RWCard_DESFire
{
    public partial class MiscToolsSample : Form
    {
        public MiscToolsSample()
        {
            InitializeComponent();
        }

        private Chip chip = null;
        private SAMKeyEntrySETAV2Commands cmd = null;

        private void btnAV2Div_Click(object sender, System.EventArgs e)
        {
            var inputDiv7 = new byte[7];
            var inputDiv = Convert.FromHexString(tbxDiversifier.Text);
            Array.Copy(inputDiv, 0, inputDiv7, 0, inputDiv.Length >= inputDiv7.Length ? inputDiv7.Length : inputDiv.Length);

            DESFireKey dkey = new DESFireKey();
            dkey.setKeyType(DESFireKeyType.DF_KEY_AES);
            if (!string.IsNullOrEmpty(tbxData.Text))
            {
                dkey.fromString(KeyHelper.FormatKeyString(tbxData.Text));
            }
            var div = new NXPAV2KeyDiversification();
            div.setDivInput(new ByteVector(inputDiv7));
            var ooutputdiv = new ByteVector();
            div.initDiversification(new ByteVector(inputDiv7), 0, dkey, 0, ooutputdiv);
            if (ooutputdiv != null)
            {
                var odivkey = div.getDiversifiedKey(dkey, ooutputdiv);
                if (odivkey != null)
                {
                    var keydiv = odivkey.ToArray();
                    MessageBox.Show(Convert.ToHexString(keydiv));


                    byte[] iv = new byte[0x80 / 8];
                    Array.Copy(inputDiv7, iv, inputDiv7.Length);
                    if (inputDiv7.Length < iv.Length)
                    {
                        iv[inputDiv7.Length] = 0x80;
                    }
                    var ocdata = LibLogicalAccess.Crypto.CMACCrypto.cmac(new ByteVector(keydiv), "aes", new ByteVector(Convert.FromHexString("0100000000000000000000001137520000000000000000000001BC58000000000000000000000000")), new ByteVector(iv));
                    if (ocdata != null)
                    {
                        var fullcdata = ocdata.ToArray();
                        if (fullcdata != null && fullcdata.Length >= 8)
                        {
                            // Get the first 8 bytes only
                            var cdata = new byte[8];
                            Array.Copy(fullcdata, cdata, 8);

                            MessageBox.Show(Convert.ToHexString(cdata));
                        }
                    }
                }
            }
        }
    }
}
