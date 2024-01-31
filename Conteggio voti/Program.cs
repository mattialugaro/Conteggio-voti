using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Conteggio_voti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opzione1 = 0;
            int opzione2 = 0;
            int opzione3 = 0;

            int scelta = 0;

            while(scelta != 4)
            {
                Console.WriteLine("Scegli un' opzione:");
                Console.WriteLine("1. Opzione 1");
                Console.WriteLine("2. Opzione 2");
                Console.WriteLine("3. Opzione 3");
                Console.WriteLine("4. Opzione 4: Fine test.");
                Console.WriteLine("La tua scelta e' stata: ");
                scelta = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("\n");
                switch (scelta)
                {
                    case 1: opzione1++;
                        break;
                    case 2: opzione2++;
                        break;
                    case 3: opzione3++;
                        break;
                    case 4: Console.WriteLine("Fine test. \n");
                        break;
                    default: Console.WriteLine("Opzione non valida, Riprova. \n");
                        break;
                }

            }
            Console.WriteLine("risposta 1: " + opzione1);
            Console.WriteLine("risposta 2: " + opzione2);
            Console.WriteLine("risposta 3: " + opzione3);
            Console.ReadLine();

        }
    }
}
