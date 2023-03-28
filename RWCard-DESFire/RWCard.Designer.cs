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
            this.btnAuthWithSAM = new System.Windows.Forms.Button();
            this.btnDESFireCommands = new System.Windows.Forms.Button();
            this.btnCardStorageService = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpReader = new System.Windows.Forms.GroupBox();
            this.readerSelectionControl = new RWCard_DESFire.ReaderSelectionControl();
            this.gpCardServices.SuspendLayout();
            this.gpReader.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCardServices
            // 
            this.gpCardServices.Controls.Add(this.btnAuthWithSAM);
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
            // btnAuthWithSAM
            // 
            this.btnAuthWithSAM.Location = new System.Drawing.Point(384, 34);
            this.btnAuthWithSAM.Name = "btnAuthWithSAM";
            this.btnAuthWithSAM.Size = new System.Drawing.Size(155, 71);
            this.btnAuthWithSAM.TabIndex = 4;
            this.btnAuthWithSAM.Text = "Authenticate on DESFire using a SAM";
            this.btnAuthWithSAM.UseVisualStyleBackColor = true;
            this.btnAuthWithSAM.Click += new System.EventHandler(this.btnAuthWithSAM_Click);
            // 
            // btnDESFireCommands
            // 
            this.btnDESFireCommands.Location = new System.Drawing.Point(223, 34);
            this.btnDESFireCommands.Name = "btnDESFireCommands";
            this.btnDESFireCommands.Size = new System.Drawing.Size(155, 71);
            this.btnDESFireCommands.TabIndex = 3;
            this.btnDESFireCommands.Text = "DESFire Commands";
            this.btnDESFireCommands.UseVisualStyleBackColor = true;
            this.btnDESFireCommands.Click += new System.EventHandler(this.btnDESFireCommands_Click);
            // 
            // btnCardStorageService
            // 
            this.btnCardStorageService.Location = new System.Drawing.Point(62, 34);
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
            this.gpReader.Controls.Add(this.readerSelectionControl);
            this.gpReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpReader.Location = new System.Drawing.Point(0, 39);
            this.gpReader.Name = "gpReader";
            this.gpReader.Size = new System.Drawing.Size(598, 83);
            this.gpReader.TabIndex = 3;
            this.gpReader.TabStop = false;
            this.gpReader.Text = "Reader";
            // 
            // readerSelectionControl
            // 
            this.readerSelectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readerSelectionControl.Location = new System.Drawing.Point(3, 16);
            this.readerSelectionControl.Name = "readerSelectionControl";
            this.readerSelectionControl.Size = new System.Drawing.Size(592, 64);
            this.readerSelectionControl.TabIndex = 0;
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gpCardServices;
        private System.Windows.Forms.Button btnCardStorageService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDESFireCommands;
        private System.Windows.Forms.GroupBox gpReader;
        private System.Windows.Forms.Button btnAuthWithSAM;
        private ReaderSelectionControl readerSelectionControl;
    }
}

