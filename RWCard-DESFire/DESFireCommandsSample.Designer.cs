namespace RWCard_DESFire
{
    partial class DESFireCommandsSample
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
            this.gpCommandsCard = new System.Windows.Forms.GroupBox();
            this.btnGetCardType = new System.Windows.Forms.Button();
            this.btnGetCSN = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnSelectApplication = new System.Windows.Forms.Button();
            this.gpCommandsCardStructure = new System.Windows.Forms.GroupBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnChangeKey = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnCreateStdDataFile = new System.Windows.Forms.Button();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.btnCreateApplication = new System.Windows.Forms.Button();
            this.btnAuthenticate = new System.Windows.Forms.Button();
            this.btnWaitInsertion = new System.Windows.Forms.Button();
            this.btnWaitRemoval = new System.Windows.Forms.Button();
            this.panelCommands = new System.Windows.Forms.Panel();
            this.gpCommandsCardData = new System.Windows.Forms.GroupBox();
            this.btnWriteData = new System.Windows.Forms.Button();
            this.btnReadData = new System.Windows.Forms.Button();
            this.gpCommandsReader = new System.Windows.Forms.GroupBox();
            this.btnConnectToReader = new System.Windows.Forms.Button();
            this.btnDisconnectFromReader = new System.Windows.Forms.Button();
            this.gpParameters = new System.Windows.Forms.GroupBox();
            this.dfparams = new RWCard_DESFire.DESFireParametersControl();
            this.gpCommandsCard.SuspendLayout();
            this.gpCommandsCardStructure.SuspendLayout();
            this.panelCommands.SuspendLayout();
            this.gpCommandsCardData.SuspendLayout();
            this.gpCommandsReader.SuspendLayout();
            this.gpParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCommandsCard
            // 
            this.gpCommandsCard.Controls.Add(this.btnGetCardType);
            this.gpCommandsCard.Controls.Add(this.btnGetCSN);
            this.gpCommandsCard.Controls.Add(this.btnDisconnect);
            this.gpCommandsCard.Controls.Add(this.btnConnect);
            this.gpCommandsCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpCommandsCard.Location = new System.Drawing.Point(186, 0);
            this.gpCommandsCard.Name = "gpCommandsCard";
            this.gpCommandsCard.Size = new System.Drawing.Size(186, 426);
            this.gpCommandsCard.TabIndex = 0;
            this.gpCommandsCard.TabStop = false;
            this.gpCommandsCard.Text = "Card";
            // 
            // btnGetCardType
            // 
            this.btnGetCardType.Location = new System.Drawing.Point(6, 119);
            this.btnGetCardType.Name = "btnGetCardType";
            this.btnGetCardType.Size = new System.Drawing.Size(171, 44);
            this.btnGetCardType.TabIndex = 4;
            this.btnGetCardType.Text = "Get Card Type";
            this.btnGetCardType.UseVisualStyleBackColor = true;
            this.btnGetCardType.Click += new System.EventHandler(this.btnGetCardType_Click);
            // 
            // btnGetCSN
            // 
            this.btnGetCSN.Location = new System.Drawing.Point(6, 169);
            this.btnGetCSN.Name = "btnGetCSN";
            this.btnGetCSN.Size = new System.Drawing.Size(171, 44);
            this.btnGetCSN.TabIndex = 3;
            this.btnGetCSN.Text = "Get CSN";
            this.btnGetCSN.UseVisualStyleBackColor = true;
            this.btnGetCSN.Click += new System.EventHandler(this.btnGetCSN_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(6, 69);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(171, 44);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(171, 44);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnSelectApplication
            // 
            this.btnSelectApplication.Location = new System.Drawing.Point(6, 19);
            this.btnSelectApplication.Name = "btnSelectApplication";
            this.btnSelectApplication.Size = new System.Drawing.Size(171, 44);
            this.btnSelectApplication.TabIndex = 1;
            this.btnSelectApplication.Text = "Select Application";
            this.btnSelectApplication.UseVisualStyleBackColor = true;
            this.btnSelectApplication.Click += new System.EventHandler(this.btnSelectApplication_Click);
            // 
            // gpCommandsCardStructure
            // 
            this.gpCommandsCardStructure.Controls.Add(this.btnErase);
            this.gpCommandsCardStructure.Controls.Add(this.btnChangeKey);
            this.gpCommandsCardStructure.Controls.Add(this.btnDeleteFile);
            this.gpCommandsCardStructure.Controls.Add(this.btnCreateStdDataFile);
            this.gpCommandsCardStructure.Controls.Add(this.btnDeleteApplication);
            this.gpCommandsCardStructure.Controls.Add(this.btnCreateApplication);
            this.gpCommandsCardStructure.Controls.Add(this.btnAuthenticate);
            this.gpCommandsCardStructure.Controls.Add(this.btnSelectApplication);
            this.gpCommandsCardStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpCommandsCardStructure.Location = new System.Drawing.Point(372, 0);
            this.gpCommandsCardStructure.Name = "gpCommandsCardStructure";
            this.gpCommandsCardStructure.Size = new System.Drawing.Size(186, 426);
            this.gpCommandsCardStructure.TabIndex = 1;
            this.gpCommandsCardStructure.TabStop = false;
            this.gpCommandsCardStructure.Text = "Card Structure";
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(6, 369);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(171, 44);
            this.btnErase.TabIndex = 8;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnChangeKey
            // 
            this.btnChangeKey.Location = new System.Drawing.Point(6, 319);
            this.btnChangeKey.Name = "btnChangeKey";
            this.btnChangeKey.Size = new System.Drawing.Size(171, 44);
            this.btnChangeKey.TabIndex = 7;
            this.btnChangeKey.Text = "Change Key";
            this.btnChangeKey.UseVisualStyleBackColor = true;
            this.btnChangeKey.Click += new System.EventHandler(this.btnChangeKey_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(6, 269);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(171, 44);
            this.btnDeleteFile.TabIndex = 6;
            this.btnDeleteFile.Text = "Delete File";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnCreateStdDataFile
            // 
            this.btnCreateStdDataFile.Location = new System.Drawing.Point(6, 219);
            this.btnCreateStdDataFile.Name = "btnCreateStdDataFile";
            this.btnCreateStdDataFile.Size = new System.Drawing.Size(171, 44);
            this.btnCreateStdDataFile.TabIndex = 5;
            this.btnCreateStdDataFile.Text = "Create Std Data File";
            this.btnCreateStdDataFile.UseVisualStyleBackColor = true;
            this.btnCreateStdDataFile.Click += new System.EventHandler(this.btnCreateStdDataFile_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(6, 169);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(171, 44);
            this.btnDeleteApplication.TabIndex = 4;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // btnCreateApplication
            // 
            this.btnCreateApplication.Location = new System.Drawing.Point(6, 119);
            this.btnCreateApplication.Name = "btnCreateApplication";
            this.btnCreateApplication.Size = new System.Drawing.Size(171, 44);
            this.btnCreateApplication.TabIndex = 3;
            this.btnCreateApplication.Text = "Create Application";
            this.btnCreateApplication.UseVisualStyleBackColor = true;
            this.btnCreateApplication.Click += new System.EventHandler(this.btnCreateApplication_Click);
            // 
            // btnAuthenticate
            // 
            this.btnAuthenticate.Location = new System.Drawing.Point(6, 69);
            this.btnAuthenticate.Name = "btnAuthenticate";
            this.btnAuthenticate.Size = new System.Drawing.Size(171, 44);
            this.btnAuthenticate.TabIndex = 2;
            this.btnAuthenticate.Text = "Authenticate";
            this.btnAuthenticate.UseVisualStyleBackColor = true;
            this.btnAuthenticate.Click += new System.EventHandler(this.btnAuthenticate_Click);
            // 
            // btnWaitInsertion
            // 
            this.btnWaitInsertion.Location = new System.Drawing.Point(6, 119);
            this.btnWaitInsertion.Name = "btnWaitInsertion";
            this.btnWaitInsertion.Size = new System.Drawing.Size(171, 44);
            this.btnWaitInsertion.TabIndex = 3;
            this.btnWaitInsertion.Text = "Wait Insertion";
            this.btnWaitInsertion.UseVisualStyleBackColor = true;
            this.btnWaitInsertion.Click += new System.EventHandler(this.btnWaitInsertion_Click);
            // 
            // btnWaitRemoval
            // 
            this.btnWaitRemoval.Location = new System.Drawing.Point(6, 169);
            this.btnWaitRemoval.Name = "btnWaitRemoval";
            this.btnWaitRemoval.Size = new System.Drawing.Size(171, 44);
            this.btnWaitRemoval.TabIndex = 4;
            this.btnWaitRemoval.Text = "Wait Removal";
            this.btnWaitRemoval.UseVisualStyleBackColor = true;
            this.btnWaitRemoval.Click += new System.EventHandler(this.btnWaitRemoval_Click);
            // 
            // panelCommands
            // 
            this.panelCommands.Controls.Add(this.gpCommandsCardData);
            this.panelCommands.Controls.Add(this.gpCommandsCardStructure);
            this.panelCommands.Controls.Add(this.gpCommandsCard);
            this.panelCommands.Controls.Add(this.gpCommandsReader);
            this.panelCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCommands.Location = new System.Drawing.Point(0, 110);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(785, 426);
            this.panelCommands.TabIndex = 2;
            // 
            // gpCommandsCardData
            // 
            this.gpCommandsCardData.Controls.Add(this.btnWriteData);
            this.gpCommandsCardData.Controls.Add(this.btnReadData);
            this.gpCommandsCardData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpCommandsCardData.Location = new System.Drawing.Point(558, 0);
            this.gpCommandsCardData.Name = "gpCommandsCardData";
            this.gpCommandsCardData.Size = new System.Drawing.Size(186, 426);
            this.gpCommandsCardData.TabIndex = 2;
            this.gpCommandsCardData.TabStop = false;
            this.gpCommandsCardData.Text = "Card Data";
            // 
            // btnWriteData
            // 
            this.btnWriteData.Location = new System.Drawing.Point(6, 19);
            this.btnWriteData.Name = "btnWriteData";
            this.btnWriteData.Size = new System.Drawing.Size(171, 44);
            this.btnWriteData.TabIndex = 3;
            this.btnWriteData.Text = "Write Data";
            this.btnWriteData.UseVisualStyleBackColor = true;
            this.btnWriteData.Click += new System.EventHandler(this.btnWriteData_Click);
            // 
            // btnReadData
            // 
            this.btnReadData.Location = new System.Drawing.Point(6, 69);
            this.btnReadData.Name = "btnReadData";
            this.btnReadData.Size = new System.Drawing.Size(171, 44);
            this.btnReadData.TabIndex = 1;
            this.btnReadData.Text = "Read Data";
            this.btnReadData.UseVisualStyleBackColor = true;
            this.btnReadData.Click += new System.EventHandler(this.btnReadData_Click);
            // 
            // gpCommandsReader
            // 
            this.gpCommandsReader.Controls.Add(this.btnWaitRemoval);
            this.gpCommandsReader.Controls.Add(this.btnConnectToReader);
            this.gpCommandsReader.Controls.Add(this.btnWaitInsertion);
            this.gpCommandsReader.Controls.Add(this.btnDisconnectFromReader);
            this.gpCommandsReader.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpCommandsReader.Location = new System.Drawing.Point(0, 0);
            this.gpCommandsReader.Name = "gpCommandsReader";
            this.gpCommandsReader.Size = new System.Drawing.Size(186, 426);
            this.gpCommandsReader.TabIndex = 3;
            this.gpCommandsReader.TabStop = false;
            this.gpCommandsReader.Text = "Reader";
            // 
            // btnConnectToReader
            // 
            this.btnConnectToReader.Location = new System.Drawing.Point(6, 19);
            this.btnConnectToReader.Name = "btnConnectToReader";
            this.btnConnectToReader.Size = new System.Drawing.Size(171, 44);
            this.btnConnectToReader.TabIndex = 3;
            this.btnConnectToReader.Text = "Connect";
            this.btnConnectToReader.UseVisualStyleBackColor = true;
            this.btnConnectToReader.Click += new System.EventHandler(this.btnConnectToReader_Click);
            // 
            // btnDisconnectFromReader
            // 
            this.btnDisconnectFromReader.Location = new System.Drawing.Point(6, 69);
            this.btnDisconnectFromReader.Name = "btnDisconnectFromReader";
            this.btnDisconnectFromReader.Size = new System.Drawing.Size(171, 44);
            this.btnDisconnectFromReader.TabIndex = 1;
            this.btnDisconnectFromReader.Text = "Disconnect";
            this.btnDisconnectFromReader.UseVisualStyleBackColor = true;
            this.btnDisconnectFromReader.Click += new System.EventHandler(this.btnDisconnectFromReader_Click);
            // 
            // gpParameters
            // 
            this.gpParameters.Controls.Add(this.dfparams);
            this.gpParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpParameters.Location = new System.Drawing.Point(0, 0);
            this.gpParameters.Name = "gpParameters";
            this.gpParameters.Size = new System.Drawing.Size(785, 110);
            this.gpParameters.TabIndex = 3;
            this.gpParameters.TabStop = false;
            this.gpParameters.Text = "Parameters";
            // 
            // dfparams
            // 
            this.dfparams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfparams.Location = new System.Drawing.Point(3, 16);
            this.dfparams.Name = "dfparams";
            this.dfparams.Size = new System.Drawing.Size(779, 91);
            this.dfparams.TabIndex = 0;
            // 
            // DESFireCommandsSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 536);
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.gpParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DESFireCommandsSample";
            this.Text = "DESFire Commands";
            this.gpCommandsCard.ResumeLayout(false);
            this.gpCommandsCardStructure.ResumeLayout(false);
            this.panelCommands.ResumeLayout(false);
            this.gpCommandsCardData.ResumeLayout(false);
            this.gpCommandsReader.ResumeLayout(false);
            this.gpParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCommandsCard;
        private System.Windows.Forms.Button btnSelectApplication;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gpCommandsCardStructure;
        private System.Windows.Forms.Button btnWaitRemoval;
        private System.Windows.Forms.Button btnWaitInsertion;
        private System.Windows.Forms.Panel panelCommands;
        private System.Windows.Forms.GroupBox gpParameters;
        private System.Windows.Forms.Button btnAuthenticate;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnCreateStdDataFile;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.Button btnCreateApplication;
        private System.Windows.Forms.Button btnChangeKey;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.GroupBox gpCommandsCardData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.GroupBox gpCommandsReader;
        private System.Windows.Forms.Button btnConnectToReader;
        private System.Windows.Forms.Button btnDisconnectFromReader;
        private System.Windows.Forms.Button btnGetCSN;
        private System.Windows.Forms.Button btnGetCardType;
        private DESFireParametersControl dfparams;
    }
}