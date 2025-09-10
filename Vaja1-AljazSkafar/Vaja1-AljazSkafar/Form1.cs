using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja1_AljazSkafar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Primerjaj(double a, double b)
        {
            if (a > b)
            {
                txtStevilo1.BackColor = Color.Green;
                txtStevilo2.BackColor = Color.Red;
            }
            else if (a < b)
            {
                txtStevilo1.BackColor = Color.Red;
                txtStevilo2.BackColor = Color.Green;
            }
            else
            {
                txtStevilo1.BackColor = Color.LightBlue;
                txtStevilo2.BackColor = Color.LightBlue;
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double stevilo1, stevilo2;
            if (double.TryParse(txtStevilo1.Text, out stevilo1)&&double.TryParse(txtStevilo2.Text, out stevilo2))
            {
                txtRezultat.Text = (stevilo1 + stevilo2).ToString();
                Primerjaj(stevilo1, stevilo2);
            }
            else
            {
                MessageBox.Show("Vnesite samo števila!");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double stevilo1, stevilo2;
            if (double.TryParse(txtStevilo1.Text, out stevilo1)&&double.TryParse(txtStevilo2.Text, out stevilo2))
            {
                txtRezultat.Text = (stevilo1 - stevilo2).ToString();
                Primerjaj(stevilo1, stevilo2);
            }
            else
            {
                MessageBox.Show("Vnesite samo števila!");
            }
        }

        private void btnMnozenje_Click(object sender, EventArgs e)
        {
            double stevilo1, stevilo2;
            if (double.TryParse(txtStevilo1.Text, out stevilo1)&&double.TryParse(txtStevilo2.Text, out stevilo2))
            {
                txtRezultat.Text = (stevilo1 * stevilo2).ToString();
                Primerjaj(stevilo1, stevilo2);
            }
            else
            {
                MessageBox.Show("Vnesite samo števila!");
            }
        }

        private void btnDeljenje_Click(object sender, EventArgs e)
        {
            double stevilo1, stevilo2;
            if (double.TryParse(txtStevilo1.Text, out stevilo1)&&double.TryParse(txtStevilo2.Text, out stevilo2))
            {
                if (stevilo2 != 0)
                {
                    txtRezultat.Text = (stevilo1 / stevilo2).ToString();
                }
                else 
                {
                    MessageBox.Show("Ne moremo deliti z 0!");
                }
                Primerjaj(stevilo1, stevilo2);
            }
            else
            {
                MessageBox.Show("Vnesite samo števila!");
            }
            if (double.TryParse(txtStevilo1.Text, out stevilo1)&&double.TryParse(txtStevilo2.Text, out stevilo2))
                if(stevilo2 != 0)
                    txtRezultat.Text = (stevilo1 / stevilo2).ToString();
                else
                    MessageBox.Show("Ne moremo deliti z 0!");
            else
                    MessageBox.Show("Vnesite samo števila!");
        }

        private void btnPonastavi_Click(object sender, EventArgs e)
        {
            txtStevilo1.BackColor = Color.White;
            txtStevilo2.BackColor = Color.White;
            txtRezultat.Clear();
        }
    }
}
