namespace Vaja2_AljazSkafar
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
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnKlikniMe = new System.Windows.Forms.Button();
            this.lblIzpis = new System.Windows.Forms.Label();
            this.chkBarva = new System.Windows.Forms.CheckBox();
            this.btnPonastavitev = new System.Windows.Forms.Button();
            this.pnlCrta = new System.Windows.Forms.Panel();
            this.picSlikaPoklica = new System.Windows.Forms.PictureBox();
            this.lblPoklic = new System.Windows.Forms.Label();
            this.btnNaslednjiPoklic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSlikaPoklica)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(22, 18);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(27, 13);
            this.lblIme.TabIndex = 0;
            this.lblIme.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(63, 15);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 1;
            // 
            // btnKlikniMe
            // 
            this.btnKlikniMe.Location = new System.Drawing.Point(222, 12);
            this.btnKlikniMe.Name = "btnKlikniMe";
            this.btnKlikniMe.Size = new System.Drawing.Size(100, 25);
            this.btnKlikniMe.TabIndex = 2;
            this.btnKlikniMe.Text = "Klikni me";
            this.btnKlikniMe.UseVisualStyleBackColor = true;
            this.btnKlikniMe.Click += new System.EventHandler(this.btnKlikniMe_Click);
            // 
            // lblIzpis
            // 
            this.lblIzpis.AutoSize = true;
            this.lblIzpis.Location = new System.Drawing.Point(39, 120);
            this.lblIzpis.Name = "lblIzpis";
            this.lblIzpis.Size = new System.Drawing.Size(85, 13);
            this.lblIzpis.TabIndex = 3;
            this.lblIzpis.Text = "Vneseno ime je: ";
            // 
            // chkBarva
            // 
            this.chkBarva.AutoSize = true;
            this.chkBarva.Checked = true;
            this.chkBarva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBarva.Location = new System.Drawing.Point(42, 84);
            this.chkBarva.Name = "chkBarva";
            this.chkBarva.Size = new System.Drawing.Size(79, 17);
            this.chkBarva.TabIndex = 4;
            this.chkBarva.Text = "Barvni izpis";
            this.chkBarva.UseVisualStyleBackColor = true;
            // 
            // btnPonastavitev
            // 
            this.btnPonastavitev.BackColor = System.Drawing.Color.OliveDrab;
            this.btnPonastavitev.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPonastavitev.ForeColor = System.Drawing.Color.White;
            this.btnPonastavitev.Location = new System.Drawing.Point(222, 43);
            this.btnPonastavitev.Name = "btnPonastavitev";
            this.btnPonastavitev.Size = new System.Drawing.Size(100, 25);
            this.btnPonastavitev.TabIndex = 5;
            this.btnPonastavitev.Text = "button1";
            this.btnPonastavitev.UseVisualStyleBackColor = false;
            this.btnPonastavitev.Click += new System.EventHandler(this.btnPonastavitev_Click);
            // 
            // pnlCrta
            // 
            this.pnlCrta.BackColor = System.Drawing.Color.OliveDrab;
            this.pnlCrta.Location = new System.Drawing.Point(22, 194);
            this.pnlCrta.Name = "pnlCrta";
            this.pnlCrta.Size = new System.Drawing.Size(308, 2);
            this.pnlCrta.TabIndex = 6;
            // 
            // picSlikaPoklica
            // 
            this.picSlikaPoklica.Image = global::Vaja2_AljazSkafar.Properties.Resources._1;
            this.picSlikaPoklica.Location = new System.Drawing.Point(18, 241);
            this.picSlikaPoklica.Name = "picSlikaPoklica";
            this.picSlikaPoklica.Size = new System.Drawing.Size(110, 150);
            this.picSlikaPoklica.TabIndex = 7;
            this.picSlikaPoklica.TabStop = false;
            // 
            // lblPoklic
            // 
            this.lblPoklic.AutoSize = true;
            this.lblPoklic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblPoklic.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblPoklic.Location = new System.Drawing.Point(14, 199);
            this.lblPoklic.Name = "lblPoklic";
            this.lblPoklic.Size = new System.Drawing.Size(184, 24);
            this.lblPoklic.TabIndex = 8;
            this.lblPoklic.Text = "Predstavitev poklicev";
            // 
            // btnNaslednjiPoklic
            // 
            this.btnNaslednjiPoklic.Location = new System.Drawing.Point(222, 301);
            this.btnNaslednjiPoklic.Name = "btnNaslednjiPoklic";
            this.btnNaslednjiPoklic.Size = new System.Drawing.Size(99, 23);
            this.btnNaslednjiPoklic.TabIndex = 9;
            this.btnNaslednjiPoklic.Text = "Naslednji poklic";
            this.btnNaslednjiPoklic.UseVisualStyleBackColor = true;
            this.btnNaslednjiPoklic.Click += new System.EventHandler(this.btnNaslednjiPoklic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.btnNaslednjiPoklic);
            this.Controls.Add(this.lblPoklic);
            this.Controls.Add(this.picSlikaPoklica);
            this.Controls.Add(this.pnlCrta);
            this.Controls.Add(this.btnPonastavitev);
            this.Controls.Add(this.chkBarva);
            this.Controls.Add(this.lblIzpis);
            this.Controls.Add(this.btnKlikniMe);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vaja2-AljazSkafar";
            ((System.ComponentModel.ISupportInitialize)(this.picSlikaPoklica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnKlikniMe;
        private System.Windows.Forms.Label lblIzpis;
        private System.Windows.Forms.CheckBox chkBarva;
        private System.Windows.Forms.Button btnPonastavitev;
        private System.Windows.Forms.Panel pnlCrta;
        private System.Windows.Forms.PictureBox picSlikaPoklica;
        private System.Windows.Forms.Label lblPoklic;
        private System.Windows.Forms.Button btnNaslednjiPoklic;
    }
}

