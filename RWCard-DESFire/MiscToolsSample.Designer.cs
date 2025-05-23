namespace RWCard_DESFire
{
    partial class MiscToolsSample
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
            gpParameters = new System.Windows.Forms.GroupBox();
            gpCommands = new System.Windows.Forms.GroupBox();
            btnAV2Div = new System.Windows.Forms.Button();
            lblData = new System.Windows.Forms.Label();
            tbxData = new System.Windows.Forms.TextBox();
            lblDiversifier = new System.Windows.Forms.Label();
            tbxDiversifier = new System.Windows.Forms.TextBox();
            gpParameters.SuspendLayout();
            gpCommands.SuspendLayout();
            SuspendLayout();
            // 
            // gpParameters
            // 
            gpParameters.Controls.Add(lblDiversifier);
            gpParameters.Controls.Add(tbxDiversifier);
            gpParameters.Controls.Add(lblData);
            gpParameters.Controls.Add(tbxData);
            gpParameters.Dock = System.Windows.Forms.DockStyle.Top;
            gpParameters.Location = new System.Drawing.Point(0, 0);
            gpParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gpParameters.Name = "gpParameters";
            gpParameters.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gpParameters.Size = new System.Drawing.Size(780, 120);
            gpParameters.TabIndex = 4;
            gpParameters.TabStop = false;
            gpParameters.Text = "Parameters";
            // 
            // gpCommands
            // 
            gpCommands.Controls.Add(btnAV2Div);
            gpCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            gpCommands.Location = new System.Drawing.Point(0, 120);
            gpCommands.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gpCommands.Name = "gpCommands";
            gpCommands.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gpCommands.Size = new System.Drawing.Size(780, 250);
            gpCommands.TabIndex = 5;
            gpCommands.TabStop = false;
            gpCommands.Text = "Commands";
            // 
            // btnAV2Div
            // 
            btnAV2Div.Location = new System.Drawing.Point(82, 35);
            btnAV2Div.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAV2Div.Name = "btnAV2Div";
            btnAV2Div.Size = new System.Drawing.Size(200, 51);
            btnAV2Div.TabIndex = 6;
            btnAV2Div.Text = "NXP AV2 (AN10922) Diversification";
            btnAV2Div.UseVisualStyleBackColor = true;
            btnAV2Div.Click += btnAV2Div_Click;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new System.Drawing.Point(36, 25);
            lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblData.Name = "lblData";
            lblData.Size = new System.Drawing.Size(34, 15);
            lblData.TabIndex = 3;
            lblData.Text = "Data:";
            // 
            // tbxData
            // 
            tbxData.Location = new System.Drawing.Point(78, 22);
            tbxData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbxData.Name = "tbxData";
            tbxData.Size = new System.Drawing.Size(415, 23);
            tbxData.TabIndex = 2;
            // 
            // lblDiversifier
            // 
            lblDiversifier.AutoSize = true;
            lblDiversifier.Location = new System.Drawing.Point(8, 54);
            lblDiversifier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDiversifier.Name = "lblDiversifier";
            lblDiversifier.Size = new System.Drawing.Size(62, 15);
            lblDiversifier.TabIndex = 5;
            lblDiversifier.Text = "Diversifier:";
            // 
            // tbxDiversifier
            // 
            tbxDiversifier.Location = new System.Drawing.Point(78, 51);
            tbxDiversifier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbxDiversifier.Name = "tbxDiversifier";
            tbxDiversifier.Size = new System.Drawing.Size(415, 23);
            tbxDiversifier.TabIndex = 4;
            // 
            // MiscToolsSample
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(780, 370);
            Controls.Add(gpCommands);
            Controls.Add(gpParameters);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MiscToolsSample";
            Text = "SAM Commands";
            gpParameters.ResumeLayout(false);
            gpParameters.PerformLayout();
            gpCommands.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gpParameters;
        private System.Windows.Forms.GroupBox gpCommands;
        private System.Windows.Forms.Button btnGetUID;
        private System.Windows.Forms.Button btnUnInit;
        private System.Windows.Forms.Button btnAV2Div;
        private System.Windows.Forms.Label lblDiversifier;
        private System.Windows.Forms.TextBox tbxDiversifier;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox tbxData;
    }
}