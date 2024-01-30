using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KitalaloGUI
{
    public partial class Kitalalo : Form
    {
        public static int elet;
        public Kitalalo()
        {
            InitializeComponent();
        }

        private void Kitalalo_Load(object sender, EventArgs e)
        {
            if (Program.nehezseg == 1)
            {
                elet = 10;
                label_elet.Text = "Életek száma: "+ elet;
            }
            else if (Program.nehezseg == 2)
            {
                elet = 8;
                label_elet.Text = "Életek száma: "+elet;
            }
            else if (Program.nehezseg == 3)
            {
                elet = 5;
                label_elet.Text = "Életek száma: "+elet;
            }
            //###############################################
            List<string> szavak = new List<string>();
            Random random = new Random();
            int randomszam = random.Next(szavak.Count);


            label_randomszo.Text = randomszam.ToString();//!!!


            string file = Directory.GetCurrentDirectory() + "//szavak.txt";
            using (StreamReader sr = new StreamReader(file))
            {
                
                while (!sr.EndOfStream)
                {
                    label_teszt.Text = sr.ReadLine().Replace(',', '\n').Replace('"',' ');
                }
                while (!sr.EndOfStream)
                {
                    szavak.Add(sr.ReadLine());
                }
            }
            //label_teszt.Text = szavak.Count.ToString();

        }

        private void Kitalalo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
