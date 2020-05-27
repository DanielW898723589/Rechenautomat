using Rechner.Core;
using System;

namespace _18052020_rechenautomat
{
    class Program
    {
        static void Main(string[] args)
        {

            Rechenautomat dw = new Rechenautomat();

            string eingabe = "-";
            while (eingabe != "")
            {
                var nextRechnung = dw.NächsteBerechnung();

                Console.Write("Ladevorgang..." + nextRechnung + "-");

                int eingabe2 = Convert.ToInt32(Console.ReadLine());


                if (dw.Prüfe(eingabe2) == false)
                {
                    throw new Exception("Diese Lösung ist falsch!");
                }
            }

        }
    }
}
