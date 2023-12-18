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
            gpCardServices = new System.Windows.Forms.GroupBox();
            btnAuthWithSAM = new System.Windows.Forms.Button();
            btnDESFireCommands = new System.Windows.Forms.Button();
            btnCardStorageService = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            gpReader = new System.Windows.Forms.GroupBox();
            readerSelectionControl = new ReaderSelectionControl();
            gpAbout = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            gpCardServices.SuspendLayout();
            gpReader.SuspendLayout();
            gpAbout.SuspendLayout();
            SuspendLayout();
            // 
            // gpCardServices
            // 
            gpCardServices.Controls.Add(btnAuthWithSAM);
            gpCardServices.Controls.Add(btnDESFireCommands);
            gpCardServices.Controls.Add(btnCardStorageService);
            gpCardServices.Dock = System.Windows.Forms.DockStyle.Fill;
            gpCardServices.Location = new System.Drawing.Point(0, 235);
            gpCardServices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCardServices.Name = "gpCardServices";
            gpCardServices.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCardServices.Size = new System.Drawing.Size(997, 243);
            gpCardServices.TabIndex = 1;
            gpCardServices.TabStop = false;
            gpCardServices.Text = "Card Services";
            // 
            // btnAuthWithSAM
            // 
            btnAuthWithSAM.Location = new System.Drawing.Point(640, 65);
            btnAuthWithSAM.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAuthWithSAM.Name = "btnAuthWithSAM";
            btnAuthWithSAM.Size = new System.Drawing.Size(258, 137);
            btnAuthWithSAM.TabIndex = 4;
            btnAuthWithSAM.Text = "Authenticate on DESFire using a SAM";
            btnAuthWithSAM.UseVisualStyleBackColor = true;
            btnAuthWithSAM.Click += btnAuthWithSAM_Click;
            // 
            // btnDESFireCommands
            // 
            btnDESFireCommands.Location = new System.Drawing.Point(372, 65);
            btnDESFireCommands.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDESFireCommands.Name = "btnDESFireCommands";
            btnDESFireCommands.Size = new System.Drawing.Size(258, 137);
            btnDESFireCommands.TabIndex = 3;
            btnDESFireCommands.Text = "DESFire Commands";
            btnDESFireCommands.UseVisualStyleBackColor = true;
            btnDESFireCommands.Click += btnDESFireCommands_Click;
            // 
            // btnCardStorageService
            // 
            btnCardStorageService.Location = new System.Drawing.Point(103, 65);
            btnCardStorageService.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCardStorageService.Name = "btnCardStorageService";
            btnCardStorageService.Size = new System.Drawing.Size(258, 137);
            btnCardStorageService.TabIndex = 2;
            btnCardStorageService.Text = "Read and Write using Card Storage service";
            btnCardStorageService.UseVisualStyleBackColor = true;
            btnCardStorageService.Click += btnCardStorageService_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Margin = new System.Windows.Forms.Padding(5);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(980, 75);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // gpReader
            // 
            gpReader.Controls.Add(readerSelectionControl);
            gpReader.Dock = System.Windows.Forms.DockStyle.Top;
            gpReader.Location = new System.Drawing.Point(0, 75);
            gpReader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpReader.Name = "gpReader";
            gpReader.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpReader.Size = new System.Drawing.Size(997, 160);
            gpReader.TabIndex = 3;
            gpReader.TabStop = false;
            gpReader.Text = "Reader";
            // 
            // readerSelectionControl
            // 
            readerSelectionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            readerSelectionControl.Location = new System.Drawing.Point(5, 30);
            readerSelectionControl.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            readerSelectionControl.Name = "readerSelectionControl";
            readerSelectionControl.Size = new System.Drawing.Size(987, 124);
            readerSelectionControl.TabIndex = 0;
            // 
            // gpAbout
            // 
            gpAbout.Controls.Add(label1);
            gpAbout.Controls.Add(label3);
            gpAbout.Dock = System.Windows.Forms.DockStyle.Bottom;
            gpAbout.Location = new System.Drawing.Point(0, 478);
            gpAbout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpAbout.Name = "gpAbout";
            gpAbout.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpAbout.Size = new System.Drawing.Size(997, 95);
            gpAbout.TabIndex = 4;
            gpAbout.TabStop = false;
            gpAbout.Text = "About";
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(5, 30);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(698, 59);
            label1.TabIndex = 3;
            label1.Text = "Developed by LEOSAC for LibLogicalAccess community.\r\nMIT licensed.";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Right;
            label3.Location = new System.Drawing.Point(703, 30);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(289, 50);
            label3.TabIndex = 4;
            label3.Text = "https://github.com/liblogicalaccess\r\nhttps://leosac.com";
            // 
            // RWCard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(997, 573);
            Controls.Add(gpCardServices);
            Controls.Add(gpAbout);
            Controls.Add(gpReader);
            Controls.Add(label2);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "RWCard";
            Text = "RWCard DESFire";
            gpCardServices.ResumeLayout(false);
            gpReader.ResumeLayout(false);
            gpAbout.ResumeLayout(false);
            gpAbout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox gpCardServices;
        private System.Windows.Forms.Button btnCardStorageService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDESFireCommands;
        private System.Windows.Forms.GroupBox gpReader;
        private System.Windows.Forms.Button btnAuthWithSAM;
        private ReaderSelectionControl readerSelectionControl;
        private System.Windows.Forms.GroupBox gpAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

