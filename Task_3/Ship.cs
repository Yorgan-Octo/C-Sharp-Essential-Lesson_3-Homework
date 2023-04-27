using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Ship : Vehicle
    {
        private int numberOfPassengers;
        private string homePort;

        public Ship(string modelName, double speed, double price, double graduationYear, int numberOfPassengers, string homePort)
        {
            this.modelName = modelName;
            this.speed = speed;
            this.price = price;
            this.graduationYear = graduationYear;
            this.homePort = homePort;
            this.numberOfPassengers = numberOfPassengers;

        }

        public override void ShowInfo()
        {

            Console.WriteLine(new String('=', 50));
            Console.WriteLine($" Назва: {modelName}");
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($" Порт прописки: {homePort}");
            Console.WriteLine($" Скорость: {speed} узлов");
            Console.WriteLine($" Количество пасажиров: {numberOfPassengers} человек");
            Console.WriteLine($" Год выпуска: {graduationYear} р");
            Console.WriteLine($" Цена: {price} грн");
            Console.WriteLine(new String('=', 50));

        }

    }
}
