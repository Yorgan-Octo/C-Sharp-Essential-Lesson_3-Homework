using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class GoodPupil : Pupil
    {
        public GoodPupil(string name, string lastName) : base(name, lastName)
        {

        }

        public override void Study()
        {
            Console.WriteLine("- Ученик хорошо учится");
        }
        public override void Read()
        {
            Console.WriteLine("- Ученик хорошо читает");
        }
        public override void Write()
        {
            Console.WriteLine("- Ученик хорошо пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("- Ученик хорошо расслабляется");
        }

    }
}
