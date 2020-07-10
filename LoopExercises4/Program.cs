using System;

namespace LoopExercises4
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = 7;
            var secondNumber = 8;
            var result = 0;
            for (int i = 0; i < firstNumber; i++)
            {
                result += secondNumber;
            }

            Console.WriteLine(result);
        }
    }
}
