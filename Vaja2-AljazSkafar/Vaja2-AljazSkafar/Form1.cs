using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja2_AljazSkafar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlikniMe_Click(object sender, EventArgs e)
        {
            lblIzpis.Text = "Vneseno ime je: ";
            lblIzpis.ForeColor = Color.Black;

            if (chkBarva.Checked)
                lblIzpis.ForeColor = Color.Red;
            else
                lblIzpis.ForeColor = Color.Black;

            lblIzpis.Text = lblIzpis.Text + txtIme.Text;
        }

        private void btnPonastavitev_Click(object sender, EventArgs e)
        {
            lblIzpis.ForeColor = Color.Red;
            lblIzpis.Text = "Kliknili ste ponastavi";
            txtIme.Text = "";
        }

        private void btnNaslednjiPoklic_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int stevilka = rnd.Next(1, 10);
            picSlikaPoklica.Image = (Image)Properties.Resources.ResourceManager.GetObject("_" + stevilka);
        }
    }
}
