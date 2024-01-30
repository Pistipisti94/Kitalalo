using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitalaloGUI
{
    internal static class Program
    {
        public static Kitalalo kitalalo = null;
        public static Menu menu = null;
        public static int nehezseg;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kitalalo = new Kitalalo();
            menu = new Menu();

            Application.Run(menu);
        }
    }
}
