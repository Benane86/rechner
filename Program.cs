using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rechner
            //Console.WriteLine("Hallo, Willkommen zum Recher.");
            //Console.WriteLine("Addieren zweier Zahlen");
            //Console.WriteLine("geben Sie die erste Zahl ein");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("geben Sie die zweite Zahl ein");
            //int zahl2 = Convert.ToInt32(Console.ReadLine());
            //int ergebnis = zahl1 + zahl2;
            //Console.WriteLine("Ihr Ergebnis ist " + ergebnis);
            //{ if (ergebnis < 10)
            //       Console.Write("Dein Ergebnis ist kleiner als 10");
            //  else
            //     Console.Write("Dein Ergebnis ist größer/gleich 10");
            //        }
            //Console.ReadKey();



            Console.WriteLine("Rechenart wählen, Tippen Sie eine zahl");
            Console.WriteLine("1. Addieren +");
            Console.WriteLine("2. Subtrahieren -");
            Console.WriteLine("3. Multiplizieren *");
            Console.WriteLine("4. Dividieren :");
            int rechner = Convert.ToInt32(Console.ReadLine());

            if (rechner == 1)
            {
                Console.WriteLine("Addieren: Geben Sie Ihre erste Zahl ein");
                int add1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                int add2 = Convert.ToInt32(Console.ReadLine());
                int ergebnisadd = add1 + add2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnisadd);
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (rechner == 2)
            {
                Console.WriteLine("Subtrahieren: Geben Sie Ihre erste Zahl ein");
                int sub1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                int sub2 = Convert.ToInt32(Console.ReadLine());
                int ergebnissub = sub1 - sub2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnissub);
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (rechner == 3)
            {
                Console.WriteLine("Multiplizieren: Geben Sie Ihre erste Zahl ein");
                int mut1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                int mut2 = Convert.ToInt32(Console.ReadLine());
                int ergebnismut = mut1 * mut2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnismut);
                Console.ReadKey();
                Environment.Exit(0);
            }

            if (rechner == 4)
            {
                Console.WriteLine("Dividieren: Geben Sie Ihre erste Zahl ein");
                int div1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                int div2 = Convert.ToInt32(Console.ReadLine());
                int ergebnisdiv = div1 / div2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnisdiv);
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Falsche Eingabe, bitte Starten Sie neu");
                Console.ReadKey();
            }
          

            Console.ReadKey();
        }
    }
}
