using System;
using System.Collections.Generic;
using System.Net.WebSockets;

namespace LoopExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            int[] fibnc = new int[number];
            fibnc[0] = 0;
            fibnc[1] = 1;
            for (int i = 2; i < number; i++)
            {
                fibnc[i] = fibnc[i - 2] + fibnc[i - 1];
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write($"{fibnc[i]}, ");
            }

            Console.WriteLine();
            foreach (var element in fibnc)
            {
                Console.Write($"{element}, ");
            }
        }
    }
}
