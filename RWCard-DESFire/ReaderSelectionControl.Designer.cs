namespace RWCard_DESFire
{
    partial class ReaderSelectionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkRefreshReaderUnit = new System.Windows.Forms.LinkLabel();
            cbReaderUnit = new System.Windows.Forms.ComboBox();
            cbReaderProvider = new System.Windows.Forms.ComboBox();
            lblReaderUnit = new System.Windows.Forms.Label();
            lblReaderProvider = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // linkRefreshReaderUnit
            // 
            linkRefreshReaderUnit.AutoSize = true;
            linkRefreshReaderUnit.Location = new System.Drawing.Point(710, 75);
            linkRefreshReaderUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            linkRefreshReaderUnit.Name = "linkRefreshReaderUnit";
            linkRefreshReaderUnit.Size = new System.Drawing.Size(70, 25);
            linkRefreshReaderUnit.TabIndex = 9;
            linkRefreshReaderUnit.TabStop = true;
            linkRefreshReaderUnit.Text = "Refresh";
            linkRefreshReaderUnit.LinkClicked += linkRefreshReaderUnit_LinkClicked;
            // 
            // cbReaderUnit
            // 
            cbReaderUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbReaderUnit.FormattingEnabled = true;
            cbReaderUnit.Location = new System.Drawing.Point(167, 69);
            cbReaderUnit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cbReaderUnit.Name = "cbReaderUnit";
            cbReaderUnit.Size = new System.Drawing.Size(531, 33);
            cbReaderUnit.TabIndex = 8;
            // 
            // cbReaderProvider
            // 
            cbReaderProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbReaderProvider.FormattingEnabled = true;
            cbReaderProvider.Location = new System.Drawing.Point(167, 6);
            cbReaderProvider.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cbReaderProvider.Name = "cbReaderProvider";
            cbReaderProvider.Size = new System.Drawing.Size(531, 33);
            cbReaderProvider.TabIndex = 7;
            cbReaderProvider.SelectedIndexChanged += cbReaderProvider_SelectedIndexChanged;
            // 
            // lblReaderUnit
            // 
            lblReaderUnit.AutoSize = true;
            lblReaderUnit.Location = new System.Drawing.Point(45, 75);
            lblReaderUnit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblReaderUnit.Name = "lblReaderUnit";
            lblReaderUnit.Size = new System.Drawing.Size(107, 25);
            lblReaderUnit.TabIndex = 6;
            lblReaderUnit.Text = "Reader Unit:";
            // 
            // lblReaderProvider
            // 
            lblReaderProvider.AutoSize = true;
            lblReaderProvider.Location = new System.Drawing.Point(12, 12);
            lblReaderProvider.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblReaderProvider.Name = "lblReaderProvider";
            lblReaderProvider.Size = new System.Drawing.Size(141, 25);
            lblReaderProvider.TabIndex = 5;
            lblReaderProvider.Text = "Reader Provider:";
            // 
            // ReaderSelectionControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(linkRefreshReaderUnit);
            Controls.Add(cbReaderUnit);
            Controls.Add(cbReaderProvider);
            Controls.Add(lblReaderUnit);
            Controls.Add(lblReaderProvider);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "ReaderSelectionControl";
            Size = new System.Drawing.Size(783, 127);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRefreshReaderUnit;
        private System.Windows.Forms.ComboBox cbReaderUnit;
        private System.Windows.Forms.ComboBox cbReaderProvider;
        private System.Windows.Forms.Label lblReaderUnit;
        private System.Windows.Forms.Label lblReaderProvider;
    }
}
