namespace RWCard_DESFire
{
    partial class CardStorageServiceSample
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gpActions = new System.Windows.Forms.GroupBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 20);
            this.textBox1.TabIndex = 0;
            // 
            // gpActions
            // 
            this.gpActions.Controls.Add(this.btnRead);
            this.gpActions.Controls.Add(this.btnWrite);
            this.gpActions.Controls.Add(this.label1);
            this.gpActions.Controls.Add(this.textBox1);
            this.gpActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpActions.Location = new System.Drawing.Point(0, 26);
            this.gpActions.Name = "gpActions";
            this.gpActions.Size = new System.Drawing.Size(429, 145);
            this.gpActions.TabIndex = 1;
            this.gpActions.TabStop = false;
            this.gpActions.Text = "Actions";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(210, 83);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(126, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read data from a card";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(78, 83);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(126, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write data to a card";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(418, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "This sample demonstrate how to read and write data to a Mifare Classic\r\nand Mifar" +
    "e DESFire EV1 card, using C# Liblogicalaccess generic Card Storage service.";
            // 
            // CardStorageServiceSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 171);
            this.Controls.Add(this.gpActions);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CardStorageServiceSample";
            this.Text = "Card Storage Service";
            this.gpActions.ResumeLayout(false);
            this.gpActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gpActions;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

