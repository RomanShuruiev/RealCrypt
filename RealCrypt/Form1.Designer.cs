namespace RealCrypt
{
    partial class Form1
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
            this.ChDirectory = new System.Windows.Forms.Button();
            this.BtCrypt = new System.Windows.Forms.Button();
            this.ChCrypted = new System.Windows.Forms.Button();
            this.BtEncrypt = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.nameDir = new System.Windows.Forms.TextBox();
            this.nameEn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ChDirectory
            // 
            this.ChDirectory.Location = new System.Drawing.Point(172, 69);
            this.ChDirectory.Name = "ChDirectory";
            this.ChDirectory.Size = new System.Drawing.Size(164, 61);
            this.ChDirectory.TabIndex = 0;
            this.ChDirectory.Text = "Choose Directory";
            this.ChDirectory.UseVisualStyleBackColor = true;
            this.ChDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtCrypt
            // 
            this.BtCrypt.Location = new System.Drawing.Point(351, 68);
            this.BtCrypt.Name = "BtCrypt";
            this.BtCrypt.Size = new System.Drawing.Size(176, 62);
            this.BtCrypt.TabIndex = 1;
            this.BtCrypt.Text = "Crypt";
            this.BtCrypt.UseVisualStyleBackColor = true;
            this.BtCrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChCrypted
            // 
            this.ChCrypted.Location = new System.Drawing.Point(171, 182);
            this.ChCrypted.Name = "ChCrypted";
            this.ChCrypted.Size = new System.Drawing.Size(165, 62);
            this.ChCrypted.TabIndex = 2;
            this.ChCrypted.Text = "Choose Crypted";
            this.ChCrypted.UseVisualStyleBackColor = true;
            this.ChCrypted.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtEncrypt
            // 
            this.BtEncrypt.Location = new System.Drawing.Point(351, 182);
            this.BtEncrypt.Name = "BtEncrypt";
            this.BtEncrypt.Size = new System.Drawing.Size(176, 62);
            this.BtEncrypt.TabIndex = 3;
            this.BtEncrypt.Text = "Encrypt";
            this.BtEncrypt.UseVisualStyleBackColor = true;
            this.BtEncrypt.Click += new System.EventHandler(this.button4_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // nameDir
            // 
            this.nameDir.Location = new System.Drawing.Point(12, 69);
            this.nameDir.Name = "nameDir";
            this.nameDir.Size = new System.Drawing.Size(100, 20);
            this.nameDir.TabIndex = 4;
            // 
            // nameEn
            // 
            this.nameEn.Location = new System.Drawing.Point(12, 182);
            this.nameEn.Name = "nameEn";
            this.nameEn.Size = new System.Drawing.Size(100, 20);
            this.nameEn.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 341);
            this.Controls.Add(this.nameEn);
            this.Controls.Add(this.nameDir);
            this.Controls.Add(this.BtEncrypt);
            this.Controls.Add(this.ChCrypted);
            this.Controls.Add(this.BtCrypt);
            this.Controls.Add(this.ChDirectory);
            this.Name = "Form1";
            this.Text = "RealCrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChDirectory;
        private System.Windows.Forms.Button BtCrypt;
        private System.Windows.Forms.Button ChCrypted;
        private System.Windows.Forms.Button BtEncrypt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox nameDir;
        private System.Windows.Forms.TextBox nameEn;
    }
}

