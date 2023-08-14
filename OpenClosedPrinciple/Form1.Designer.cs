namespace OpenClosedPrinciple
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
            this.btnABank = new System.Windows.Forms.Button();
            this.btnBBank = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnABank
            // 
            this.btnABank.Location = new System.Drawing.Point(100, 69);
            this.btnABank.Name = "btnABank";
            this.btnABank.Size = new System.Drawing.Size(99, 55);
            this.btnABank.TabIndex = 0;
            this.btnABank.Text = "A Bank";
            this.btnABank.UseVisualStyleBackColor = true;
            this.btnABank.Click += new System.EventHandler(this.btnABank_Click);
            // 
            // btnBBank
            // 
            this.btnBBank.Location = new System.Drawing.Point(205, 69);
            this.btnBBank.Name = "btnBBank";
            this.btnBBank.Size = new System.Drawing.Size(92, 55);
            this.btnBBank.TabIndex = 1;
            this.btnBBank.Text = "B Bank";
            this.btnBBank.UseVisualStyleBackColor = true;
            this.btnBBank.Click += new System.EventHandler(this.btnBBank_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBBank);
            this.Controls.Add(this.btnABank);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnABank;
        private System.Windows.Forms.Button btnBBank;
    }
}

