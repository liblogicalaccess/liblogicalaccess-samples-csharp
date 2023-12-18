namespace RWCard_DESFire
{
    partial class KeyParametersControl
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
            cbKeyType = new System.Windows.Forms.ComboBox();
            lblKeyType = new System.Windows.Forms.Label();
            tbxKeyValue = new System.Windows.Forms.TextBox();
            lblKeyValue = new System.Windows.Forms.Label();
            chkRevertAID = new System.Windows.Forms.CheckBox();
            tbxSystemIdentifier = new System.Windows.Forms.TextBox();
            lblSystemIdentifier = new System.Windows.Forms.Label();
            cbKeyDiversification = new System.Windows.Forms.ComboBox();
            lblKeyDiversification = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // cbKeyType
            // 
            cbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbKeyType.FormattingEnabled = true;
            cbKeyType.Items.AddRange(new object[] { "DES", "3K3DES", "AES" });
            cbKeyType.Location = new System.Drawing.Point(709, 13);
            cbKeyType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cbKeyType.Name = "cbKeyType";
            cbKeyType.Size = new System.Drawing.Size(199, 33);
            cbKeyType.TabIndex = 19;
            // 
            // lblKeyType
            // 
            lblKeyType.AutoSize = true;
            lblKeyType.Location = new System.Drawing.Point(613, 16);
            lblKeyType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyType.Name = "lblKeyType";
            lblKeyType.Size = new System.Drawing.Size(86, 25);
            lblKeyType.TabIndex = 18;
            lblKeyType.Text = "Key Type:";
            // 
            // tbxKeyValue
            // 
            tbxKeyValue.Location = new System.Drawing.Point(106, 15);
            tbxKeyValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tbxKeyValue.Name = "tbxKeyValue";
            tbxKeyValue.Size = new System.Drawing.Size(412, 31);
            tbxKeyValue.TabIndex = 17;
            tbxKeyValue.Text = "00000000000000000000000000000000";
            // 
            // lblKeyValue
            // 
            lblKeyValue.AutoSize = true;
            lblKeyValue.Location = new System.Drawing.Point(5, 21);
            lblKeyValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyValue.Name = "lblKeyValue";
            lblKeyValue.Size = new System.Drawing.Size(91, 25);
            lblKeyValue.TabIndex = 16;
            lblKeyValue.Text = "Key Value:";
            // 
            // chkRevertAID
            // 
            chkRevertAID.Enabled = false;
            chkRevertAID.Location = new System.Drawing.Point(709, 99);
            chkRevertAID.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            chkRevertAID.Name = "chkRevertAID";
            chkRevertAID.Size = new System.Drawing.Size(203, 31);
            chkRevertAID.TabIndex = 33;
            chkRevertAID.Text = "Revert AID (LSB first)";
            // 
            // tbxSystemIdentifier
            // 
            tbxSystemIdentifier.Enabled = false;
            tbxSystemIdentifier.Location = new System.Drawing.Point(709, 56);
            tbxSystemIdentifier.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tbxSystemIdentifier.Name = "tbxSystemIdentifier";
            tbxSystemIdentifier.Size = new System.Drawing.Size(145, 31);
            tbxSystemIdentifier.TabIndex = 32;
            // 
            // lblSystemIdentifier
            // 
            lblSystemIdentifier.AutoSize = true;
            lblSystemIdentifier.Location = new System.Drawing.Point(541, 61);
            lblSystemIdentifier.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblSystemIdentifier.Name = "lblSystemIdentifier";
            lblSystemIdentifier.Size = new System.Drawing.Size(148, 25);
            lblSystemIdentifier.TabIndex = 31;
            lblSystemIdentifier.Text = "System Identifier:";
            // 
            // cbKeyDiversification
            // 
            cbKeyDiversification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbKeyDiversification.FormattingEnabled = true;
            cbKeyDiversification.Items.AddRange(new object[] { "None", "Sagem", "NXP AV1 Diversification", "NXP AV2 Diversification (AN10922)" });
            cbKeyDiversification.Location = new System.Drawing.Point(219, 56);
            cbKeyDiversification.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            cbKeyDiversification.Name = "cbKeyDiversification";
            cbKeyDiversification.Size = new System.Drawing.Size(299, 33);
            cbKeyDiversification.TabIndex = 30;
            cbKeyDiversification.SelectedIndexChanged += cbKeyDiversification_SelectedIndexChanged;
            // 
            // lblKeyDiversification
            // 
            lblKeyDiversification.AutoSize = true;
            lblKeyDiversification.Location = new System.Drawing.Point(7, 61);
            lblKeyDiversification.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyDiversification.Name = "lblKeyDiversification";
            lblKeyDiversification.Size = new System.Drawing.Size(160, 25);
            lblKeyDiversification.TabIndex = 29;
            lblKeyDiversification.Text = "Key Diversification:";
            // 
            // KeyParametersControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(chkRevertAID);
            Controls.Add(tbxSystemIdentifier);
            Controls.Add(lblSystemIdentifier);
            Controls.Add(cbKeyDiversification);
            Controls.Add(lblKeyDiversification);
            Controls.Add(cbKeyType);
            Controls.Add(lblKeyType);
            Controls.Add(tbxKeyValue);
            Controls.Add(lblKeyValue);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "KeyParametersControl";
            Size = new System.Drawing.Size(993, 136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox cbKeyType;
        private System.Windows.Forms.Label lblKeyType;
        private System.Windows.Forms.TextBox tbxKeyValue;
        private System.Windows.Forms.Label lblKeyValue;
        private System.Windows.Forms.CheckBox chkRevertAID;
        private System.Windows.Forms.TextBox tbxSystemIdentifier;
        private System.Windows.Forms.Label lblSystemIdentifier;
        private System.Windows.Forms.ComboBox cbKeyDiversification;
        private System.Windows.Forms.Label lblKeyDiversification;
    }
}
