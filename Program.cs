using System;
using System.Dynamic;
using System.IO.Compression;
using System.Linq;
using System.Net.Mime;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] messwerte = new double[24];
            for (int i = 0; i < 24; i++)
            {
                messwerte[i] = 0;
            }
            menu(messwerte);
        }
        static void menu(double[] feld)
        {
            Console.WriteLine("(1) Messdaten eingeben \n" +
                              "(2) Messdaten ausgeben \n" +
                              "(3) Maximalen Messwert ausgeben \n" +
                              "(4) Durchschnittswert ausgeben \n" +
                              "(0) Ende");
            string tmp;
            int tmpInt;

            while (true)
            {
                tmp = Console.ReadLine();
                tmpInt = int.Parse(tmp);
                switch (tmpInt)
                {
                    case 1:
                        Console.WriteLine("Eingabe");
                        eingabe(feld);
                        break;
                    case 2:
                        Console.WriteLine("Ausgabe");
                        ausgabe(feld);
                        break;
                    case 3:
                        Console.WriteLine("Maximum");
                        max(feld);
                        break;
                    case 4:
                        Console.WriteLine("Durchschnitt");
                        avg(feld);
                        break;
                    case 0:
                        Console.WriteLine("0");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Falsche Eingabe");
                        menu(feld);
                        break;
                }
            }
        }

        static void max(double[] feld)
        {
            Console.WriteLine("Maximale Temperatur: "+feld.Max()+" Grad");
            menu(feld);
        }

        static void avg(double[] feld)
        {
            Console.WriteLine("Durchschnittliche Temperatur: " + feld.Average() + " Grad");
            menu(feld);
        }

        static void eingabe(double[] feld)
        {
            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine("Messwert fuer "+i+" Uhr: ", i);
                double tmpDl;
                string tmp;
                tmp = Console.ReadLine();
                if (double.TryParse(tmp,out tmpDl))
                    feld[i]=tmpDl;
                else
                {
                    Console.Write("Falscher Wert\n");
                    i--;
                }
            }
            menu(feld);

        }

        static void ausgabe(double[] feld)
        {
            Console.WriteLine("Uhrzeit        Temperatur");
            for (int i = 0; i < 24; i++)
            {
                Console.WriteLine(i+" Uhr    "+feld[i]+"Grad");
            }
            menu(feld);
        }
        

    }
}

