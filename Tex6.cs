using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        enum week
        {
            lundi,
            mardi,
            mercredi,
            jeudi,
            vendredi,
            saemdi,
            dimanche
        }
        static void Main(string[] args)
        {
        // foreach (int i in Enum.GetValues(typeof(week)))
        foreach (string i in Enum.GetNames(typeof(week)))
        Console.WriteLine(i);
        }
    }
}
 /* Correction
 foreach (int i in Enum.GetValues(typeof(week))) ----> Permet d'afficher les valeurs indices de l'énumération 0,1,2,3...
 foreach (string i in Enum.GetNames(typeof(week))) // Permet d'afficher les constantes de l'énumération
            {
                Console.WriteLine(i);
            }
            week lu = week.lundi;
            week ma = week.mardi;
            week me = week.mercredi;
            Console.WriteLine(lu);
            Console.WriteLine(ma);
            Console.WriteLine(me); */
