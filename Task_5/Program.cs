using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{

    public class Printer
    {
        public void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

    public class A : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }

    public class B : A
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {


            string text = "HelloWorld";

            Printer printer = new Printer();
            A a = new A();
            B b = new B();

            printer.Print(text);
            a.Print(text);
            b.Print(text);

            Console.WriteLine("-----------------------------");

            Printer printer1 = a;
            Printer printer2 = b;
            A a2 = b;

            printer1.Print(text);
            printer2.Print(text);
            a2.Print(text);

            Console.WriteLine("-----------------------------");

            A a3 = (A)printer1;
            B b3 = (B)printer2;
            B b4 = (B)a2;

            a3.Print(text);
            b3.Print(text);
            b4.Print(text);

          Console.ReadKey();
        }
    }
}
