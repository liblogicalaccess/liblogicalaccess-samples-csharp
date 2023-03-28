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
            this.gpSAMReader = new System.Windows.Forms.GroupBox();
            this.readerSelectionControl = new RWCard_DESFire.ReaderSelectionControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nupKeySlot = new System.Windows.Forms.NumericUpDown();
            this.lblKeySlot = new System.Windows.Forms.Label();
            this.tbxKeyValue = new System.Windows.Forms.TextBox();
            this.lblKeyValue = new System.Windows.Forms.Label();
            this.nupKeyNo = new System.Windows.Forms.NumericUpDown();
            this.lblKeyNo = new System.Windows.Forms.Label();
            this.gpParameters = new System.Windows.Forms.GroupBox();
            this.dfparams = new RWCard_DESFire.DESFireParametersControl();
            this.gpCommands = new System.Windows.Forms.GroupBox();
            this.btnRunAuthenticate = new System.Windows.Forms.Button();
            this.btnUnInit = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.gpSAMReader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKeySlot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKeyNo)).BeginInit();
            this.gpParameters.SuspendLayout();
            this.gpCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpSAMReader
            // 
            this.gpSAMReader.Controls.Add(this.readerSelectionControl);
            this.gpSAMReader.Controls.Add(this.panel1);
            this.gpSAMReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpSAMReader.Location = new System.Drawing.Point(0, 0);
            this.gpSAMReader.Name = "gpSAMReader";
            this.gpSAMReader.Size = new System.Drawing.Size(669, 143);
            this.gpSAMReader.TabIndex = 0;
            this.gpSAMReader.TabStop = false;
            this.gpSAMReader.Text = "SAM Reader";
            // 
            // readerSelectionControl
            // 
            this.readerSelectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerSelectionControl.Location = new System.Drawing.Point(3, 16);
            this.readerSelectionControl.Name = "readerSelectionControl";
            this.readerSelectionControl.Size = new System.Drawing.Size(663, 66);
            this.readerSelectionControl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.nupKeySlot);
            this.panel1.Controls.Add(this.lblKeySlot);
            this.panel1.Controls.Add(this.tbxKeyValue);
            this.panel1.Controls.Add(this.lblKeyValue);
            this.panel1.Controls.Add(this.nupKeyNo);
            this.panel1.Controls.Add(this.lblKeyNo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 58);
            this.panel1.TabIndex = 1;
            // 
            // nupKeySlot
            // 
            this.nupKeySlot.Location = new System.Drawing.Point(104, 32);
            this.nupKeySlot.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupKeySlot.Name = "nupKeySlot";
            this.nupKeySlot.Size = new System.Drawing.Size(87, 20);
            this.nupKeySlot.TabIndex = 21;
            this.nupKeySlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeySlot
            // 
            this.lblKeySlot.AutoSize = true;
            this.lblKeySlot.Location = new System.Drawing.Point(22, 34);
            this.lblKeySlot.Name = "lblKeySlot";
            this.lblKeySlot.Size = new System.Drawing.Size(76, 13);
            this.lblKeySlot.TabIndex = 20;
            this.lblKeySlot.Text = "PICC Key Slot:";
            // 
            // tbxKeyValue
            // 
            this.tbxKeyValue.Location = new System.Drawing.Point(341, 5);
            this.tbxKeyValue.Name = "tbxKeyValue";
            this.tbxKeyValue.Size = new System.Drawing.Size(249, 20);
            this.tbxKeyValue.TabIndex = 19;
            this.tbxKeyValue.Text = "00000000000000000000000000000000";
            // 
            // lblKeyValue
            // 
            this.lblKeyValue.AutoSize = true;
            this.lblKeyValue.Location = new System.Drawing.Point(240, 8);
            this.lblKeyValue.Name = "lblKeyValue";
            this.lblKeyValue.Size = new System.Drawing.Size(95, 13);
            this.lblKeyValue.TabIndex = 18;
            this.lblKeyValue.Text = "Unlock Key Value:";
            // 
            // nupKeyNo
            // 
            this.nupKeyNo.Location = new System.Drawing.Point(104, 6);
            this.nupKeyNo.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nupKeyNo.Name = "nupKeyNo";
            this.nupKeyNo.Size = new System.Drawing.Size(87, 20);
            this.nupKeyNo.TabIndex = 17;
            this.nupKeyNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKeyNo
            // 
            this.lblKeyNo.AutoSize = true;
            this.lblKeyNo.Location = new System.Drawing.Point(12, 8);
            this.lblKeyNo.Name = "lblKeyNo";
            this.lblKeyNo.Size = new System.Drawing.Size(86, 13);
            this.lblKeyNo.TabIndex = 16;
            this.lblKeyNo.Text = "Unlock Key Slot:";
            // 
            // gpParameters
            // 
            this.gpParameters.Controls.Add(this.dfparams);
            this.gpParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpParameters.Location = new System.Drawing.Point(0, 143);
            this.gpParameters.Name = "gpParameters";
            this.gpParameters.Size = new System.Drawing.Size(669, 104);
            this.gpParameters.TabIndex = 4;
            this.gpParameters.TabStop = false;
            this.gpParameters.Text = "Parameters";
            // 
            // dfparams
            // 
            this.dfparams.DisableFileParameters = true;
            this.dfparams.DisableKeyValueParameters = true;
            this.dfparams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfparams.Location = new System.Drawing.Point(3, 16);
            this.dfparams.Name = "dfparams";
            this.dfparams.Size = new System.Drawing.Size(663, 85);
            this.dfparams.TabIndex = 0;
            // 
            // gpCommands
            // 
            this.gpCommands.Controls.Add(this.btnRunAuthenticate);
            this.gpCommands.Controls.Add(this.btnUnInit);
            this.gpCommands.Controls.Add(this.btnInit);
            this.gpCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCommands.Location = new System.Drawing.Point(0, 247);
            this.gpCommands.Name = "gpCommands";
            this.gpCommands.Size = new System.Drawing.Size(669, 74);
            this.gpCommands.TabIndex = 5;
            this.gpCommands.TabStop = false;
            this.gpCommands.Text = "Commands";
            // 
            // btnRunAuthenticate
            // 
            this.btnRunAuthenticate.Location = new System.Drawing.Point(246, 19);
            this.btnRunAuthenticate.Name = "btnRunAuthenticate";
            this.btnRunAuthenticate.Size = new System.Drawing.Size(171, 44);
            this.btnRunAuthenticate.TabIndex = 6;
            this.btnRunAuthenticate.Text = "Authenticate";
            this.btnRunAuthenticate.UseVisualStyleBackColor = true;
            this.btnRunAuthenticate.Click += new System.EventHandler(this.btnRunAuthenticate_Click);
            // 
            // btnUnInit
            // 
            this.btnUnInit.Location = new System.Drawing.Point(423, 19);
            this.btnUnInit.Name = "btnUnInit";
            this.btnUnInit.Size = new System.Drawing.Size(171, 44);
            this.btnUnInit.TabIndex = 5;
            this.btnUnInit.Text = "UnInit";
            this.btnUnInit.UseVisualStyleBackColor = true;
            this.btnUnInit.Click += new System.EventHandler(this.btnUnInit_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(69, 19);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(171, 44);
            this.btnInit.TabIndex = 4;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // AuthWithSAMSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 321);
            this.Controls.Add(this.gpCommands);
            this.Controls.Add(this.gpParameters);
            this.Controls.Add(this.gpSAMReader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthWithSAMSample";
            this.Text = "Authenticate with a SAM";
            this.gpSAMReader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupKeySlot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupKeyNo)).EndInit();
            this.gpParameters.ResumeLayout(false);
            this.gpCommands.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}