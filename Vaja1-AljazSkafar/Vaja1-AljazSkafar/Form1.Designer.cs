namespace Vaja1_AljazSkafar
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
            this.lblStevilo1 = new System.Windows.Forms.Label();
            this.lblStevilo2 = new System.Windows.Forms.Label();
            this.txtStevilo1 = new System.Windows.Forms.TextBox();
            this.txtStevilo2 = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.btnMnozenje = new System.Windows.Forms.Button();
            this.btnDeljenje = new System.Windows.Forms.Button();
            this.btnPonastavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStevilo1
            // 
            this.lblStevilo1.AutoSize = true;
            this.lblStevilo1.Location = new System.Drawing.Point(18, 21);
            this.lblStevilo1.Name = "lblStevilo1";
            this.lblStevilo1.Size = new System.Drawing.Size(61, 16);
            this.lblStevilo1.TabIndex = 0;
            this.lblStevilo1.Text = "Število 1:";
            // 
            // lblStevilo2
            // 
            this.lblStevilo2.AutoSize = true;
            this.lblStevilo2.Location = new System.Drawing.Point(18, 55);
            this.lblStevilo2.Name = "lblStevilo2";
            this.lblStevilo2.Size = new System.Drawing.Size(61, 16);
            this.lblStevilo2.TabIndex = 1;
            this.lblStevilo2.Text = "Število 2:";
            // 
            // txtStevilo1
            // 
            this.txtStevilo1.Location = new System.Drawing.Point(90, 15);
            this.txtStevilo1.Name = "txtStevilo1";
            this.txtStevilo1.Size = new System.Drawing.Size(100, 22);
            this.txtStevilo1.TabIndex = 2;
            // 
            // txtStevilo2
            // 
            this.txtStevilo2.Location = new System.Drawing.Point(90, 50);
            this.txtStevilo2.Name = "txtStevilo2";
            this.txtStevilo2.Size = new System.Drawing.Size(100, 22);
            this.txtStevilo2.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlus.Location = new System.Drawing.Point(105, 87);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(32, 32);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMinus.Location = new System.Drawing.Point(143, 87);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(32, 32);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(18, 172);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(61, 16);
            this.lblRezultat.TabIndex = 6;
            this.lblRezultat.Text = "Rezultat: ";
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(90, 166);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(100, 22);
            this.txtRezultat.TabIndex = 7;
            // 
            // btnMnozenje
            // 
            this.btnMnozenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMnozenje.Location = new System.Drawing.Point(105, 125);
            this.btnMnozenje.Name = "btnMnozenje";
            this.btnMnozenje.Size = new System.Drawing.Size(32, 32);
            this.btnMnozenje.TabIndex = 8;
            this.btnMnozenje.Text = "*";
            this.btnMnozenje.UseVisualStyleBackColor = true;
            this.btnMnozenje.Click += new System.EventHandler(this.btnMnozenje_Click);
            // 
            // btnDeljenje
            // 
            this.btnDeljenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeljenje.Location = new System.Drawing.Point(143, 125);
            this.btnDeljenje.Name = "btnDeljenje";
            this.btnDeljenje.Size = new System.Drawing.Size(32, 32);
            this.btnDeljenje.TabIndex = 9;
            this.btnDeljenje.Text = "/";
            this.btnDeljenje.UseVisualStyleBackColor = true;
            this.btnDeljenje.Click += new System.EventHandler(this.btnDeljenje_Click);
            // 
            // btnPonastavi
            // 
            this.btnPonastavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPonastavi.Location = new System.Drawing.Point(181, 87);
            this.btnPonastavi.Name = "btnPonastavi";
            this.btnPonastavi.Size = new System.Drawing.Size(32, 32);
            this.btnPonastavi.TabIndex = 10;
            this.btnPonastavi.Text = "C";
            this.btnPonastavi.UseVisualStyleBackColor = true;
            this.btnPonastavi.Click += new System.EventHandler(this.btnPonastavi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.btnPonastavi);
            this.Controls.Add(this.btnDeljenje);
            this.Controls.Add(this.btnMnozenje);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtStevilo2);
            this.Controls.Add(this.txtStevilo1);
            this.Controls.Add(this.lblStevilo2);
            this.Controls.Add(this.lblStevilo1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Vaja1-AljazSkafar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStevilo1;
        private System.Windows.Forms.Label lblStevilo2;
        private System.Windows.Forms.TextBox txtStevilo1;
        private System.Windows.Forms.TextBox txtStevilo2;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button btnMnozenje;
        private System.Windows.Forms.Button btnDeljenje;
        private System.Windows.Forms.Button btnPonastavi;
    }
}

