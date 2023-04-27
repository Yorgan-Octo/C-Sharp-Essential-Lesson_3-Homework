using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Vehicle
    {

        protected string modelName;
        protected double speed;
        protected double price;
        protected double graduationYear;

        //це якщо використовувати схему с викликом базового конструктора

        //public Vehicle(string modelName, double speed, double price, double graduationYear)
        //{
        //    this.modelName = modelName;
        //    this.speed = speed;
        //    this.price = price;
        //    this.graduationYear = graduationYear;
        //}


        public virtual void ShowInfo()
        {
            Console.WriteLine(new String('=',50));
            Console.WriteLine($"Модель: {modelName}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($"Скорость: {speed} км\\ч");
            Console.WriteLine($"Год выпуска: {graduationYear} р.");
            Console.WriteLine($"Цена: {price} грн");
            Console.WriteLine(new String('=', 50));

        }

    }
}
