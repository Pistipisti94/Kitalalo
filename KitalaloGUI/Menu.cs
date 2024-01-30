using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitalaloGUI
{
    partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_nehezseg_Click(object sender, EventArgs e)
        {
            button_jatek.Visible = false;
            button_kilepes.Visible = false;
            button_nehezseg.Visible = false;
            button_kivalaszt.Visible = true;
            button_vissza.Visible = true;
            groupBox_nehezseg.Visible = true;
            label_nehezseg.Visible = true;

        }

        private void button_jatek_Click(object sender, EventArgs e)
        {
            Program.kitalalo.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            groupBox_nehezseg.Visible = false;
            button_vissza.Visible = false;
            button_kivalaszt.Visible = false;
            label_nehezseg.Visible = false;
            Program.nehezseg = 1;
        }

        private void button_kivalaszt_Click(object sender, EventArgs e)
        {
            
            if (radioButton_konnyu.Checked)
            {
                label_nehezseg.Text = "A kiválasztott nehézség: Könnyű";
                Program.nehezseg = 1;
            }
            else if (radioButton_normal.Checked)
            {
                label_nehezseg.Text = "A kiválasztott nehézség: Normál";
                Program.nehezseg = 2;
            }
            else if (radioButton_nehez.Checked)
            {
                label_nehezseg.Text = "A kiválasztott nehézség: Nehéz";
                Program.nehezseg = 3;
            }
            else
            {
                Program.nehezseg = 1;
            }
        }

        private void button_vissza_Click(object sender, EventArgs e)
        {
            button_jatek.Visible = true;
            button_kilepes.Visible = true;
            button_nehezseg.Visible = true;
            button_vissza.Visible = false;
            button_kivalaszt.Visible = false;
            groupBox_nehezseg.Visible = false;
            label_nehezseg.Visible = false;


        }
    }
}
