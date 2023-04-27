using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Pupil
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Pupil(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public virtual void Study()
        {
            Console.WriteLine("- Ученик учится");
        }
        public virtual void Read()
        {
            Console.WriteLine("- Ученик читает");
        }
        public virtual void Write()
        {
            Console.WriteLine("- Ученик пишет");
        }
        public virtual void Relax()
        {
            Console.WriteLine("- Ученик расслабляется");
        }



    }
}
