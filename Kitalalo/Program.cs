using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Kitalalo
{
    internal class Program
    {
        #region változók
        public static string[] items = {
    "fuvola", "csirke", "adatok", "asztal", "fogoly",
    "bicska", "farkas", "almafa", "babona", "gerinc",
    "dervis", "bagoly", "ecetes", "angyal", "boglya" };
        public static string[] item = {};

        public static int valasztottszo;
        public static string ezlett;
        public static string tipp;
        public static string guess;
        #endregion

        static void Main(string[] args)
        {
            aKivalasztottSzo();

            tipp = "";

            // Kezdetben minden karakter pontként jelenik meg
            for (int i = 0; i < ezlett.Length; i++)
            {
                tipp += ".";
            }

            // Addig folytatjuk a tippelést, amíg nem találjuk ki a teljes szót
            while (tipp != ezlett)
            {
                Console.Clear();
                Console.WriteLine("Kitalálandó szó: " + tipp);
                Console.Write("Tippelj egy szót (6 karakter): ");
                guess = Console.ReadLine().ToLower();
                while (guess.Length != 6)
                {
                    Console.Clear() ;
                    Console.WriteLine("Kitalálandó szó: " + tipp);
                    Console.Write("Tippelj egy szót (6 karakter): ");
                    guess = Console.ReadLine().ToLower();
                }

                if (guess == ezlett)
                {
                    Console.Clear();
                    Console.WriteLine("Gratulálok, kitaláltad a szót!");
                    Console.WriteLine("A kitalálandó szó a(z): " + ezlett + " volt.");
                    break;
                }
                else
                {
                    // Ellenőrizzük, hogy a tippelt szóban van-e olyan karakter, ami megegyezik a célszóval
                    for (int i = 0; i < ezlett.Length; i++)
                    {
                        if (guess.Contains(ezlett[i]))
                        {
                            tipp = tipp.Substring(0, i) + ezlett[i] + tipp.Substring(i + 1);
                        }
                    }
                    Console.WriteLine("Nem talált. Próbáld újra!");
                }
            }


                Console.ReadKey();

        }

        public static void aKivalasztottSzo() 
        {
            valasztottszo = aGepSzotValaszt(); //
            //Console.WriteLine(valasztottszo);

            ezlett = items[valasztottszo];
            Console.WriteLine("rejtett szó: " + ezlett);

        }
        public static int aGepSzotValaszt()
        {
            Random random= new Random();
            int a = random.Next(0,14);
            return a;
        }
    }
}
