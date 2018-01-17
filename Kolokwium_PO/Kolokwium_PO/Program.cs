using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kolokwium_PO
{
    public enum Marka { Amica, Beko, Samsung }
    class Program
    {
        private static Serwis serwis = new Serwis();
        static void Main(string[] args)
        {
            int numerSeryjny;
            Marka marka;
            string polecenie = "";
            while ((polecenie != "x") && (polecenie != "X"))
            {
                WypiszPoczatekNowegoMenu("Aplikacja \"Serwis AGD\"");
                Console.WriteLine("Wpisz polecenie i zatwierdź Enterem. Co chcesz zrobić?");
                Console.WriteLine("A - dodaj pralkę");
                Console.WriteLine("B - dodaj lodówkę");
                Console.WriteLine("C - generuj raport");
                Console.WriteLine("D - napraw");
                Console.WriteLine("E - napraw po numerze seryjnym");
                Console.WriteLine("X - wyjście z aplikacji");
                polecenie = Console.ReadLine();
                switch (polecenie)
                {
                    case "A":
                    case "a":
                        WypiszPoczatekNowegoMenu("Dodawanie pralki");
                        marka = ZczytywanieMarki();
                        Console.WriteLine();
                        numerSeryjny = ZczytywanieNumeruSeryjnego();
                        Console.WriteLine();
                        Console.WriteLine("Podaj usterkę:");
                        serwis.DodajPralke(marka, numerSeryjny, Console.ReadLine());
                        WypiszKoniecMenu("Dodano pralkę do serwisu.");
                        break;
                    case "B":
                    case "b":
                        WypiszPoczatekNowegoMenu("Dodawanie lodówki");
                        marka = ZczytywanieMarki();
                        Console.WriteLine();
                        numerSeryjny = ZczytywanieNumeruSeryjnego();
                        Console.WriteLine();
                        Console.WriteLine("Podaj usterkę:");
                        serwis.DodajPralke(marka, numerSeryjny, Console.ReadLine());
                        WypiszKoniecMenu("Dodano lodówkę do serwisu.");
                        break;
                    case "C":
                    case "c":
                        WypiszPoczatekNowegoMenu("Generowanie raportu");
                        serwis.GenerujRaport();
                        WypiszKoniecMenu("Wygenerowano raport.");
                        break;
                    case "D":
                    case "d":
                        WypiszPoczatekNowegoMenu("Naprawa");
                        serwis.Napraw();
                        WypiszKoniecMenu("Naprawiono pierwszy element z listy.");
                        break;
                    case "E":
                    case "e":
                        WypiszPoczatekNowegoMenu("Naprawa po numerze seryjnym");
                        numerSeryjny = ZczytywanieNumeruSeryjnego();
                        serwis.Napraw(numerSeryjny);
                        WypiszKoniecMenu("Naprawiono urządzenie o numerze seryjnym: " + numerSeryjny);
                        break;
                    case "X":
                    case "x":
                        break;
                    default:
                        Console.Clear();
                        WypiszKoniecMenu("Nieprawidłowe polecenie!");
                        break;
                }
            }
        }
        private static void WypiszPoczatekNowegoMenu(string nazwa)
        {
            Console.Clear();
            Console.WriteLine(nazwa);
            Console.WriteLine();
            Console.WriteLine(serwis);
            Console.WriteLine();
        }
        private static void WypiszKoniecMenu(string informacja)
        {
            Console.WriteLine();
            Console.WriteLine(informacja);
            Console.WriteLine();
            Console.WriteLine("Wciśnij dowolny klawisz aby kontynuwać...");
            Console.ReadKey(true);
        }
        private static void WypiszNieprawidlowaWartosc(string polecenieDoWyswietlenia)
        {
            Console.WriteLine();
            Console.WriteLine("Błąd, wpidano nieprawidłowa wartość!");
            Console.WriteLine();
            Console.WriteLine(polecenieDoWyswietlenia);
        }
        private static Marka ZczytywanieMarki()
        {
            Marka marka;
            string polecenie = "Dozwolone marki: 0 Amica, 1 Beko, 2 Samsung" + Environment.NewLine
                + "Podaj markę bądź liczbę odpowiadającą marce:";
            Console.WriteLine(polecenie);
            while (!Enum.TryParse(Console.ReadLine(), out marka))
                WypiszNieprawidlowaWartosc(polecenie);
            return marka;
        }
        private static int ZczytywanieNumeruSeryjnego()
        {
            int numerSeryjny;
            string polecenie = "Podaj numer seryjny:";
            Console.WriteLine(polecenie);
            while (!int.TryParse(Console.ReadLine(), out numerSeryjny))
                WypiszNieprawidlowaWartosc(polecenie);
            return numerSeryjny;
        }
    }
}
