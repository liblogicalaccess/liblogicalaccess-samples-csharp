using LibLogicalAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RWCard_DESFire
{
    public partial class ReaderSelectionControl : UserControl
    {
        public ReaderSelectionControl()
        {
            InitializeComponent();
            if (!this.DesignMode && LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                RefreshReaderProviderList();
            }
        }

        public ReaderConfiguration GetReaderConfiguration()
        {
            var readerConfig = new ReaderConfiguration();
            using (var lib = LibraryManager.getInstance())
            {
                if (cbReaderProvider.SelectedIndex > -1)
                {
                    var readerProvider = lib.getReaderProvider(cbReaderProvider.SelectedItem.ToString());
                    readerConfig.setReaderProvider(readerProvider);

                    ReaderUnit readerUnit = null;
                    if (cbReaderUnit.SelectedIndex > -1)
                    {
                        var readerName = cbReaderUnit.SelectedItem.ToString();
                        // Best to get the instance matching the name from the already existing list
                        var readers = readerProvider.getReaderList();
                        readerUnit = readers.Where(r => r.getName() == readerName).FirstOrDefault();
                    }
                    else
                    {
                        // If no selection, we create a default reader unit instance for this provider and hope for the best
                        readerUnit = readerProvider.createReaderUnit();
                    }
                    readerConfig.setReaderUnit(readerUnit);
                }
            }
            return readerConfig;
        }

        private void RefreshReaderProviderList()
        {
            cbReaderProvider.Items.Clear();
            using (var lib = LibraryManager.getInstance())
            {
                cbReaderProvider.Items.AddRange(lib.getAvailableReaders().ToArray());
            }
            cbReaderProvider.SelectedItem = "PCSC";
        }

        private void RefreshReaderUnitList()
        {
            cbReaderUnit.Items.Clear();
            if (cbReaderProvider.SelectedIndex > -1)
            {
                using (var lib = LibraryManager.getInstance())
                {
                    // We don't keep the instance, we just want to list for now. It will be recreated later.
                    using (var readerProvider = lib.getReaderProvider(cbReaderProvider.SelectedItem.ToString()))
                    {
                        if (readerProvider == null)
                            throw new Exception("Cannot initialize the reader provider instance.");

                        var readers = readerProvider.getReaderList();
                        foreach (var reader in readers)
                        {
                            cbReaderUnit.Items.Add(reader.getName());
                        }
                        if (cbReaderUnit.Items.Count > 0)
                        {
                            cbReaderUnit.SelectedIndex = 0;
                        }
                    }
                }
            }
        }

        private void cbReaderProvider_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshReaderUnitList();
        }

        private void linkRefreshReaderUnit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshReaderUnitList();
        }
    }
}
