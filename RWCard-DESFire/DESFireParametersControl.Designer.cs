namespace RWCard_DESFire
{
    partial class DESFireParametersControl
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
            this.tbxApplicationId = new System.Windows.Forms.TextBox();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.nupFileNo = new System.Windows.Forms.NumericUpDown();
            this.lblFileNo = new System.Windows.Forms.Label();
            this.cbKeyType = new System.Windows.Forms.ComboBox();
            this.lblKeyType = new System.Windows.Forms.Label();
            this.tbxKeyValue = new System.Windows.Forms.TextBox();
            this.lblKeyValue = new System.Windows.Forms.Label();
            this.nupKeyNo = new System.Windows.Forms.NumericUpDown();
            this.lblKeyNo = new System.Windows.Forms.Label();
            this.nupTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTimeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupFileNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKeyNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxApplicationId
            // 
            this.tbxApplicationId.Location = new System.Drawing.Point(85, 29);
            this.tbxApplicationId.MaxLength = 6;
            this.tbxApplicationId.Name = "tbxApplicationId";
            this.tbxApplicationId.Size = new System.Drawing.Size(100, 20);
            this.tbxApplicationId.TabIndex = 23;
            this.tbxApplicationId.Text = "000000";
            this.tbxApplicationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Location = new System.Drawing.Point(5, 32);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(74, 13);
            this.lblApplicationId.TabIndex = 22;
            this.lblApplicationId.Text = "Application Id:";
            // 
            // nupFileNo
            // 
            this.nupFileNo.Location = new System.Drawing.Point(85, 58);
            this.nupFileNo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupFileNo.Name = "nupFileNo";
            this.nupFileNo.Size = new System.Drawing.Size(87, 20);
            this.nupFileNo.TabIndex = 21;
            this.nupFileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFileNo
            // 
            this.lblFileNo.AutoSize = true;
            this.lblFileNo.Location = new System.Drawing.Point(36, 60);
            this.lblFileNo.Name = "lblFileNo";
            this.lblFileNo.Size = new System.Drawing.Size(43, 13);
            this.lblFileNo.TabIndex = 20;
            this.lblFileNo.Text = "File No:";
            // 
            // cbKeyType
            // 
            this.cbKeyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKeyType.FormattingEnabled = true;
            this.cbKeyType.Items.AddRange(new object[] {
            "DES",
            "3K3DES",
            "AES"});
            this.cbKeyType.Location = new System.Drawing.Point(341, 55);
            this.cbKeyType.Name = "cbKeyType";
            this.cbKeyType.Size = new System.Drawing.Size(121, 21);
            this.cbKeyType.TabIndex = 19;
            // 
            // lblKeyType
            // 
            this.lblKeyType.AutoSize = true;
            this.lblKeyType.Location = new System.Drawing.Point(280, 60);
            this.lblKeyType.Name = "lblKeyType";
            this.lblKeyType.Size = new System.Drawing.Size(55, 13);
            this.lblKeyType.TabIndex = 18;
            this.lblKeyType.Text = "Key Type:";
            // 
            // tbxKeyValue
            // 
            this.tbxKeyValue.Location = new System.Drawing.Point(341, 29);
            this.tbxKeyValue.Name = "tbxKeyValue";
            this.tbxKeyValue.Size = new System.Drawing.Size(249, 20);
            this.tbxKeyValue.TabIndex = 17;
            this.tbxKeyValue.Text = "00000000000000000000000000000000";
            // 
            // lblKeyValue
            // 
            this.lblKeyValue.AutoSize = true;
            this.lblKeyValue.Location = new System.Drawing.Point(277, 32);
            this.lblKeyValue.Name = "lblKeyValue";
            this.lblKeyValue.Size = new System.Drawing.Size(58, 13);
            this.lblKeyValue.TabIndex = 16;
            this.lblKeyValue.Text = "Key Value:";
            // 
            // nupKeyNo
            // 
            this.nupKeyNo.Location = new System.Drawing.Point(341, 3);
            this.nupKeyNo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupKeyNo.Name = "nupKeyNo";
            this.nupKeyNo.Size = new System.Drawing.Size(87, 20);
            this.nupKeyNo.TabIndex = 15;
            this.nupKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeyNo
            // 
            this.lblKeyNo.AutoSize = true;
            this.lblKeyNo.Location = new System.Drawing.Point(290, 5);
            this.lblKeyNo.Name = "lblKeyNo";
            this.lblKeyNo.Size = new System.Drawing.Size(45, 13);
            this.lblKeyNo.TabIndex = 14;
            this.lblKeyNo.Text = "Key No:";
            // 
            // nupTimeout
            // 
            this.nupTimeout.Location = new System.Drawing.Point(85, 3);
            this.nupTimeout.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nupTimeout.Name = "nupTimeout";
            this.nupTimeout.Size = new System.Drawing.Size(120, 20);
            this.nupTimeout.TabIndex = 13;
            this.nupTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupTimeout.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // lblTimeout
            // 
            this.lblTimeout.AutoSize = true;
            this.lblTimeout.Location = new System.Drawing.Point(9, 5);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(70, 13);
            this.lblTimeout.TabIndex = 12;
            this.lblTimeout.Text = "Timeout (ms):";
            // 
            // DESFireParametersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxApplicationId);
            this.Controls.Add(this.lblApplicationId);
            this.Controls.Add(this.nupFileNo);
            this.Controls.Add(this.lblFileNo);
            this.Controls.Add(this.cbKeyType);
            this.Controls.Add(this.lblKeyType);
            this.Controls.Add(this.tbxKeyValue);
            this.Controls.Add(this.lblKeyValue);
            this.Controls.Add(this.nupKeyNo);
            this.Controls.Add(this.lblKeyNo);
            this.Controls.Add(this.nupTimeout);
            this.Controls.Add(this.lblTimeout);
            this.Name = "DESFireParametersControl";
            this.Size = new System.Drawing.Size(596, 84);
            ((System.ComponentModel.ISupportInitialize)(this.nupFileNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKeyNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxApplicationId;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.NumericUpDown nupFileNo;
        private System.Windows.Forms.Label lblFileNo;
        private System.Windows.Forms.ComboBox cbKeyType;
        private System.Windows.Forms.Label lblKeyType;
        private System.Windows.Forms.TextBox tbxKeyValue;
        private System.Windows.Forms.Label lblKeyValue;
        private System.Windows.Forms.NumericUpDown nupKeyNo;
        private System.Windows.Forms.Label lblKeyNo;
        private System.Windows.Forms.NumericUpDown nupTimeout;
        private System.Windows.Forms.Label lblTimeout;
    }
}
