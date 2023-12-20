namespace RWCard_DESFire
{
    partial class SAMCommandsSample
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
            this.gpParameters = new System.Windows.Forms.GroupBox();
            this.dfparams = new RWCard_DESFire.DESFireParametersControl();
            this.gpCommands = new System.Windows.Forms.GroupBox();
            this.btnUnInit = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.btnGetUID = new System.Windows.Forms.Button();
            this.gpParameters.SuspendLayout();
            this.gpCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpParameters
            // 
            this.gpParameters.Controls.Add(this.dfparams);
            this.gpParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpParameters.Location = new System.Drawing.Point(0, 0);
            this.gpParameters.Name = "gpParameters";
            this.gpParameters.Size = new System.Drawing.Size(669, 104);
            this.gpParameters.TabIndex = 4;
            this.gpParameters.TabStop = false;
            this.gpParameters.Text = "Parameters";
            // 
            // dfparams
            // 
            this.dfparams.DisableFileParameters = true;
            this.dfparams.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dfparams.Location = new System.Drawing.Point(3, 16);
            this.dfparams.Name = "dfparams";
            this.dfparams.Size = new System.Drawing.Size(663, 85);
            this.dfparams.TabIndex = 0;
            // 
            // gpCommands
            // 
            this.gpCommands.Controls.Add(this.btnUnInit);
            this.gpCommands.Controls.Add(this.btnInit);
            this.gpCommands.Controls.Add(this.btnGetUID);
            this.gpCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpCommands.Location = new System.Drawing.Point(0, 104);
            this.gpCommands.Name = "gpCommands";
            this.gpCommands.Size = new System.Drawing.Size(669, 217);
            this.gpCommands.TabIndex = 5;
            this.gpCommands.TabStop = false;
            this.gpCommands.Text = "Commands";
            // 
            // btnUnInit
            // 
            this.btnUnInit.Location = new System.Drawing.Point(424, 30);
            this.btnUnInit.Name = "btnUnInit";
            this.btnUnInit.Size = new System.Drawing.Size(171, 44);
            this.btnUnInit.TabIndex = 7;
            this.btnUnInit.Text = "UnInit";
            this.btnUnInit.UseVisualStyleBackColor = true;
            this.btnUnInit.Click += new System.EventHandler(this.btnUnInit_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(70, 30);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(171, 44);
            this.btnInit.TabIndex = 6;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // btnGetUID
            // 
            this.btnGetUID.Location = new System.Drawing.Point(247, 30);
            this.btnGetUID.Name = "btnGetUID";
            this.btnGetUID.Size = new System.Drawing.Size(171, 44);
            this.btnGetUID.TabIndex = 4;
            this.btnGetUID.Text = "Get UID";
            this.btnGetUID.UseVisualStyleBackColor = true;
            this.btnGetUID.Click += new System.EventHandler(this.btnGetUID_Click);
            // 
            // SAMCommandsSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 321);
            this.Controls.Add(this.gpCommands);
            this.Controls.Add(this.gpParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SAMCommandsSample";
            this.Text = "SAM Commands";
            this.gpParameters.ResumeLayout(false);
            this.gpCommands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpParameters;
        private DESFireParametersControl dfparams;
        private System.Windows.Forms.GroupBox gpCommands;
        private System.Windows.Forms.Button btnGetUID;
        private System.Windows.Forms.Button btnUnInit;
        private System.Windows.Forms.Button btnInit;
    }
}