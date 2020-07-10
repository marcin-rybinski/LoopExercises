using System;

namespace LoopExercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Console.ReadLine();
            if (int.TryParse(number, out int result) == false) return;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '1') Console.Write("one ");
                else if (number[i] == '2') Console.Write("two ");
                else if (number[i] == '3') Console.Write("three ");
                else if (number[i] == '4') Console.Write("four ");
                else if (number[i] == '5') Console.Write("five ");
                else if (number[i] == '6') Console.Write("six ");
                else if (number[i] == '7') Console.Write("seven ");
                else if (number[i] == '8') Console.Write("eight ");
                else if (number[i] == '9') Console.Write("nine ");
                else Console.Write("zero ");
                
                
                
                // possible solution example to expand functionality
                
                //if (number.Length - 3 >= 0)
                //{
                //    if (i == number.Length - 3) Console.Write("hundred ");
                //}
            }

        }
    }
}
