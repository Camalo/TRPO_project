using System;

namespace Project1
{

    class Program
    {
        static void Main(string[] args)
        {
          
            B solution = new B();
            //1, 0, -16
            //float[] actual = 
            float[] actual = solution.SolveEquation(0, 0, 0);
            if (Double.IsNaN(actual[0])) Console.WriteLine("Решения нет");

            Console.WriteLine($"Уравнение 1: факт {actual[0]}");
            ////4, -6, 0
            //actual = solution.SolveEquation(4, -6, 0);
            //Console.WriteLine($"Уравнение 1: ожидалось 1.5, 0 ; факт {actual[0]},{actual[1]}");

            ////1, -6, 9
            //actual = solution.SolveEquation(1, -6, 9);
            //Console.WriteLine($"Уравнение 1: ожидалось 3 ; факт {actual[0]}");
        }
    }
}
