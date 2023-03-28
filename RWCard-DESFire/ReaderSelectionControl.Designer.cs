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
            this.linkRefreshReaderUnit = new System.Windows.Forms.LinkLabel();
            this.cbReaderUnit = new System.Windows.Forms.ComboBox();
            this.cbReaderProvider = new System.Windows.Forms.ComboBox();
            this.lblReaderUnit = new System.Windows.Forms.Label();
            this.lblReaderProvider = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkRefreshReaderUnit
            // 
            this.linkRefreshReaderUnit.AutoSize = true;
            this.linkRefreshReaderUnit.Location = new System.Drawing.Point(426, 39);
            this.linkRefreshReaderUnit.Name = "linkRefreshReaderUnit";
            this.linkRefreshReaderUnit.Size = new System.Drawing.Size(44, 13);
            this.linkRefreshReaderUnit.TabIndex = 9;
            this.linkRefreshReaderUnit.TabStop = true;
            this.linkRefreshReaderUnit.Text = "Refresh";
            // 
            // cbReaderUnit
            // 
            this.cbReaderUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaderUnit.FormattingEnabled = true;
            this.cbReaderUnit.Location = new System.Drawing.Point(100, 36);
            this.cbReaderUnit.Name = "cbReaderUnit";
            this.cbReaderUnit.Size = new System.Drawing.Size(320, 21);
            this.cbReaderUnit.TabIndex = 8;
            // 
            // cbReaderProvider
            // 
            this.cbReaderProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaderProvider.FormattingEnabled = true;
            this.cbReaderProvider.Location = new System.Drawing.Point(100, 3);
            this.cbReaderProvider.Name = "cbReaderProvider";
            this.cbReaderProvider.Size = new System.Drawing.Size(320, 21);
            this.cbReaderProvider.TabIndex = 7;
            this.cbReaderProvider.SelectedIndexChanged += new System.EventHandler(this.cbReaderProvider_SelectedIndexChanged);
            // 
            // lblReaderUnit
            // 
            this.lblReaderUnit.AutoSize = true;
            this.lblReaderUnit.Location = new System.Drawing.Point(27, 39);
            this.lblReaderUnit.Name = "lblReaderUnit";
            this.lblReaderUnit.Size = new System.Drawing.Size(67, 13);
            this.lblReaderUnit.TabIndex = 6;
            this.lblReaderUnit.Text = "Reader Unit:";
            // 
            // lblReaderProvider
            // 
            this.lblReaderProvider.AutoSize = true;
            this.lblReaderProvider.Location = new System.Drawing.Point(7, 6);
            this.lblReaderProvider.Name = "lblReaderProvider";
            this.lblReaderProvider.Size = new System.Drawing.Size(87, 13);
            this.lblReaderProvider.TabIndex = 5;
            this.lblReaderProvider.Text = "Reader Provider:";
            // 
            // ReaderSelectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkRefreshReaderUnit);
            this.Controls.Add(this.cbReaderUnit);
            this.Controls.Add(this.cbReaderProvider);
            this.Controls.Add(this.lblReaderUnit);
            this.Controls.Add(this.lblReaderProvider);
            this.Name = "ReaderSelectionControl";
            this.Size = new System.Drawing.Size(470, 66);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkRefreshReaderUnit;
        private System.Windows.Forms.ComboBox cbReaderUnit;
        private System.Windows.Forms.ComboBox cbReaderProvider;
        private System.Windows.Forms.Label lblReaderUnit;
        private System.Windows.Forms.Label lblReaderProvider;
    }
}
