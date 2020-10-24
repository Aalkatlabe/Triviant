using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviant
{
    class Vraag
    {
        public string tekst;
        public string[] antwoorden;
        public int juisteAntwoord;
        public int Score;
        public string cacategorie;

        public string GetTekst()
        {
            return tekst;
        }

        public void GetAntwoorden()
        {
            int teller = 0;
            foreach (string antwoord in this.antwoorden)
            {
                teller++;
                Console.WriteLine((teller) + ". " + antwoord);
            }
            Console.WriteLine("");
            Console.WriteLine("Type uw keuze : 1,2,3 of 4");
        }

        public int CheckAntwoord(int Antw)
        {
            if( Antw == juisteAntwoord +1)
            {
                return 1;
            }
            else if(Antw > 4)
            {
                return 99;
            }
            else
            {
                return 0;
            }
        }

    }
}
