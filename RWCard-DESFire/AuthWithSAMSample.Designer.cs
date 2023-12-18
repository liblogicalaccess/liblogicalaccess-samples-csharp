namespace RWCard_DESFire
{
    partial class AuthWithSAMSample
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gpSAMReader = new System.Windows.Forms.GroupBox();
            readerSelectionControl = new ReaderSelectionControl();
            panel1 = new System.Windows.Forms.Panel();
            nupKeyVersion = new System.Windows.Forms.NumericUpDown();
            lblKeyVersion = new System.Windows.Forms.Label();
            nupKeySlot = new System.Windows.Forms.NumericUpDown();
            lblKeySlot = new System.Windows.Forms.Label();
            tbxKeyValue = new System.Windows.Forms.TextBox();
            lblKeyValue = new System.Windows.Forms.Label();
            nupKeyNo = new System.Windows.Forms.NumericUpDown();
            lblKeyNo = new System.Windows.Forms.Label();
            gpParameters = new System.Windows.Forms.GroupBox();
            dfparams = new DESFireParametersControl();
            gpCommands = new System.Windows.Forms.GroupBox();
            btnReadData = new System.Windows.Forms.Button();
            btnRunAuthenticate = new System.Windows.Forms.Button();
            btnUnInit = new System.Windows.Forms.Button();
            btnInit = new System.Windows.Forms.Button();
            gpKey = new System.Windows.Forms.GroupBox();
            keyparams = new KeyParametersControl();
            gpSAMReader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupKeyVersion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupKeySlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupKeyNo).BeginInit();
            gpParameters.SuspendLayout();
            gpCommands.SuspendLayout();
            gpKey.SuspendLayout();
            SuspendLayout();
            // 
            // gpSAMReader
            // 
            gpSAMReader.Controls.Add(readerSelectionControl);
            gpSAMReader.Controls.Add(panel1);
            gpSAMReader.Dock = System.Windows.Forms.DockStyle.Top;
            gpSAMReader.Location = new System.Drawing.Point(0, 0);
            gpSAMReader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpSAMReader.Name = "gpSAMReader";
            gpSAMReader.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpSAMReader.Size = new System.Drawing.Size(1188, 264);
            gpSAMReader.TabIndex = 0;
            gpSAMReader.TabStop = false;
            gpSAMReader.Text = "SAM Reader";
            // 
            // readerSelectionControl
            // 
            readerSelectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            readerSelectionControl.Location = new System.Drawing.Point(5, 30);
            readerSelectionControl.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            readerSelectionControl.Name = "readerSelectionControl";
            readerSelectionControl.Size = new System.Drawing.Size(1178, 122);
            readerSelectionControl.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(nupKeyVersion);
            panel1.Controls.Add(lblKeyVersion);
            panel1.Controls.Add(nupKeySlot);
            panel1.Controls.Add(lblKeySlot);
            panel1.Controls.Add(tbxKeyValue);
            panel1.Controls.Add(lblKeyValue);
            panel1.Controls.Add(nupKeyNo);
            panel1.Controls.Add(lblKeyNo);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(5, 152);
            panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1178, 106);
            panel1.TabIndex = 1;
            // 
            // nupKeyVersion
            // 
            nupKeyVersion.Location = new System.Drawing.Point(757, 65);
            nupKeyVersion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            nupKeyVersion.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nupKeyVersion.Name = "nupKeyVersion";
            nupKeyVersion.Size = new System.Drawing.Size(145, 31);
            nupKeyVersion.TabIndex = 23;
            nupKeyVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeyVersion
            // 
            lblKeyVersion.AutoSize = true;
            lblKeyVersion.Location = new System.Drawing.Point(590, 67);
            lblKeyVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyVersion.Name = "lblKeyVersion";
            lblKeyVersion.Size = new System.Drawing.Size(149, 25);
            lblKeyVersion.TabIndex = 22;
            lblKeyVersion.Text = "PICC Key Version:";
            // 
            // nupKeySlot
            // 
            nupKeySlot.Location = new System.Drawing.Point(232, 65);
            nupKeySlot.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            nupKeySlot.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nupKeySlot.Name = "nupKeySlot";
            nupKeySlot.Size = new System.Drawing.Size(145, 31);
            nupKeySlot.TabIndex = 21;
            nupKeySlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeySlot
            // 
            lblKeySlot.AutoSize = true;
            lblKeySlot.Location = new System.Drawing.Point(96, 68);
            lblKeySlot.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeySlot.Name = "lblKeySlot";
            lblKeySlot.Size = new System.Drawing.Size(122, 25);
            lblKeySlot.TabIndex = 20;
            lblKeySlot.Text = "PICC Key Slot:";
            // 
            // tbxKeyValue
            // 
            tbxKeyValue.Location = new System.Drawing.Point(757, 12);
            tbxKeyValue.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            tbxKeyValue.Name = "tbxKeyValue";
            tbxKeyValue.Size = new System.Drawing.Size(412, 31);
            tbxKeyValue.TabIndex = 19;
            tbxKeyValue.Text = "00000000000000000000000000000000";
            // 
            // lblKeyValue
            // 
            lblKeyValue.AutoSize = true;
            lblKeyValue.Location = new System.Drawing.Point(589, 17);
            lblKeyValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyValue.Name = "lblKeyValue";
            lblKeyValue.Size = new System.Drawing.Size(150, 25);
            lblKeyValue.TabIndex = 18;
            lblKeyValue.Text = "Unlock Key Value:";
            // 
            // nupKeyNo
            // 
            nupKeyNo.Location = new System.Drawing.Point(232, 15);
            nupKeyNo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            nupKeyNo.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nupKeyNo.Name = "nupKeyNo";
            nupKeyNo.Size = new System.Drawing.Size(145, 31);
            nupKeyNo.TabIndex = 17;
            nupKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeyNo
            // 
            lblKeyNo.AutoSize = true;
            lblKeyNo.Location = new System.Drawing.Point(79, 18);
            lblKeyNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            lblKeyNo.Name = "lblKeyNo";
            lblKeyNo.Size = new System.Drawing.Size(139, 25);
            lblKeyNo.TabIndex = 16;
            lblKeyNo.Text = "Unlock Key Slot:";
            // 
            // gpParameters
            // 
            gpParameters.Controls.Add(dfparams);
            gpParameters.Dock = System.Windows.Forms.DockStyle.Top;
            gpParameters.Location = new System.Drawing.Point(0, 264);
            gpParameters.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpParameters.Name = "gpParameters";
            gpParameters.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpParameters.Size = new System.Drawing.Size(1188, 140);
            gpParameters.TabIndex = 4;
            gpParameters.TabStop = false;
            gpParameters.Text = "Parameters";
            // 
            // dfparams
            // 
            dfparams.Dock = System.Windows.Forms.DockStyle.Fill;
            dfparams.Location = new System.Drawing.Point(5, 30);
            dfparams.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            dfparams.Name = "dfparams";
            dfparams.Size = new System.Drawing.Size(1178, 104);
            dfparams.TabIndex = 0;
            // 
            // gpCommands
            // 
            gpCommands.Controls.Add(btnReadData);
            gpCommands.Controls.Add(btnRunAuthenticate);
            gpCommands.Controls.Add(btnUnInit);
            gpCommands.Controls.Add(btnInit);
            gpCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            gpCommands.Location = new System.Drawing.Point(0, 578);
            gpCommands.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommands.Name = "gpCommands";
            gpCommands.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommands.Size = new System.Drawing.Size(1188, 132);
            gpCommands.TabIndex = 5;
            gpCommands.TabStop = false;
            gpCommands.Text = "Commands";
            // 
            // btnReadData
            // 
            btnReadData.Location = new System.Drawing.Point(600, 36);
            btnReadData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnReadData.Name = "btnReadData";
            btnReadData.Size = new System.Drawing.Size(285, 85);
            btnReadData.TabIndex = 7;
            btnReadData.Text = "Read Data";
            btnReadData.UseVisualStyleBackColor = true;
            btnReadData.Click += btnReadData_Click;
            // 
            // btnRunAuthenticate
            // 
            btnRunAuthenticate.Location = new System.Drawing.Point(305, 36);
            btnRunAuthenticate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnRunAuthenticate.Name = "btnRunAuthenticate";
            btnRunAuthenticate.Size = new System.Drawing.Size(285, 85);
            btnRunAuthenticate.TabIndex = 6;
            btnRunAuthenticate.Text = "Authenticate";
            btnRunAuthenticate.UseVisualStyleBackColor = true;
            btnRunAuthenticate.Click += btnRunAuthenticate_Click;
            // 
            // btnUnInit
            // 
            btnUnInit.Location = new System.Drawing.Point(895, 36);
            btnUnInit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnUnInit.Name = "btnUnInit";
            btnUnInit.Size = new System.Drawing.Size(285, 85);
            btnUnInit.TabIndex = 5;
            btnUnInit.Text = "UnInit";
            btnUnInit.UseVisualStyleBackColor = true;
            btnUnInit.Click += btnUnInit_Click;
            // 
            // btnInit
            // 
            btnInit.Location = new System.Drawing.Point(10, 36);
            btnInit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnInit.Name = "btnInit";
            btnInit.Size = new System.Drawing.Size(285, 85);
            btnInit.TabIndex = 4;
            btnInit.Text = "Init";
            btnInit.UseVisualStyleBackColor = true;
            btnInit.Click += btnInit_Click;
            // 
            // gpKey
            // 
            gpKey.Controls.Add(keyparams);
            gpKey.Dock = System.Windows.Forms.DockStyle.Top;
            gpKey.Location = new System.Drawing.Point(0, 404);
            gpKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpKey.Name = "gpKey";
            gpKey.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpKey.Size = new System.Drawing.Size(1188, 174);
            gpKey.TabIndex = 7;
            gpKey.TabStop = false;
            gpKey.Text = "Key";
            // 
            // keyparams
            // 
            keyparams.DisableKeyValueParameters = true;
            keyparams.Dock = System.Windows.Forms.DockStyle.Fill;
            keyparams.Location = new System.Drawing.Point(5, 30);
            keyparams.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            keyparams.Name = "keyparams";
            keyparams.Size = new System.Drawing.Size(1178, 138);
            keyparams.TabIndex = 0;
            // 
            // AuthWithSAMSample
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1188, 710);
            Controls.Add(gpCommands);
            Controls.Add(gpKey);
            Controls.Add(gpParameters);
            Controls.Add(gpSAMReader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "AuthWithSAMSample";
            Text = "Authenticate with a SAM";
            gpSAMReader.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupKeyVersion).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupKeySlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupKeyNo).EndInit();
            gpParameters.ResumeLayout(false);
            gpCommands.ResumeLayout(false);
            gpKey.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gpSAMReader;
        private System.Windows.Forms.GroupBox gpParameters;
        private DESFireParametersControl dfparams;
        private ReaderSelectionControl readerSelectionControl;
        private System.Windows.Forms.GroupBox gpCommands;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnUnInit;
        private System.Windows.Forms.Button btnRunAuthenticate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nupKeyNo;
        private System.Windows.Forms.Label lblKeyNo;
        private System.Windows.Forms.TextBox tbxKeyValue;
        private System.Windows.Forms.Label lblKeyValue;
        private System.Windows.Forms.NumericUpDown nupKeySlot;
        private System.Windows.Forms.Label lblKeySlot;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.NumericUpDown nupKeyVersion;
        private System.Windows.Forms.Label lblKeyVersion;
        private System.Windows.Forms.GroupBox gpKey;
        private KeyParametersControl keyparams;
    }
}