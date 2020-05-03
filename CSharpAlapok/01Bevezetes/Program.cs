using System;

namespace _01Bevezetes
{
    //                        NETACADEMIA  -  Programozási alapismeretek C# nyelven (classic)


    //    Program(C#)  ->  IL (Intermediate Language = Köztes nyelv)

    //                      \ IL /      (.exe)
    //                      ------
    //                      |.NET|    (fordito)                      |.NET|                 |.NET|
    //                      ------                                   ------                ------- 
    //                      WINDOWS   (op.rendszer)                  LINUX                 Mac. OS           Android         iOS



    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hali! - (Write)\n");
            Console.WriteLine("Sziasztok, Itt vagyunk  - (WriteLine - új sort kezd)");
            Console.WriteLine("Sziasztok, Itt vagyunk  - (WriteLine - új sort kezd)");
            Console.ReadLine();   // ez fogja meg a console-t.    Bekér egy sortörést


        }
    }
}
