using System;

namespace LoopExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę naturalną: ");
            var number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0) sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
