using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Саr : Vehicle
    {

        public Саr(string modelName, double speed, double price, double graduationYear)
        {
            this.modelName = modelName;
            this.speed = speed;
            this.price = price;
            this.graduationYear = graduationYear;
        }


        //я  тут не переписував метод так як новых полів ми не додаем тому просто віклічу базовий метод 
        //public override void ShowInfo()
        //{

        //    Console.WriteLine(new String('=', 50));
        //    Console.WriteLine($" Машина: {modelName}");
        //    Console.WriteLine(new String('-', 50));
        //    Console.WriteLine($" Скорость: {speed} км\\ч");
        //    Console.WriteLine($" Цена: {graduationYear} р");
        //    Console.WriteLine($" Год выпуска: {price} грн");
        //    Console.WriteLine(new String('=', 50));

        //}


    }
}
