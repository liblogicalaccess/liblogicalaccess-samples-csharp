namespace RWCard_DESFire
{
    partial class RWCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RWCard));
            this.gpCardServices = new System.Windows.Forms.GroupBox();
            this.btnDESFireCommands = new System.Windows.Forms.Button();
            this.btnCardStorageService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpReader = new System.Windows.Forms.GroupBox();
            this.lblReaderProvider = new System.Windows.Forms.Label();
            this.lblReaderUnit = new System.Windows.Forms.Label();
            this.cbReaderProvider = new System.Windows.Forms.ComboBox();
            this.cbReaderUnit = new System.Windows.Forms.ComboBox();
            this.linkRefreshReaderUnit = new System.Windows.Forms.LinkLabel();
            this.gpCardServices.SuspendLayout();
            this.gpReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCardServices
            // 
            this.gpCardServices.Controls.Add(this.btnDESFireCommands);
            this.gpCardServices.Controls.Add(this.btnCardStorageService);
            this.gpCardServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCardServices.Location = new System.Drawing.Point(0, 122);
            this.gpCardServices.Name = "gpCardServices";
            this.gpCardServices.Size = new System.Drawing.Size(598, 137);
            this.gpCardServices.TabIndex = 1;
            this.gpCardServices.TabStop = false;
            this.gpCardServices.Text = "Card Services";
            // 
            // btnDESFireCommands
            // 
            this.btnDESFireCommands.Location = new System.Drawing.Point(311, 34);
            this.btnDESFireCommands.Name = "btnDESFireCommands";
            this.btnDESFireCommands.Size = new System.Drawing.Size(155, 71);
            this.btnDESFireCommands.TabIndex = 3;
            this.btnDESFireCommands.Text = "DESFire Commands";
            this.btnDESFireCommands.UseVisualStyleBackColor = true;
            this.btnDESFireCommands.Click += new System.EventHandler(this.btnDESFireCommands_Click);
            // 
            // btnCardStorageService
            // 
            this.btnCardStorageService.Location = new System.Drawing.Point(123, 34);
            this.btnCardStorageService.Name = "btnCardStorageService";
            this.btnCardStorageService.Size = new System.Drawing.Size(155, 71);
            this.btnCardStorageService.TabIndex = 2;
            this.btnCardStorageService.Text = "Read and Write using Card Storage service";
            this.btnCardStorageService.UseVisualStyleBackColor = true;
            this.btnCardStorageService.Click += new System.EventHandler(this.btnCardStorageService_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // gpReader
            // 
            this.gpReader.Controls.Add(this.linkRefreshReaderUnit);
            this.gpReader.Controls.Add(this.cbReaderUnit);
            this.gpReader.Controls.Add(this.cbReaderProvider);
            this.gpReader.Controls.Add(this.lblReaderUnit);
            this.gpReader.Controls.Add(this.lblReaderProvider);
            this.gpReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpReader.Location = new System.Drawing.Point(0, 39);
            this.gpReader.Name = "gpReader";
            this.gpReader.Size = new System.Drawing.Size(598, 83);
            this.gpReader.TabIndex = 3;
            this.gpReader.TabStop = false;
            this.gpReader.Text = "Reader";
            // 
            // lblReaderProvider
            // 
            this.lblReaderProvider.AutoSize = true;
            this.lblReaderProvider.Location = new System.Drawing.Point(74, 22);
            this.lblReaderProvider.Name = "lblReaderProvider";
            this.lblReaderProvider.Size = new System.Drawing.Size(87, 13);
            this.lblReaderProvider.TabIndex = 0;
            this.lblReaderProvider.Text = "Reader Provider:";
            // 
            // lblReaderUnit
            // 
            this.lblReaderUnit.AutoSize = true;
            this.lblReaderUnit.Location = new System.Drawing.Point(94, 55);
            this.lblReaderUnit.Name = "lblReaderUnit";
            this.lblReaderUnit.Size = new System.Drawing.Size(67, 13);
            this.lblReaderUnit.TabIndex = 1;
            this.lblReaderUnit.Text = "Reader Unit:";
            // 
            // cbReaderProvider
            // 
            this.cbReaderProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaderProvider.FormattingEnabled = true;
            this.cbReaderProvider.Location = new System.Drawing.Point(167, 19);
            this.cbReaderProvider.Name = "cbReaderProvider";
            this.cbReaderProvider.Size = new System.Drawing.Size(320, 21);
            this.cbReaderProvider.TabIndex = 2;
            this.cbReaderProvider.SelectedIndexChanged += new System.EventHandler(this.cbReaderProvider_SelectedIndexChanged);
            // 
            // cbReaderUnit
            // 
            this.cbReaderUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReaderUnit.FormattingEnabled = true;
            this.cbReaderUnit.Location = new System.Drawing.Point(167, 52);
            this.cbReaderUnit.Name = "cbReaderUnit";
            this.cbReaderUnit.Size = new System.Drawing.Size(320, 21);
            this.cbReaderUnit.TabIndex = 3;
            // 
            // linkRefreshReaderUnit
            // 
            this.linkRefreshReaderUnit.AutoSize = true;
            this.linkRefreshReaderUnit.Location = new System.Drawing.Point(493, 55);
            this.linkRefreshReaderUnit.Name = "linkRefreshReaderUnit";
            this.linkRefreshReaderUnit.Size = new System.Drawing.Size(44, 13);
            this.linkRefreshReaderUnit.TabIndex = 4;
            this.linkRefreshReaderUnit.TabStop = true;
            this.linkRefreshReaderUnit.Text = "Refresh";
            this.linkRefreshReaderUnit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRefreshReaderUnit_LinkClicked);
            // 
            // RWCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 259);
            this.Controls.Add(this.gpCardServices);
            this.Controls.Add(this.gpReader);
            this.Controls.Add(this.label2);
            this.Name = "RWCard";
            this.Text = "RWCard DESFire";
            this.gpCardServices.ResumeLayout(false);
            this.gpReader.ResumeLayout(false);
            this.gpReader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpCardServices;
        private System.Windows.Forms.Button btnCardStorageService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDESFireCommands;
        private System.Windows.Forms.GroupBox gpReader;
        private System.Windows.Forms.Label lblReaderUnit;
        private System.Windows.Forms.Label lblReaderProvider;
        private System.Windows.Forms.ComboBox cbReaderProvider;
        private System.Windows.Forms.ComboBox cbReaderUnit;
        private System.Windows.Forms.LinkLabel linkRefreshReaderUnit;
    }
}

