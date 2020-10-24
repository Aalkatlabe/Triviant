using System;
using System.Collections.Generic;
using System.IO.Ports;
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
            vraag1.cacategorie = "Sport";

            Vraag vraag2 = new Vraag() { tekst = "Welke politicus viel ooit in slaap tijdens de troonrede? ", antwoorden = new string[] { "Joop den UyI (PvdA) 1977", "Ivo Opstelten (VVD) in 2020", "Diederik Samsom (PvdA) in 2012", "Jesse Klaver (GroenLinks) in 2018" }, juisteAntwoord = 2, Score = 20, cacategorie = "Politiek" };
            Vraag vraag3 = new Vraag() { tekst = "Wie heeft de Mona Lisa geschilderd?", antwoorden = new string[] { "Leonardo da Vinci", "Michelangelo Buonarroti", "Vincent van Gogh", "Rafaël" }, juisteAntwoord = 0, Score = 30, cacategorie = "Geschiedenis" };
            Vraag vraag4 = new Vraag() { tekst = "In welke stad kan je het beroemde beeld David van Michelangelo bewonderen?", antwoorden = new string[] { "Firenze", "Rome", "Bologna", "Milaan" }, juisteAntwoord = 0, Score = 20, cacategorie = "Cultuur" };
            Vraag vraag5 = new Vraag() { tekst = "Via welke website is Justin Bieber ontdekt?", antwoorden = new string[] { "Instagram", "Facebook", "Twitter", "Youtube" }, juisteAntwoord = 3, Score = 20, cacategorie = "Muziek" };
            Vraag vraag6 = new Vraag() { tekst = "Welk telefoonmerk had als populaire model 5100 en 5230?", antwoorden = new string[] { "Motorola", "Nokia", "Sony Ericsson", "Siemens" }, juisteAntwoord = 1, Score = 20, cacategorie = "TECHNIEK & WETENSCHAP" };
            Vraag[] vragen = { vraag1, vraag2, vraag3, vraag4, vraag5, vraag6 };
            Console.WriteLine("Welkom bij Triviant");
            Console.WriteLine("Je ziet een vraag op het scherm");
            Console.WriteLine("Je ziet vier antwoorden.");
            Console.WriteLine("Kies het juiste antwoord en je krijg gelijk " + "het resultaat.Zullen we beginnen, geef dan een Enter");
            Console.ReadLine();

            
            while (true)
            {
                
            
            int cataNum = Dobbelsteen.rollen();
            string cataString = Dobbelsteen.switchDobbelsteen(cataNum+1);

            for (int i = 0; i < vragen.Length; i++)
            {
                int teller = i + 1;
                 if (vragen[i].cacategorie==cataString)
                {
                    Console.WriteLine(cataString);
                    Console.WriteLine(vragen[i].GetTekst());
                    Console.WriteLine("");
                    vragen[i].GetAntwoorden();
                    int Antwoord = int.Parse(Console.ReadLine());
                    switchFunction(Antwoord, vragen[i]);
                    var vragenlijst = vragen.ToList();
                        vragenlijst.Remove(vragen[i]);
                        vragen = vragenlijst.ToArray();
                }


                
            }
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
