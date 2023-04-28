using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //тут неявний апкаст
            Pupil[] pupils =
            {
                new GoodPupil("Artem", "Pridchenco"),
                new ExcelentPupil("Lina", "Biko"),
                new ExcelentPupil("Vas", "Laco"),
                new GoodPupil("Lona", "Sinto"),
            };

            ClassRoom classRoom = new ClassRoom(pupils);

            classRoom.ShowInfoClassRoom();

            Console.ReadKey();

        }
    }
}
