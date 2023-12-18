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
            gpCommandsCard = new System.Windows.Forms.GroupBox();
            btnGetCardType = new System.Windows.Forms.Button();
            btnGetCSN = new System.Windows.Forms.Button();
            btnDisconnect = new System.Windows.Forms.Button();
            btnConnect = new System.Windows.Forms.Button();
            btnSelectApplication = new System.Windows.Forms.Button();
            gpCommandsCardStructure = new System.Windows.Forms.GroupBox();
            btnErase = new System.Windows.Forms.Button();
            btnDeleteFile = new System.Windows.Forms.Button();
            btnCreateStdDataFile = new System.Windows.Forms.Button();
            btnDeleteApplication = new System.Windows.Forms.Button();
            btnCreateApplication = new System.Windows.Forms.Button();
            btnChangeKey = new System.Windows.Forms.Button();
            btnAuthenticate = new System.Windows.Forms.Button();
            btnWaitInsertion = new System.Windows.Forms.Button();
            btnWaitRemoval = new System.Windows.Forms.Button();
            panelCommands = new System.Windows.Forms.Panel();
            panelRightCommands = new System.Windows.Forms.GroupBox();
            gpCommandsCardData = new System.Windows.Forms.GroupBox();
            btnWriteData = new System.Windows.Forms.Button();
            btnReadData = new System.Windows.Forms.Button();
            gpCommandsKey = new System.Windows.Forms.GroupBox();
            gpCommandsReader = new System.Windows.Forms.GroupBox();
            btnConnectToReader = new System.Windows.Forms.Button();
            btnDisconnectFromReader = new System.Windows.Forms.Button();
            gpParameters = new System.Windows.Forms.GroupBox();
            dfparams = new DESFireParametersControl();
            gpKey = new System.Windows.Forms.GroupBox();
            keyparams = new KeyParametersControl();
            gpCommandsCard.SuspendLayout();
            gpCommandsCardStructure.SuspendLayout();
            panelCommands.SuspendLayout();
            panelRightCommands.SuspendLayout();
            gpCommandsCardData.SuspendLayout();
            gpCommandsKey.SuspendLayout();
            gpCommandsReader.SuspendLayout();
            gpParameters.SuspendLayout();
            gpKey.SuspendLayout();
            SuspendLayout();
            // 
            // gpCommandsCard
            // 
            gpCommandsCard.Controls.Add(btnGetCardType);
            gpCommandsCard.Controls.Add(btnGetCSN);
            gpCommandsCard.Controls.Add(btnDisconnect);
            gpCommandsCard.Controls.Add(btnConnect);
            gpCommandsCard.Dock = System.Windows.Forms.DockStyle.Left;
            gpCommandsCard.Location = new System.Drawing.Point(310, 0);
            gpCommandsCard.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsCard.Name = "gpCommandsCard";
            gpCommandsCard.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsCard.Size = new System.Drawing.Size(310, 614);
            gpCommandsCard.TabIndex = 0;
            gpCommandsCard.TabStop = false;
            gpCommandsCard.Text = "Card";
            // 
            // btnGetCardType
            // 
            btnGetCardType.Location = new System.Drawing.Point(10, 229);
            btnGetCardType.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnGetCardType.Name = "btnGetCardType";
            btnGetCardType.Size = new System.Drawing.Size(285, 85);
            btnGetCardType.TabIndex = 4;
            btnGetCardType.Text = "Get Card Type";
            btnGetCardType.UseVisualStyleBackColor = true;
            btnGetCardType.Click += btnGetCardType_Click;
            // 
            // btnGetCSN
            // 
            btnGetCSN.Location = new System.Drawing.Point(10, 325);
            btnGetCSN.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnGetCSN.Name = "btnGetCSN";
            btnGetCSN.Size = new System.Drawing.Size(285, 85);
            btnGetCSN.TabIndex = 3;
            btnGetCSN.Text = "Get CSN";
            btnGetCSN.UseVisualStyleBackColor = true;
            btnGetCSN.Click += btnGetCSN_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new System.Drawing.Point(10, 133);
            btnDisconnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new System.Drawing.Size(285, 85);
            btnDisconnect.TabIndex = 2;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // btnConnect
            // 
            btnConnect.Location = new System.Drawing.Point(10, 37);
            btnConnect.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new System.Drawing.Size(285, 85);
            btnConnect.TabIndex = 1;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnSelectApplication
            // 
            btnSelectApplication.Location = new System.Drawing.Point(10, 37);
            btnSelectApplication.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnSelectApplication.Name = "btnSelectApplication";
            btnSelectApplication.Size = new System.Drawing.Size(285, 85);
            btnSelectApplication.TabIndex = 1;
            btnSelectApplication.Text = "Select Application";
            btnSelectApplication.UseVisualStyleBackColor = true;
            btnSelectApplication.Click += btnSelectApplication_Click;
            // 
            // gpCommandsCardStructure
            // 
            gpCommandsCardStructure.Controls.Add(btnErase);
            gpCommandsCardStructure.Controls.Add(btnDeleteFile);
            gpCommandsCardStructure.Controls.Add(btnCreateStdDataFile);
            gpCommandsCardStructure.Controls.Add(btnDeleteApplication);
            gpCommandsCardStructure.Controls.Add(btnCreateApplication);
            gpCommandsCardStructure.Controls.Add(btnSelectApplication);
            gpCommandsCardStructure.Dock = System.Windows.Forms.DockStyle.Left;
            gpCommandsCardStructure.Location = new System.Drawing.Point(620, 0);
            gpCommandsCardStructure.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsCardStructure.Name = "gpCommandsCardStructure";
            gpCommandsCardStructure.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsCardStructure.Size = new System.Drawing.Size(310, 614);
            gpCommandsCardStructure.TabIndex = 1;
            gpCommandsCardStructure.TabStop = false;
            gpCommandsCardStructure.Text = "Card Structure";
            // 
            // btnErase
            // 
            btnErase.Location = new System.Drawing.Point(10, 519);
            btnErase.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnErase.Name = "btnErase";
            btnErase.Size = new System.Drawing.Size(285, 85);
            btnErase.TabIndex = 8;
            btnErase.Text = "Erase";
            btnErase.UseVisualStyleBackColor = true;
            btnErase.Click += btnErase_Click;
            // 
            // btnDeleteFile
            // 
            btnDeleteFile.Location = new System.Drawing.Point(10, 422);
            btnDeleteFile.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDeleteFile.Name = "btnDeleteFile";
            btnDeleteFile.Size = new System.Drawing.Size(285, 85);
            btnDeleteFile.TabIndex = 6;
            btnDeleteFile.Text = "Delete File";
            btnDeleteFile.UseVisualStyleBackColor = true;
            btnDeleteFile.Click += btnDeleteFile_Click;
            // 
            // btnCreateStdDataFile
            // 
            btnCreateStdDataFile.Location = new System.Drawing.Point(10, 326);
            btnCreateStdDataFile.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCreateStdDataFile.Name = "btnCreateStdDataFile";
            btnCreateStdDataFile.Size = new System.Drawing.Size(285, 85);
            btnCreateStdDataFile.TabIndex = 5;
            btnCreateStdDataFile.Text = "Create Std Data File";
            btnCreateStdDataFile.UseVisualStyleBackColor = true;
            btnCreateStdDataFile.Click += btnCreateStdDataFile_Click;
            // 
            // btnDeleteApplication
            // 
            btnDeleteApplication.Location = new System.Drawing.Point(10, 230);
            btnDeleteApplication.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDeleteApplication.Name = "btnDeleteApplication";
            btnDeleteApplication.Size = new System.Drawing.Size(285, 85);
            btnDeleteApplication.TabIndex = 4;
            btnDeleteApplication.Text = "Delete Application";
            btnDeleteApplication.UseVisualStyleBackColor = true;
            btnDeleteApplication.Click += btnDeleteApplication_Click;
            // 
            // btnCreateApplication
            // 
            btnCreateApplication.Location = new System.Drawing.Point(10, 134);
            btnCreateApplication.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnCreateApplication.Name = "btnCreateApplication";
            btnCreateApplication.Size = new System.Drawing.Size(285, 85);
            btnCreateApplication.TabIndex = 3;
            btnCreateApplication.Text = "Create Application";
            btnCreateApplication.UseVisualStyleBackColor = true;
            btnCreateApplication.Click += btnCreateApplication_Click;
            // 
            // btnChangeKey
            // 
            btnChangeKey.Location = new System.Drawing.Point(5, 133);
            btnChangeKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnChangeKey.Name = "btnChangeKey";
            btnChangeKey.Size = new System.Drawing.Size(285, 85);
            btnChangeKey.TabIndex = 7;
            btnChangeKey.Text = "Change Key";
            btnChangeKey.UseVisualStyleBackColor = true;
            btnChangeKey.Click += btnChangeKey_Click;
            // 
            // btnAuthenticate
            // 
            btnAuthenticate.Location = new System.Drawing.Point(5, 36);
            btnAuthenticate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnAuthenticate.Name = "btnAuthenticate";
            btnAuthenticate.Size = new System.Drawing.Size(285, 85);
            btnAuthenticate.TabIndex = 2;
            btnAuthenticate.Text = "Authenticate";
            btnAuthenticate.UseVisualStyleBackColor = true;
            btnAuthenticate.Click += btnAuthenticate_Click;
            // 
            // btnWaitInsertion
            // 
            btnWaitInsertion.Location = new System.Drawing.Point(10, 229);
            btnWaitInsertion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnWaitInsertion.Name = "btnWaitInsertion";
            btnWaitInsertion.Size = new System.Drawing.Size(285, 85);
            btnWaitInsertion.TabIndex = 3;
            btnWaitInsertion.Text = "Wait Insertion";
            btnWaitInsertion.UseVisualStyleBackColor = true;
            btnWaitInsertion.Click += btnWaitInsertion_Click;
            // 
            // btnWaitRemoval
            // 
            btnWaitRemoval.Location = new System.Drawing.Point(10, 325);
            btnWaitRemoval.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnWaitRemoval.Name = "btnWaitRemoval";
            btnWaitRemoval.Size = new System.Drawing.Size(285, 85);
            btnWaitRemoval.TabIndex = 4;
            btnWaitRemoval.Text = "Wait Removal";
            btnWaitRemoval.UseVisualStyleBackColor = true;
            btnWaitRemoval.Click += btnWaitRemoval_Click;
            // 
            // panelCommands
            // 
            panelCommands.Controls.Add(panelRightCommands);
            panelCommands.Controls.Add(gpCommandsCardStructure);
            panelCommands.Controls.Add(gpCommandsCard);
            panelCommands.Controls.Add(gpCommandsReader);
            panelCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCommands.Location = new System.Drawing.Point(0, 306);
            panelCommands.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelCommands.Name = "panelCommands";
            panelCommands.Size = new System.Drawing.Size(1258, 614);
            panelCommands.TabIndex = 2;
            // 
            // panelRightCommands
            // 
            panelRightCommands.Controls.Add(gpCommandsCardData);
            panelRightCommands.Controls.Add(gpCommandsKey);
            panelRightCommands.Dock = System.Windows.Forms.DockStyle.Left;
            panelRightCommands.Location = new System.Drawing.Point(930, 0);
            panelRightCommands.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelRightCommands.Name = "panelRightCommands";
            panelRightCommands.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            panelRightCommands.Size = new System.Drawing.Size(310, 614);
            panelRightCommands.TabIndex = 2;
            panelRightCommands.TabStop = false;
            // 
            // gpCommandsCardData
            // 
            gpCommandsCardData.Controls.Add(btnWriteData);
            gpCommandsCardData.Controls.Add(btnReadData);
            gpCommandsCardData.Dock = System.Windows.Forms.DockStyle.Top;
            gpCommandsCardData.Location = new System.Drawing.Point(5, 262);
            gpCommandsCardData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsCardData.Name = "gpCommandsCardData";
            gpCommandsCardData.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsCardData.Size = new System.Drawing.Size(300, 232);
            gpCommandsCardData.TabIndex = 3;
            gpCommandsCardData.TabStop = false;
            gpCommandsCardData.Text = "Card Data";
            // 
            // btnWriteData
            // 
            btnWriteData.Location = new System.Drawing.Point(10, 37);
            btnWriteData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnWriteData.Name = "btnWriteData";
            btnWriteData.Size = new System.Drawing.Size(285, 85);
            btnWriteData.TabIndex = 3;
            btnWriteData.Text = "Write Data";
            btnWriteData.UseVisualStyleBackColor = true;
            // 
            // btnReadData
            // 
            btnReadData.Location = new System.Drawing.Point(10, 133);
            btnReadData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnReadData.Name = "btnReadData";
            btnReadData.Size = new System.Drawing.Size(285, 85);
            btnReadData.TabIndex = 1;
            btnReadData.Text = "Read Data";
            btnReadData.UseVisualStyleBackColor = true;
            // 
            // gpCommandsKey
            // 
            gpCommandsKey.Controls.Add(btnAuthenticate);
            gpCommandsKey.Controls.Add(btnChangeKey);
            gpCommandsKey.Dock = System.Windows.Forms.DockStyle.Top;
            gpCommandsKey.Location = new System.Drawing.Point(5, 30);
            gpCommandsKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsKey.Name = "gpCommandsKey";
            gpCommandsKey.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsKey.Size = new System.Drawing.Size(300, 232);
            gpCommandsKey.TabIndex = 4;
            gpCommandsKey.TabStop = false;
            gpCommandsKey.Text = "Key";
            // 
            // gpCommandsReader
            // 
            gpCommandsReader.Controls.Add(btnWaitRemoval);
            gpCommandsReader.Controls.Add(btnConnectToReader);
            gpCommandsReader.Controls.Add(btnWaitInsertion);
            gpCommandsReader.Controls.Add(btnDisconnectFromReader);
            gpCommandsReader.Dock = System.Windows.Forms.DockStyle.Left;
            gpCommandsReader.Location = new System.Drawing.Point(0, 0);
            gpCommandsReader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsReader.Name = "gpCommandsReader";
            gpCommandsReader.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpCommandsReader.Size = new System.Drawing.Size(310, 614);
            gpCommandsReader.TabIndex = 3;
            gpCommandsReader.TabStop = false;
            gpCommandsReader.Text = "Reader";
            // 
            // btnConnectToReader
            // 
            btnConnectToReader.Location = new System.Drawing.Point(10, 37);
            btnConnectToReader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnConnectToReader.Name = "btnConnectToReader";
            btnConnectToReader.Size = new System.Drawing.Size(285, 85);
            btnConnectToReader.TabIndex = 3;
            btnConnectToReader.Text = "Connect";
            btnConnectToReader.UseVisualStyleBackColor = true;
            btnConnectToReader.Click += btnConnectToReader_Click;
            // 
            // btnDisconnectFromReader
            // 
            btnDisconnectFromReader.Location = new System.Drawing.Point(10, 133);
            btnDisconnectFromReader.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            btnDisconnectFromReader.Name = "btnDisconnectFromReader";
            btnDisconnectFromReader.Size = new System.Drawing.Size(285, 85);
            btnDisconnectFromReader.TabIndex = 1;
            btnDisconnectFromReader.Text = "Disconnect";
            btnDisconnectFromReader.UseVisualStyleBackColor = true;
            btnDisconnectFromReader.Click += btnDisconnectFromReader_Click;
            // 
            // gpParameters
            // 
            gpParameters.Controls.Add(dfparams);
            gpParameters.Dock = System.Windows.Forms.DockStyle.Top;
            gpParameters.Location = new System.Drawing.Point(0, 0);
            gpParameters.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpParameters.Name = "gpParameters";
            gpParameters.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpParameters.Size = new System.Drawing.Size(1258, 139);
            gpParameters.TabIndex = 3;
            gpParameters.TabStop = false;
            gpParameters.Text = "Parameters";
            // 
            // dfparams
            // 
            dfparams.Dock = System.Windows.Forms.DockStyle.Fill;
            dfparams.Location = new System.Drawing.Point(5, 30);
            dfparams.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            dfparams.Name = "dfparams";
            dfparams.Size = new System.Drawing.Size(1248, 103);
            dfparams.TabIndex = 0;
            // 
            // gpKey
            // 
            gpKey.Controls.Add(keyparams);
            gpKey.Dock = System.Windows.Forms.DockStyle.Top;
            gpKey.Location = new System.Drawing.Point(0, 139);
            gpKey.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpKey.Name = "gpKey";
            gpKey.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            gpKey.Size = new System.Drawing.Size(1258, 167);
            gpKey.TabIndex = 4;
            gpKey.TabStop = false;
            gpKey.Text = "Key";
            // 
            // keyparams
            // 
            keyparams.Dock = System.Windows.Forms.DockStyle.Fill;
            keyparams.Location = new System.Drawing.Point(5, 30);
            keyparams.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            keyparams.Name = "keyparams";
            keyparams.Size = new System.Drawing.Size(1248, 131);
            keyparams.TabIndex = 0;
            // 
            // DESFireCommandsSample
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1258, 920);
            Controls.Add(panelCommands);
            Controls.Add(gpKey);
            Controls.Add(gpParameters);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "DESFireCommandsSample";
            Text = "DESFire Commands";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            gpCommandsCard.ResumeLayout(false);
            gpCommandsCardStructure.ResumeLayout(false);
            panelCommands.ResumeLayout(false);
            panelRightCommands.ResumeLayout(false);
            gpCommandsCardData.ResumeLayout(false);
            gpCommandsKey.ResumeLayout(false);
            gpCommandsReader.ResumeLayout(false);
            gpParameters.ResumeLayout(false);
            gpKey.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox panelRightCommands;
        private System.Windows.Forms.GroupBox gpCommandsReader;
        private System.Windows.Forms.Button btnConnectToReader;
        private System.Windows.Forms.Button btnDisconnectFromReader;
        private System.Windows.Forms.Button btnGetCSN;
        private System.Windows.Forms.Button btnGetCardType;
        private DESFireParametersControl dfparams;
        private System.Windows.Forms.GroupBox gpKey;
        private KeyParametersControl keyparams;
        private System.Windows.Forms.GroupBox gpCommandsCardData;
        private System.Windows.Forms.Button btnWriteData;
        private System.Windows.Forms.Button btnReadData;
        private System.Windows.Forms.GroupBox gpCommandsKey;
    }
}