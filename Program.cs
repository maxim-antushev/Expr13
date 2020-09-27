using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер стороны забора");
            double side = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину веревки");
            double ropeLenght = int.Parse(Console.ReadLine());
            double height = ropeLenght - side / 2;
            double angle = 2 * Math.Acos(1 - height / ropeLenght);
            if (side >= 2 * ropeLenght)
                Console.WriteLine(ropeLenght * ropeLenght * Math.PI);
            else
                Console.WriteLine((ropeLenght * ropeLenght * Math.PI) - 4 * (ropeLenght * ropeLenght / 2 * (angle - Math.Sin(angle))));
        }
    }
}