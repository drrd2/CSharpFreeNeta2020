using System;

namespace _02Receptek
{
    class Program
    {
        /// <summary>
        /// Legyen az a feladat, hogy egy pörkölt recept hozzávalóit kiírjuk a képernyőre
        /// 
        /// Kiegészítés:
        /// hetente egyszer érkezik hal a piacra, akkor halas ételt szeretnélk készíteni,
        /// egyébként pörköltet.
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            // ha (péntek vak) akkor (halas recept) egyébként (pörkölt recept)

            //FELTÉTELVIZSGÁLAT:
            //megnézünk egy információt, és attól függően
            //hogy mit mutat az információ
            //vagy az egyik tevékenységet végezzük el
            //vagy a másikat
            //DE egyszerre mindig csak az egyiket

            // ha (péntek vak) 
            //akkor (halas recept) 
            //egyébként (pörkölt recept)


            // kódblokk:  {} minden, ami kát kapcsos zárójel között van


            //   TÖBB SOR KOMMENTELÉSE  -> Kijelöljök a kommentelni kívánt sorokat majd  ->  Ctrl+K majd Ctrl+C 

            //if (péntek van?)  // ide kerül az iformáció vizsgálata
            //{ //kódblokk eleje
            //     // Ebbe a kódblokkba kerül az, 
            //     //amit akkor hajtunk végre, 
            //     //ha a vizsgálat igaz 
            //    //(a kérdésre adott, hogy igen, a válasz: IGAZ (péntek van) )
            //}//kódblokk vége
            //else
            //{//kódblokk eleje
            // // Ebbe a kódblokkba kerül az, 
            // //amit akkor hajtunk végre, 
            // //ha a vizsgálat igaz 
            // //(a kérdésre adott, hogy nem, a válasz: HAMIS (nem péntek van) )
            //}//kódblokk vége

            //Ha két dolognak az egyenlőségét vizsgálljuk, akkor
            //dupla egyenlőség jelet használunk: ==

            // Datetime.Today      ->     a mai dátumot adja meg
            // DateTime.Today.DayOfWeek    ->  milyen nap van ma



            // Lépésekre bontjuk a bonyolult részt
            //változó: variable, rövidítve : var:

            //ltrehozunk egy maiNap nevű változót 
            //és megadjuk neki a mai napot:
            var maiNap = DateTime.Today;

            //a mai nap az a hétnek melyik napja:
            var maiNapNeve = maiNap.DayOfWeek;

            //melyik napon van hal a piacon:
            var maVanHalAPiacon = DayOfWeek.Friday;

            AMegfeleloREceptKiiratasa(maiNapNeve, maVanHalAPiacon);

            Console.ReadLine();
        }


    
        private static void AMegfeleloREceptKiiratasa(DayOfWeek maiNapNeve, DayOfWeek maVanHalAPiacon)
        {
            //if (DateTime.Today.DayOfWeek==DayOfWeek.Tuesday)  // ezt a sort erre tudjuk cserélni:
            if (maiNapNeve == maVanHalAPiacon)
            {
                HalasReceptKiirasa();
            }
            else
            {
                PorkoltReceptKiiratasa();
            }
        }

        /// <summary>
        /// Halas recept kiírása a konzolra
        /// </summary>
        private static void HalasReceptKiirasa()
        {
            Console.WriteLine("Valamilyen halas étel recept hozzávalók.. \n(hal\ncitrom\nfűszerek)");
        }


        /// <summary>
        /// Egy pörkölt recept kiírását végző függvény
        /// 
        /// (private/internal/public)  : honnan látható? 
        ///         private  - csak a kapcsos zárójelek {} között érvényes   - csak kódblokk
        ///         internap - az adott assemblyből (projektből) 
        ///         public   - publikus..     -- mindenhonnan elérhető
        /// 
        /// static: mivel static-ból hívjuk, ezért static-nak kell lennie
        /// 
        /// void: nincs visszatérési érték a függvényből
        /// 
        /// </summary>
        private static void PorkoltReceptKiiratasa()
        {
            Console.WriteLine("Marhahús");
            Console.WriteLine("Vöröshagyma");
            Console.WriteLine("Olaj");
            Console.WriteLine("Piros paprika");
        }
    }
}
