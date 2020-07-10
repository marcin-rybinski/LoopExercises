using System;

namespace LoopExercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 193;
            int counter = 0;
            for (int i = number; i >= 1; i--)
            {
                
                int result = number % i;
                if (result == 0) counter++;
            }
            if (counter == 2) Console.WriteLine("Liczba pierwsza!");
            else Console.WriteLine("To nie jest liczba pierwsza.");
        }
    }
}
