using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Plane : Vehicle
    {
        private int maximumHeight;
        private int numberOfPassengers;

        //можно булоб викорастита і таку схему с викликом базоаого конструктора
        //але як намене коли треба запонити всі поля то так зручніше

        //public Plane(string modelName, double speed, double price, double graduationYear, int maximumHeight, int numberOfPassengers) 
        //    : base(modelName, speed, price, graduationYear)
        //{

        //    this.maximumHeight = maximumHeight;
        //    this.numberOfPassengers = numberOfPassengers;
        //}

        public Plane(string modelName, double speed, double price, double graduationYear, int maximumHeight, int numberOfPassengers) 
        {
            this.modelName = modelName;
            this.speed = speed;
            this.price = price;
            this.graduationYear = graduationYear;
            this.maximumHeight = maximumHeight;
            this.numberOfPassengers = numberOfPassengers;
        }

        public override void ShowInfo()
        {

            Console.WriteLine(new String('=', 50));
            Console.WriteLine($" Самолет: {modelName}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($" Скорость: {speed} км\\ч");
            Console.WriteLine($" Максимальная высота: {maximumHeight}");
            Console.WriteLine($" Количество пасажиров: {numberOfPassengers} человек");
            Console.WriteLine($" Год выпуска: {graduationYear} р");
            Console.WriteLine($" Цена: {price} грн");
            Console.WriteLine(new String('=', 50));

        }

    }
}
