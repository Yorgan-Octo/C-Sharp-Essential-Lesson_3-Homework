using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane cesna238 = new Plane("cesna238", 1230, 198000, 1967, 4000, 12);
            Саr ladaGrande = new Саr("Lada", 120, 78000, 1989);
            Ship yahta = new Ship("Viola lia", 344, 348888, 2004, 6, "Marine, Great Britain");

            cesna238.ShowInfo();
            ladaGrande.ShowInfo();
            yahta.ShowInfo();


            Console.ReadKey();
        }
    }
}
