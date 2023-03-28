using LibLogicalAccess;
using LibLogicalAccess.Reader;
using System;
using System.Linq;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class RWCard : Form
    {
        public RWCard()
        {
            InitializeComponent();
        }

        private void ShowSample(LLASample sample)
        {
            sample.ReaderConfig = readerSelectionControl.GetReaderConfiguration();
            sample.ShowDialog(this);
        }

        private void btnCardStorageService_Click(object sender, EventArgs e)
        {
            ShowSample(new CardStorageServiceSample());
        }

        private void btnDESFireCommands_Click(object sender, EventArgs e)
        {
            ShowSample(new DESFireCommandsSample());
        }

        private void btnAuthWithSAM_Click(object sender, EventArgs e)
        {
            ShowSample(new AuthWithSAMSample());
        }
    }
}
