namespace DependencyInversionPrinciple
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
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnHotMail = new System.Windows.Forms.Button();
            this.btnYandex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGmail
            // 
            this.btnGmail.Location = new System.Drawing.Point(214, 101);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(103, 46);
            this.btnGmail.TabIndex = 0;
            this.btnGmail.Text = "Gmail";
            this.btnGmail.UseVisualStyleBackColor = true;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnHotMail
            // 
            this.btnHotMail.Location = new System.Drawing.Point(323, 101);
            this.btnHotMail.Name = "btnHotMail";
            this.btnHotMail.Size = new System.Drawing.Size(100, 46);
            this.btnHotMail.TabIndex = 1;
            this.btnHotMail.Text = "Hot Mail";
            this.btnHotMail.UseVisualStyleBackColor = true;
            this.btnHotMail.Click += new System.EventHandler(this.btnHotMail_Click);
            // 
            // btnYandex
            // 
            this.btnYandex.Location = new System.Drawing.Point(429, 101);
            this.btnYandex.Name = "btnYandex";
            this.btnYandex.Size = new System.Drawing.Size(100, 46);
            this.btnYandex.TabIndex = 2;
            this.btnYandex.Text = "Yandex";
            this.btnYandex.UseVisualStyleBackColor = true;
            this.btnYandex.Click += new System.EventHandler(this.btnYandex_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYandex);
            this.Controls.Add(this.btnHotMail);
            this.Controls.Add(this.btnGmail);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnHotMail;
        private System.Windows.Forms.Button btnYandex;
    }
}

