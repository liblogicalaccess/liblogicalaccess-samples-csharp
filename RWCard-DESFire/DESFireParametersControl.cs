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
    public partial class DESFireParametersControl : UserControl
    {
        public DESFireParametersControl()
        {
            InitializeComponent();
            cbKeyType.SelectedIndex = 0;
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.DefaultValue(false)]
        public bool DisableFileParameters
        {
            get { return !nupFileNo.Enabled; }
            set { nupFileNo.Enabled = !value; }
        }

        [System.ComponentModel.Browsable(true), System.ComponentModel.DefaultValue(false)]
        public bool DisableKeyValueParameters
        {
            get { return !tbxKeyValue.Enabled; }
            set { tbxKeyValue.Enabled = !value; }
        }

        public uint GetTimeout()
        {
            return (uint)nupTimeout.Value;
        }

        public uint GetApplicationID()
        {
            return uint.Parse(tbxApplicationId.Text, System.Globalization.NumberStyles.HexNumber);
        }

        public byte GetFileNo()
        {
            return (byte)nupFileNo.Value;
        }

        public byte GetKeyNo()
        {
            return (byte)nupKeyNo.Value;
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
            key.fromString(tbxKeyValue.Text);
            return key;
        }
    }
}
