using System;

namespace _03ValtozokTipusai
{
    class Program
    {
        static void Main(string[] args)
        {
            var szam = 1;

            var szoveg = "ez egy szoveg";

            ////Ez ugyan az, 
            var szam2 = 2;
            ////mint ez
            //      int szam2 / 2;
            ////vagy ez:
            //      int szam2;
            //      szam2 = 2;


            var szam3 = 2 + 3;

            // Figyelem, amikor létrejött egy változó, onnantól az ő útja meg van határozva...
            //csak a saját útját járhatja, másét nem

            //mivel változó ezért átírhatom az értékét
            szam = 4;

            //egymásnak is tuvnak értéket adni:
            szam2 = szam + szam3;



            //Ez viszont lehetetlen
            //szam = "ez egy szöveg";
            //szoveg = 3;
            //mivel más műveletnek van értelme egy számon és egy szövegen.
            //számokat el tudok osztani egymással, szövegeket például nem




            //Milyen típusok vannak?
            //számok (egész, tízedestört, stb...)
            //szüveg
            // logikati (igaz/hamis : true/false)

            var igaz = true;
            var hamis = false;

            //Dátum/idő  (DateTime)

            szam2 = Osszeadas(szam, szam3);

            var szam4 = Osszeadas(4, 6);
            szam4 = Osszeadas(1, 5);
            szam4 = Osszeadas(szam, 6);
            szam4 = Osszeadas(szam, Osszeadas(szam2,5));  // szamold ki
            // a szam2 és az 5 értékét
            //az így kapott értéket használd a második összeadás második paramétereként,
            //az első legyen a szám nevű változó

        }

        private static int Osszeadas(int szam1, int szam2)
        {
            var szam0 = szam1 + szam2;

            return szam0;  // Ez jelenti azt, hogy visszatérünk a Return után következő értékkel.
        }
    }
}
