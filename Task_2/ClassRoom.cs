using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ClassRoom
    {

        Pupil[] pupils;


        public ClassRoom(Pupil[] pupils)
        {
            this.pupils = pupils;
        }


        public void ShowInfoClassRoom()
        {
            Console.WriteLine("Табель успеваимсоти класа: ");
            foreach (var item in pupils)
            {
                Console.WriteLine(new String('=',50));
                Console.WriteLine($"Учень: {item.Name} {item.LastName}");
                Console.WriteLine(new String('-', 50));
                item.Study();
                item.Write();
                item.Read();
                item.Relax();
                Console.WriteLine(new String('=', 50));
            }
        }


    }
}
