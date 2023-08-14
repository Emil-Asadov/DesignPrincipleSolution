namespace LooseCouplingPrinciple
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
            this.lblInp1 = new System.Windows.Forms.Label();
            this.lblInp2 = new System.Windows.Forms.Label();
            this.txtInp1 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.btnCix = new System.Windows.Forms.Button();
            this.btnVur = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtInp2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInp1
            // 
            this.lblInp1.AutoSize = true;
            this.lblInp1.Location = new System.Drawing.Point(133, 47);
            this.lblInp1.Name = "lblInp1";
            this.lblInp1.Size = new System.Drawing.Size(45, 16);
            this.lblInp1.TabIndex = 0;
            this.lblInp1.Text = "Input 1";
            // 
            // lblInp2
            // 
            this.lblInp2.AutoSize = true;
            this.lblInp2.Location = new System.Drawing.Point(133, 75);
            this.lblInp2.Name = "lblInp2";
            this.lblInp2.Size = new System.Drawing.Size(45, 16);
            this.lblInp2.TabIndex = 1;
            this.lblInp2.Text = "Input 2";
            // 
            // txtInp1
            // 
            this.txtInp1.Location = new System.Drawing.Point(215, 44);
            this.txtInp1.Name = "txtInp1";
            this.txtInp1.Size = new System.Drawing.Size(100, 22);
            this.txtInp1.TabIndex = 2;
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(67, 111);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(113, 51);
            this.btnTopla.TabIndex = 3;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // btnCix
            // 
            this.btnCix.Location = new System.Drawing.Point(186, 111);
            this.btnCix.Name = "btnCix";
            this.btnCix.Size = new System.Drawing.Size(113, 51);
            this.btnCix.TabIndex = 4;
            this.btnCix.Text = "Cix";
            this.btnCix.UseVisualStyleBackColor = true;
            this.btnCix.Click += new System.EventHandler(this.btnCix_Click);
            // 
            // btnVur
            // 
            this.btnVur.Location = new System.Drawing.Point(305, 111);
            this.btnVur.Name = "btnVur";
            this.btnVur.Size = new System.Drawing.Size(113, 51);
            this.btnVur.TabIndex = 5;
            this.btnVur.Text = "Vur";
            this.btnVur.UseVisualStyleBackColor = true;
            this.btnVur.Click += new System.EventHandler(this.btnVur_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(424, 111);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(113, 51);
            this.btnBol.TabIndex = 6;
            this.btnBol.Text = "Bol";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(91, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(45, 16);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            // 
            // txtInp2
            // 
            this.txtInp2.Location = new System.Drawing.Point(215, 72);
            this.txtInp2.Name = "txtInp2";
            this.txtInp2.Size = new System.Drawing.Size(100, 22);
            this.txtInp2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtInp2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.btnVur);
            this.Controls.Add(this.btnCix);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtInp1);
            this.Controls.Add(this.lblInp2);
            this.Controls.Add(this.lblInp1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInp1;
        private System.Windows.Forms.Label lblInp2;
        private System.Windows.Forms.TextBox txtInp1;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Button btnCix;
        private System.Windows.Forms.Button btnVur;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtInp2;
    }
}

