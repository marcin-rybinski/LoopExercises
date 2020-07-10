using System;

namespace LoopExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj jakąś liczbę: ");
            var number = double.Parse(Console.ReadLine());
            Console.WriteLine("Do której potęgi mam ją podnieść?: ");
            var power = int.Parse(Console.ReadLine());
            double result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }

            Console.WriteLine(result);
        }
    }
}
