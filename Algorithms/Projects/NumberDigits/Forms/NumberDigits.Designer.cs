namespace Algorithms
{
    partial class NumberDigits
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblOnes = new System.Windows.Forms.Label();
            this.lblTens = new System.Windows.Forms.Label();
            this.lblHundreds = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumbers
            // 
            this.txtNumbers.Location = new System.Drawing.Point(279, 194);
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.Size = new System.Drawing.Size(209, 23);
            this.txtNumbers.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCheck.Location = new System.Drawing.Point(279, 242);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(209, 32);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Kontrol Et";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click_1);
            // 
            // lblOnes
            // 
            this.lblOnes.AutoSize = true;
            this.lblOnes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblOnes.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOnes.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblOnes.Location = new System.Drawing.Point(592, 183);
            this.lblOnes.Name = "lblOnes";
            this.lblOnes.Size = new System.Drawing.Size(0, 28);
            this.lblOnes.TabIndex = 2;
            // 
            // lblTens
            // 
            this.lblTens.AutoSize = true;
            this.lblTens.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTens.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTens.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblTens.Location = new System.Drawing.Point(592, 226);
            this.lblTens.Name = "lblTens";
            this.lblTens.Size = new System.Drawing.Size(0, 28);
            this.lblTens.TabIndex = 2;
            // 
            // lblHundreds
            // 
            this.lblHundreds.AutoSize = true;
            this.lblHundreds.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHundreds.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHundreds.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblHundreds.Location = new System.Drawing.Point(592, 272);
            this.lblHundreds.Name = "lblHundreds";
            this.lblHundreds.Size = new System.Drawing.Size(0, 28);
            this.lblHundreds.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(194, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Basamaklarına Ayırma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(142, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayıyı giriniz :";
            // 
            // NumberDigits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHundreds);
            this.Controls.Add(this.lblTens);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOnes);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtNumbers);
            this.Name = "NumberDigits";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblOnes;
        private System.Windows.Forms.Label lblTens;
        private System.Windows.Forms.Label lblHundreds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
