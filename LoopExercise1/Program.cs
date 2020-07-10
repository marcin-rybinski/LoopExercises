using System;

namespace LoopExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną: ");
            var number = int.Parse(Console.ReadLine());
            //for (int i = number; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            while (number > 0)
            {
                Console.WriteLine(number);
                number--;
            }
        }
    }
}
