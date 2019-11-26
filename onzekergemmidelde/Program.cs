//Enrick De Munter 5ITN nr3 onzekergemmidelde
/*Geef het gemmidelde van een aantal gehele getallen.
 * 
 * ANALYSE
 * =======
 * VRAAG    een aantal gehele getallen
 * 
 * BEREKEN  GEMMIDDELDE(tel al de gegeven getallen op)
 *                     (deel de opgetelde getallen door het aantal ingegeven getallen)
 *                     (resultaat mac 3 getal na de komma en min 1 na de komma)
 *                     
 *TOON gemmidelde van ingegeven getallen max 3 na de komma min 1 na de komma                     
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onzekergemmidelde
{
    class Program
    {
        static void Main(string[] args)
        {   //DECLARATIES
            int geheelgetal, aantalingevoerdegetal, gemiddelde;



            // VRAAG een aantal gehele getallen
            Console.WriteLine("geef een aantal gehele getallen!: ");
            geheelgetal = int.Parse(Console.ReadLine());

            Console.WriteLine("geef het aantal ingevulde getallen!:");
            aantalingevoerdegetal = int.Parse(Console.ReadLine());
            //BEREKEN  GEMMIDDELDE(tel al de gegeven getallen op)
            gemiddelde = 
            //(deel de opgetelde getallen door het aantal ingegeven getallen)
            //(resultaat mac 3 getal na de komma en min 1 na de komma)

            //TOON gemmidelde van ingegeven getallen max 3 na de komma min 1 na de komma

            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
