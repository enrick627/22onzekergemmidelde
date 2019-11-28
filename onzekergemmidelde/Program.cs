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
        {//declaraties
            string gevraagdegetallen;
            bool gevraagdegetalleninput;
            int geheleget, getalekes;
            int totget;
            string input;
            int aantal = 0;
            // VRAAG een aantal gehele getallen
            Console.WriteLine("geef een aantal gehelegetallen");
            gevraagdegetallen = Console.ReadLine();

            gevraagdegetalleninput = int.TryParse(gevraagdegetallen, out geheleget);
            while (geheleget >= -50000 && geheleget <= 50000)
            {
                aantal++;
                Console.WriteLine("geef nog een getal!: ");
                gevraagdegetallen = Console.ReadLine();

            }

            if (gevraagdegetalleninput == false)
            {
                Console.WriteLine("doe het opwnieuw het getal dat u ingaf is fout!: ");
                gevraagdegetalleninput = bool.Parse(Console.ReadLine());

            }
            if (gevraagdegetallen = 0)
            {
                totget = gevraagdegetallen / aantal;
                Console.Write(totget);
            }


            //BEREKEN  GEMMIDDELDE(tel al de gegeven getallen op)
            
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
