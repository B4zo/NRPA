using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaja04_AljazSkafar
{
    public partial class Form1 : Form
    {
        public const int listBoxMax = 15;
        public const int minUserInput = 1;
        public const int maxUserInput = 20;
        private bool jeSteviloValidno(string stevilo, int min, int max) 
        {
            if(int.TryParse(stevilo, out int value) && (value >= min && value <= max))
            {
                return true;
            } else
            {
                return false;
            }
        }
        private int sestej(System.Windows.Forms.ListBox.ObjectCollection seznam)
        {
            int vsota = 0;
            foreach (string item in seznam)
            {
                vsota += int.Parse(item);
            }
            return vsota;
        }
        private double povprecje(System.Windows.Forms.ListBox.ObjectCollection seznam)
        {
            return (double)sestej(seznam) / seznam.Count;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void btnVstaviStevilo_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 0)
            {
                MessageBox.Show("Nisi vnesel števila.\n\nZa začetek najprej vnesi kakšno število.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (jeSteviloValidno(textBox.Text, minUserInput, maxUserInput))
                {
                    if (listBox.Items.Count < listBoxMax)
                    {
                        listBox.Items.Add(textBox.Text);
                        btnPocisti.Enabled = true;
                        textBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Dosegel si maksimalno število vnosov.\n\nMaksimalno število vnosov je " + listBoxMax + ".", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Število ni veljavno.\n\nVnesi število med " + minUserInput + " in " + maxUserInput + ".", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.SelectAll();
                }
            }
        }
        private void btnVsota_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Vsote ne moreš izračunati, saj nisi vnesel števil.\n\nZa Začetek najprej vnesi kakšno število.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("V listBox-u je: " + listBox.Items.Count + " števil.\n\n" + "Vsota vseh vnesenih števil je: " + sestej(listBox.Items), "Vsota (int)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox.Items.Clear();
                btnPocisti.Enabled = false;
            }
        }
        private void btnPovprecje_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count == 0)
            {
                MessageBox.Show("Nisi vnesel števila.\n\nZa začetek najprej vnesi kakšno število.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("V listBox-u je: " + listBox.Items.Count + " števil.\n\n" + "Povprecje vseh vnesenih števil je: " + povprecje(listBox.Items), "Povprečje (double)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox.Items.Clear();
                btnPocisti.Enabled = false;
            }
        }

        private void btnPocisti_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            listBox.Items.Clear();
            btnPocisti.Enabled = false;
        }

        private void btnMinMax_Click(object sender, EventArgs e)
        {
            int max = 0;
            foreach (string item in listBox.Items)
            {
                if (int.Parse(item) > max)
                    max = int.Parse(item);
                else
                    continue;
            }
            int min = 20;
            foreach (string item in listBox.Items)
            {
                if (int.Parse(item) < min)
                    min = int.Parse(item);
                else
                    continue;
            }
            MessageBox.Show("Minimum je: " + min + "\n\n" + "Maximum je: " + max + "\n\n" , "Min/max", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
