using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            sprungmarke:
            Console.WriteLine("Rechenart wählen, Tippen Sie eine Zahl");
            Console.WriteLine("1. Addieren +");
            Console.WriteLine("2. Subtrahieren -");
            Console.WriteLine("3. Multiplizieren *");
            Console.WriteLine("4. Dividieren :");
            int rechner = Convert.ToInt32(Console.ReadLine());
            
            if (rechner == 1)
            {
                Console.WriteLine("Addieren: Geben Sie Ihre erste Zahl ein");
                decimal add1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                decimal add2 = Convert.ToDecimal(Console.ReadLine());
                decimal ergebnisadd = add1 + add2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnisadd);
                Console.ReadKey();
                //Environment.Exit(0);
                goto restart;
            }
            if (rechner == 2)
            {
                Console.WriteLine("Subtrahieren: Geben Sie Ihre erste Zahl ein");
                decimal sub1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                decimal sub2 = Convert.ToDecimal(Console.ReadLine());
                decimal ergebnissub = sub1 - sub2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnissub);
                Console.ReadKey();
                //Environment.Exit(0);
                goto restart;
            }

            if (rechner == 3)
            {
                Console.WriteLine("Multiplizieren: Geben Sie Ihre erste Zahl ein");
                decimal mut1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                decimal mut2 = Convert.ToDecimal(Console.ReadLine());
                decimal ergebnismut = mut1 * mut2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnismut);
                Console.ReadKey();
                //Environment.Exit(0);
                goto restart;
            }

            if (rechner == 4)
            {
                Console.WriteLine("Dividieren: Geben Sie Ihre erste Zahl ein");
                decimal div1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("geben Sie die zweite Zahl ein");
                decimal div2 = Convert.ToDecimal(Console.ReadLine());
                decimal ergebnisdiv = div1 / div2;
                Console.WriteLine("Ihr Ergebnis ist " + ergebnisdiv);
                Console.ReadKey();
                //Environment.Exit(0);
                goto restart;
            }
            else
            {
                
                Console.Clear();
                Console.WriteLine("Falsche Eingabe, Programm startet neu");
                Console.ReadKey();
                goto sprungmarke;
            }
            restart:
            Console.WriteLine("Rechnung beendet neu starten?");
            Console.WriteLine("1. Ja");
            Console.WriteLine("2. Nein");
            int restart = Convert.ToInt32(Console.ReadLine());
            if (restart == 1)
            { goto sprungmarke; }
            else { Console.Write("Taste drücken zum beenden");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
