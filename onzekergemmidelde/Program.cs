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
            int geheelgetalen1, geheelgetal2,geheelgetal3, geheelgetal4, geheelgetal5 , aantalgetalen, gemiddelde;



            // VRAAG een aantal gehele getallen
            Console.WriteLine("geef een aantal gehele getallen!: ");
            geheelgetalen1 = int.Parse(Console.ReadLine());

            Console.WriteLine("geef een aantal gehele getallen!: ");
            geheelgetal2= int.Parse(Console.ReadLine());

            Console.WriteLine("geef een aantal gehele getallen!: ");
            geheelgetal3 = int.Parse(Console.ReadLine());

            Console.WriteLine("geef een aantal gehele getallen!: ");
            geheelgetal4 = int.Parse(Console.ReadLine());

            Console.WriteLine("geef een aantal gehele getallen!: ");
            geheelgetal5 = int.Parse(Console.ReadLine());



            //BEREKEN  GEMMIDDELDE(tel al de gegeven getallen op)
            gemiddelde = (geheelgetalen1 + geheelgetal2 + geheelgetal3 + geheelgetal4 + geheelgetal5) / 5;
            //(deel de opgetelde getallen door het aantal ingegeven getallen)
            //(resultaat mac 3 getal na de komma en min 1 na de komma)

            //TOON gemmidelde van ingegeven getallen max 3 na de komma min 1 na de komma
            Console.WriteLine(gemiddelde);
            //WACHTEN
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
