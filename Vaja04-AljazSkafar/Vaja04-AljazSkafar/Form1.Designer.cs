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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnVstaviStevilo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFunkcije = new System.Windows.Forms.GroupBox();
            this.btnVsota = new System.Windows.Forms.Button();
            this.btnPovprecje = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnPocisti = new System.Windows.Forms.Button();
            this.btnMinMax = new System.Windows.Forms.Button();
            this.grpVstavljanjeStevil.SuspendLayout();
            this.grpFunkcije.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVstavljanjeStevil
            // 
            this.grpVstavljanjeStevil.Controls.Add(this.textBox);
            this.grpVstavljanjeStevil.Controls.Add(this.btnVstaviStevilo);
            this.grpVstavljanjeStevil.Controls.Add(this.label1);
            this.grpVstavljanjeStevil.Location = new System.Drawing.Point(18, 18);
            this.grpVstavljanjeStevil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVstavljanjeStevil.Name = "grpVstavljanjeStevil";
            this.grpVstavljanjeStevil.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpVstavljanjeStevil.Size = new System.Drawing.Size(210, 245);
            this.grpVstavljanjeStevil.TabIndex = 0;
            this.grpVstavljanjeStevil.TabStop = false;
            this.grpVstavljanjeStevil.Text = "Vstavljanje števil";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(93, 83);
            this.textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(103, 26);
            this.textBox.TabIndex = 3;
            // 
            // btnVstaviStevilo
            // 
            this.btnVstaviStevilo.Location = new System.Drawing.Point(26, 146);
            this.btnVstaviStevilo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVstaviStevilo.Name = "btnVstaviStevilo";
            this.btnVstaviStevilo.Size = new System.Drawing.Size(150, 54);
            this.btnVstaviStevilo.TabIndex = 2;
            this.btnVstaviStevilo.Text = "Vstavi število";
            this.btnVstaviStevilo.UseVisualStyleBackColor = true;
            this.btnVstaviStevilo.Click += new System.EventHandler(this.btnVstaviStevilo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Število:";
            // 
            // grpFunkcije
            // 
            this.grpFunkcije.Controls.Add(this.btnMinMax);
            this.grpFunkcije.Controls.Add(this.btnVsota);
            this.grpFunkcije.Controls.Add(this.btnPovprecje);
            this.grpFunkcije.Location = new System.Drawing.Point(18, 292);
            this.grpFunkcije.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFunkcije.Name = "grpFunkcije";
            this.grpFunkcije.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpFunkcije.Size = new System.Drawing.Size(210, 245);
            this.grpFunkcije.TabIndex = 1;
            this.grpFunkcije.TabStop = false;
            this.grpFunkcije.Text = "Funkcije";
            // 
            // btnVsota
            // 
            this.btnVsota.Location = new System.Drawing.Point(35, 42);
            this.btnVsota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVsota.Name = "btnVsota";
            this.btnVsota.Size = new System.Drawing.Size(150, 54);
            this.btnVsota.TabIndex = 1;
            this.btnVsota.Text = "Vsota";
            this.btnVsota.UseVisualStyleBackColor = true;
            this.btnVsota.Click += new System.EventHandler(this.btnVsota_Click);
            // 
            // btnPovprecje
            // 
            this.btnPovprecje.Location = new System.Drawing.Point(35, 106);
            this.btnPovprecje.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPovprecje.Name = "btnPovprecje";
            this.btnPovprecje.Size = new System.Drawing.Size(150, 54);
            this.btnPovprecje.TabIndex = 0;
            this.btnPovprecje.Text = "Povprečje";
            this.btnPovprecje.UseVisualStyleBackColor = true;
            this.btnPovprecje.Click += new System.EventHandler(this.btnPovprecje_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(237, 18);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(178, 444);
            this.listBox.TabIndex = 2;
            // 
            // btnPocisti
            // 
            this.btnPocisti.Enabled = false;
            this.btnPocisti.Location = new System.Drawing.Point(250, 483);
            this.btnPocisti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPocisti.Name = "btnPocisti";
            this.btnPocisti.Size = new System.Drawing.Size(150, 54);
            this.btnPocisti.TabIndex = 2;
            this.btnPocisti.Text = "Pocisti";
            this.btnPocisti.UseVisualStyleBackColor = true;
            this.btnPocisti.Click += new System.EventHandler(this.btnPocisti_Click);
            // 
            // btnMinMax
            // 
            this.btnMinMax.Location = new System.Drawing.Point(35, 170);
            this.btnMinMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinMax.Name = "btnMinMax";
            this.btnMinMax.Size = new System.Drawing.Size(150, 54);
            this.btnMinMax.TabIndex = 2;
            this.btnMinMax.Text = "Min/Max";
            this.btnMinMax.UseVisualStyleBackColor = true;
            this.btnMinMax.Click += new System.EventHandler(this.btnMinMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 555);
            this.Controls.Add(this.btnPocisti);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.grpFunkcije);
            this.Controls.Add(this.grpVstavljanjeStevil);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnVstaviStevilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVsota;
        private System.Windows.Forms.Button btnPovprecje;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnPocisti;
        private System.Windows.Forms.Button btnMinMax;
    }
}

