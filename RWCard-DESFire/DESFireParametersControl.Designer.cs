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
            tbxApplicationId = new System.Windows.Forms.TextBox();
            lblApplicationId = new System.Windows.Forms.Label();
            nupFileNo = new System.Windows.Forms.NumericUpDown();
            lblFileNo = new System.Windows.Forms.Label();
            nupKeyNo = new System.Windows.Forms.NumericUpDown();
            lblKeyNo = new System.Windows.Forms.Label();
            nupTimeout = new System.Windows.Forms.NumericUpDown();
            lblTimeout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nupFileNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupKeyNo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupTimeout).BeginInit();
            SuspendLayout();
            // 
            // tbxApplicationId
            // 
            tbxApplicationId.Location = new System.Drawing.Point(142, 56);
            tbxApplicationId.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tbxApplicationId.MaxLength = 6;
            tbxApplicationId.Name = "tbxApplicationId";
            tbxApplicationId.Size = new System.Drawing.Size(164, 31);
            tbxApplicationId.TabIndex = 23;
            tbxApplicationId.Text = "000000";
            tbxApplicationId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApplicationId
            // 
            lblApplicationId.AutoSize = true;
            lblApplicationId.Location = new System.Drawing.Point(8, 62);
            lblApplicationId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblApplicationId.Name = "lblApplicationId";
            lblApplicationId.Size = new System.Drawing.Size(127, 25);
            lblApplicationId.TabIndex = 22;
            lblApplicationId.Text = "Application Id:";
            // 
            // nupFileNo
            // 
            nupFileNo.Location = new System.Drawing.Point(568, 56);
            nupFileNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            nupFileNo.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nupFileNo.Name = "nupFileNo";
            nupFileNo.Size = new System.Drawing.Size(145, 31);
            nupFileNo.TabIndex = 21;
            nupFileNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFileNo
            // 
            lblFileNo.AutoSize = true;
            lblFileNo.Location = new System.Drawing.Point(486, 59);
            lblFileNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblFileNo.Name = "lblFileNo";
            lblFileNo.Size = new System.Drawing.Size(71, 25);
            lblFileNo.TabIndex = 20;
            lblFileNo.Text = "File No:";
            // 
            // nupKeyNo
            // 
            nupKeyNo.Location = new System.Drawing.Point(568, 6);
            nupKeyNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            nupKeyNo.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nupKeyNo.Name = "nupKeyNo";
            nupKeyNo.Size = new System.Drawing.Size(145, 31);
            nupKeyNo.TabIndex = 15;
            nupKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeyNo
            // 
            lblKeyNo.AutoSize = true;
            lblKeyNo.Location = new System.Drawing.Point(483, 10);
            lblKeyNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyNo.Name = "lblKeyNo";
            lblKeyNo.Size = new System.Drawing.Size(73, 25);
            lblKeyNo.TabIndex = 14;
            lblKeyNo.Text = "Key No:";
            // 
            // nupTimeout
            // 
            nupTimeout.Location = new System.Drawing.Point(142, 6);
            nupTimeout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            nupTimeout.Maximum = new decimal(new int[] { 60000, 0, 0, 0 });
            nupTimeout.Name = "nupTimeout";
            nupTimeout.Size = new System.Drawing.Size(200, 31);
            nupTimeout.TabIndex = 13;
            nupTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            nupTimeout.Value = new decimal(new int[] { 3000, 0, 0, 0 });
            // 
            // lblTimeout
            // 
            lblTimeout.AutoSize = true;
            lblTimeout.Location = new System.Drawing.Point(15, 10);
            lblTimeout.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblTimeout.Name = "lblTimeout";
            lblTimeout.Size = new System.Drawing.Size(120, 25);
            lblTimeout.TabIndex = 12;
            lblTimeout.Text = "Timeout (ms):";
            // 
            // DESFireParametersControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tbxApplicationId);
            Controls.Add(lblApplicationId);
            Controls.Add(nupFileNo);
            Controls.Add(lblFileNo);
            Controls.Add(nupKeyNo);
            Controls.Add(lblKeyNo);
            Controls.Add(nupTimeout);
            Controls.Add(lblTimeout);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "DESFireParametersControl";
            Size = new System.Drawing.Size(721, 95);
            ((System.ComponentModel.ISupportInitialize)nupFileNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupKeyNo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupTimeout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbxApplicationId;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.NumericUpDown nupFileNo;
        private System.Windows.Forms.Label lblFileNo;
        private System.Windows.Forms.NumericUpDown nupKeyNo;
        private System.Windows.Forms.Label lblKeyNo;
        private System.Windows.Forms.NumericUpDown nupTimeout;
        private System.Windows.Forms.Label lblTimeout;
    }
}
