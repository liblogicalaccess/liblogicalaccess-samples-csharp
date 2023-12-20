using LibLogicalAccess;
using LibLogicalAccess.Card;
using LibLogicalAccess.Reader;
using System;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class SAMCommandsSample : LLASample
    {
        public SAMCommandsSample()
        {
            InitializeComponent();
        }

        private Chip chip = null;
        private SAMKeyEntrySETAV2Commands cmd = null;

        private void btnInit_Click(object sender, System.EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            ru.connectToReader();
            if (ru.waitInsertion(dfparams.GetTimeout()))
            {
                ru.connect();
                chip = ru.getSingleChip();
                if (chip.getGenericCardType() != "SAM")
                    throw new Exception("NXP SAM AVx chip required");

                var ct = chip.getCardType();
                if (ct == "SAM_AV2" || ct == "SAM_AV3")
                    cmd = chip.getCommands() as SAMKeyEntrySETAV2Commands;
            }
        }

        private void btnUnInit_Click(object sender, EventArgs e)
        {
            var ru = ReaderConfig.getReaderUnit();
            ru.disconnect();
            ru.waitRemoval(dfparams.GetTimeout());
            ru.disconnectFromReader();
        }

        private void btnGetUID_Click(object sender, EventArgs e)
        {
            var csndata = chip.getChipIdentifier();
            var csn = BitConverter.ToString(csndata.ToArray());
            var vs = cmd.getVersion();
            var uid = BitConverter.ToString(vs.manufacture.uniqueserialnumber);
            MessageBox.Show(String.Format("CSN: {0} - Manufacturer UID: {1}", csn, uid));
        }
    }
}
