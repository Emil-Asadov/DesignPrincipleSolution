namespace LiskovSubstitutionPrinciple
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
            this.btnAWS = new System.Windows.Forms.Button();
            this.btnAzure = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAWS
            // 
            this.btnAWS.Location = new System.Drawing.Point(131, 100);
            this.btnAWS.Name = "btnAWS";
            this.btnAWS.Size = new System.Drawing.Size(121, 52);
            this.btnAWS.TabIndex = 0;
            this.btnAWS.Text = "Amazon";
            this.btnAWS.UseVisualStyleBackColor = true;
            this.btnAWS.Click += new System.EventHandler(this.btnAWS_Click);
            // 
            // btnAzure
            // 
            this.btnAzure.Location = new System.Drawing.Point(258, 100);
            this.btnAzure.Name = "btnAzure";
            this.btnAzure.Size = new System.Drawing.Size(115, 52);
            this.btnAzure.TabIndex = 1;
            this.btnAzure.Text = "Azure";
            this.btnAzure.UseVisualStyleBackColor = true;
            this.btnAzure.Click += new System.EventHandler(this.btnAzure_Click);
            // 
            // btnGoogle
            // 
            this.btnGoogle.Location = new System.Drawing.Point(379, 100);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(115, 52);
            this.btnGoogle.TabIndex = 2;
            this.btnGoogle.Text = "Google";
            this.btnGoogle.UseVisualStyleBackColor = true;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoogle);
            this.Controls.Add(this.btnAzure);
            this.Controls.Add(this.btnAWS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAWS;
        private System.Windows.Forms.Button btnAzure;
        private System.Windows.Forms.Button btnGoogle;
    }
}

