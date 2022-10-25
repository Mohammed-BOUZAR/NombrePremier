using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombrePremier
{
    internal class Program
    {
        static bool prem;
        static void Main(string[] args)
        {
            string nbr = Console.ReadLine();

            if (Premier(nbr))
            {
                Console.WriteLine("Ce nombre est pemier");
            }
            else
            {
                Console.WriteLine("Ce nombre n'est pas pemier");
            }
            Console.Read();
        }
        static bool Premier(String nbr)
        {
            int a;

            if (int.TryParse(nbr, out a))
            {
                prem = true;
                a = int.Parse(nbr);
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                    {
                        prem = false;
                        break;
                    }
                }

            }
            return prem;
        }
    }
}
