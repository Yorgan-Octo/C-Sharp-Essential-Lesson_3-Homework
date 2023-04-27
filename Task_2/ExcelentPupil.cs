using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class ExcelentPupil : Pupil
    {

        public ExcelentPupil(string name, string lastName) : base(name, lastName)
        {

        }

        public override void Study()
        {
            Console.WriteLine("- Ученик отлично учится");
        }
        public override void Read()
        {
            Console.WriteLine("- Ученик отлично читает");
        }
        public override void Write()
        {
            Console.WriteLine("- Ученик отлично пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("- Ученик отлично расслабляется");
        }

    }
}
