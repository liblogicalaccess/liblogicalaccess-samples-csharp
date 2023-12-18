using LibLogicalAccess;
using LibLogicalAccess.Card;
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
    public partial class KeyParametersControl : UserControl
    {
        public KeyParametersControl()
        {
            InitializeComponent();
            cbKeyType.SelectedIndex = 0;
            cbKeyDiversification.SelectedIndex = 0;
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.DefaultValue(false)]
        public bool DisableKeyValueParameters
        {
            get { return !tbxKeyValue.Enabled; }
            set { tbxKeyValue.Enabled = !value; }
        }

        public DESFireKeyType GetCryptoMethod()
        {
            var crypto = DESFireKeyType.DF_KEY_DES;
            if (cbKeyType.SelectedIndex > -1)
            {
                Enum.TryParse("DF_KEY_" + cbKeyType.SelectedItem.ToString(), out crypto);
            }
            return crypto;
        }

        public DESFireKey GetKey()
        {
            var key = new DESFireKey();
            key.setKeyType(GetCryptoMethod());
            if (!string.IsNullOrEmpty(tbxKeyValue.Text))
            {
                key.fromString(KeyHelper.FormatKeyString(tbxKeyValue.Text));
            }
            var keydiv = GetKeyDiversification();
            if (keydiv != null)
            {
                key.setKeyDiversification(keydiv);
            }
            return key;
        }

        private void cbKeyDiversification_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxSystemIdentifier.Enabled = chkRevertAID.Enabled = cbKeyDiversification.SelectedIndex == 3;
        }

        public KeyDiversification? GetKeyDiversification()
        {
            KeyDiversification? keydiv = null;
            switch (cbKeyDiversification.SelectedIndex)
            {
                case 1:
                    keydiv = new SagemKeyDiversification();
                    break;
                case 2:
                    keydiv = new NXPAV1KeyDiversification();
                    break;
                case 3:
                    {
                        var av2keydiv = new NXPAV2KeyDiversification();
                        av2keydiv.setRevertAID(chkRevertAID.Checked);
                        if (!string.IsNullOrEmpty(tbxSystemIdentifier.Text))
                        {
                            av2keydiv.setSystemIdentifier(new ByteVector(Convert.FromHexString(tbxSystemIdentifier.Text)));
                        }
                        keydiv = av2keydiv;
                        break;
                    }
            }
            return keydiv;
        }
    }
}
