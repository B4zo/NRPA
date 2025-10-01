namespace Vaja04_AljazSkafar
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
            this.grpVstavljanjeStevil = new System.Windows.Forms.GroupBox();
            this.grpFunkcije = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.grpVstavljanjeStevil.SuspendLayout();
            this.grpFunkcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVstavljanjeStevil
            // 
            this.grpVstavljanjeStevil.Controls.Add(this.textBox1);
            this.grpVstavljanjeStevil.Controls.Add(this.button1);
            this.grpVstavljanjeStevil.Controls.Add(this.label1);
            this.grpVstavljanjeStevil.Location = new System.Drawing.Point(12, 12);
            this.grpVstavljanjeStevil.Name = "grpVstavljanjeStevil";
            this.grpVstavljanjeStevil.Size = new System.Drawing.Size(140, 159);
            this.grpVstavljanjeStevil.TabIndex = 0;
            this.grpVstavljanjeStevil.TabStop = false;
            this.grpVstavljanjeStevil.Text = "Vstavljanje števil";
            // 
            // grpFunkcije
            // 
            this.grpFunkcije.Controls.Add(this.button3);
            this.grpFunkcije.Controls.Add(this.button2);
            this.grpFunkcije.Location = new System.Drawing.Point(12, 190);
            this.grpFunkcije.Name = "grpFunkcije";
            this.grpFunkcije.Size = new System.Drawing.Size(140, 159);
            this.grpFunkcije.TabIndex = 1;
            this.grpFunkcije.TabStop = false;
            this.grpFunkcije.Text = "Funkcije";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Število:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(158, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(120, 342);
            this.listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.grpFunkcije);
            this.Controls.Add(this.grpVstavljanjeStevil);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Učenje imam rad";
            this.grpVstavljanjeStevil.ResumeLayout(false);
            this.grpVstavljanjeStevil.PerformLayout();
            this.grpFunkcije.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVstavljanjeStevil;
        private System.Windows.Forms.GroupBox grpFunkcije;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox;
    }
}

