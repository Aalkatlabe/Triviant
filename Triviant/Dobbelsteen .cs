using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triviant
{
    static class Dobbelsteen
    {
        

        public static  int rollen()
        {
            Random r = new Random();
            int num = r.Next(6);
            return num;
        }
        public static string switchDobbelsteen (int nummer)
        {
            string cata = "";
            switch (nummer) { 
                case 1:
                    cata = "Sport";
                    break;
                case 2:
                    cata = "Politiek";
                    
                    break;
                case 3:
                    cata = "Geschiedenis";
                    break;
                case 4:
                    cata = "Cultuur";
                    break;
                case 5:
                    cata = "Muziek";
                    break;
                case 6:
                    cata = "TECHNIEK & WETENSCHAP";
                    break;


            }
            return cata;
        }

    }

}
