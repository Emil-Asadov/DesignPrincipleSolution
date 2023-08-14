namespace InterfaceSegregationPrinciple
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
            this.btnHPPrinter = new System.Windows.Forms.Button();
            this.btnSamsugPrinter = new System.Windows.Forms.Button();
            this.btnLexmarkPrinter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHPPrinter
            // 
            this.btnHPPrinter.Location = new System.Drawing.Point(178, 84);
            this.btnHPPrinter.Name = "btnHPPrinter";
            this.btnHPPrinter.Size = new System.Drawing.Size(126, 54);
            this.btnHPPrinter.TabIndex = 0;
            this.btnHPPrinter.Text = "HP Printer";
            this.btnHPPrinter.UseVisualStyleBackColor = true;
            this.btnHPPrinter.Click += new System.EventHandler(this.btnHPPrinter_Click);
            // 
            // btnSamsugPrinter
            // 
            this.btnSamsugPrinter.Location = new System.Drawing.Point(310, 84);
            this.btnSamsugPrinter.Name = "btnSamsugPrinter";
            this.btnSamsugPrinter.Size = new System.Drawing.Size(126, 54);
            this.btnSamsugPrinter.TabIndex = 1;
            this.btnSamsugPrinter.Text = "Samsug Printer";
            this.btnSamsugPrinter.UseVisualStyleBackColor = true;
            this.btnSamsugPrinter.Click += new System.EventHandler(this.btnSamsugPrinter_Click);
            // 
            // btnLexmarkPrinter
            // 
            this.btnLexmarkPrinter.Location = new System.Drawing.Point(442, 84);
            this.btnLexmarkPrinter.Name = "btnLexmarkPrinter";
            this.btnLexmarkPrinter.Size = new System.Drawing.Size(126, 54);
            this.btnLexmarkPrinter.TabIndex = 2;
            this.btnLexmarkPrinter.Text = "Lexmark Printer";
            this.btnLexmarkPrinter.UseVisualStyleBackColor = true;
            this.btnLexmarkPrinter.Click += new System.EventHandler(this.btnLexmarkPrinter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLexmarkPrinter);
            this.Controls.Add(this.btnSamsugPrinter);
            this.Controls.Add(this.btnHPPrinter);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHPPrinter;
        private System.Windows.Forms.Button btnSamsugPrinter;
        private System.Windows.Forms.Button btnLexmarkPrinter;
    }
}

