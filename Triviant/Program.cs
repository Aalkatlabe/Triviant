using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviant
{
    class Program
    {
        //Triviant_Console
        static int Score = 0;

        static void Main(string[] args)
        {
            
            Vraag vraag1 = new Vraag();
            vraag1.tekst = "Hoe lang duurt een professionele voetbalwedstrijd?";
            vraag1.antwoorden = new string[] { "90", "95", "100", "110" };
            vraag1.juisteAntwoord = 0;
            vraag1.Score = 10;

            Vraag vraag2 = new Vraag() { tekst = "Welke voetbalclub heeft het grootste voetbalstadion van Nederland? ", antwoorden = new string[] { "ADO Den Haag ", "FC utrecht", " Ajax", "PSV Eindhoven" }, juisteAntwoord = 2, Score = 20 };
            Vraag vraag3 = new Vraag() { tekst = "Welk land mag in 2022 het WK voetbal organiseren? ", antwoorden = new string[] { "Qatar", "USA", "UAE", "KORIA" }, juisteAntwoord = 0, Score = 30 };
            Vraag vraag4 = new Vraag() { tekst = "Welke Italiaanse voetbalclub wordt vergeleken met een oude dame", antwoorden = new string[] { "Rome", "Lazio", "Atalanta", "Juventus" }, juisteAntwoord = 3, Score = 20 };
            Vraag vraag5 = new Vraag() { tekst = "Wie Was De Champions League Winnaar In 2018? ", antwoorden = new string[] { "Real Madrid", "Liverpool", "Barcelona", "Bayern München" }, juisteAntwoord = 0, Score = 20 };

            Vraag[] vragen = { vraag1, vraag2, vraag3, vraag4, vraag5 };
            Console.WriteLine("Welkom bij Triviant");
            Console.WriteLine("Je ziet een vraag op het scherm");
            Console.WriteLine("Je ziet vier antwoorden.");
            Console.WriteLine("Kies het juiste antwoord en je krijg gelijk " + "het resultaat.Zullen we beginnen, geef dan een Enter");
            Console.ReadLine();

            for(int i = 0; i < vragen.Length; i++)
            {
               int teller =i+1;
                
                Console.WriteLine($"{"Vraag"} {teller} ");
                Console.WriteLine(vragen[i].GetTekst());
                Console.WriteLine("");
                vragen[i].GetAntwoorden();
                int Antwoord = int.Parse(Console.ReadLine());
                switchFunction(Antwoord, vragen[i]);
            }

            
        }

        static void switchFunction(int Antwoord, Vraag v)
        {
            switch (v.CheckAntwoord(Antwoord))
            {
                case 1:
                    Console.WriteLine("Goed gedaan.");
                    Score = v.Score + Score;
                    Console.WriteLine("Jouw Score is: " + Score);
                    break;
                case 0:
                    Console.WriteLine("Dat is helaas niet goed. Het antwoord is " + v.antwoorden[v.juisteAntwoord]);
                    Console.WriteLine("Jouw Score is: " + Score);
                    break;
                case 99:
                    Console.WriteLine("Dit is geen geldige invoer.");
                    break;
            }
        }
    }
}
