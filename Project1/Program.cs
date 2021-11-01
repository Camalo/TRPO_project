using System;
using System.Collections.Generic;
using core;
using Kamalova;
namespace Project1
{

    class Program
    {
        static void Main(string[] args)
        {
            KamalovaLog logger = new KamalovaLog();

            Console.WriteLine("Введите 3 параметра a, b и с");

            float.TryParse(Console.ReadLine(), out float a);
            float.TryParse(Console.ReadLine(), out float b);
            float.TryParse(Console.ReadLine(), out float c);

            logger.log($"Введено уравнение {a}X^2 + ({b})X + ({c}) = 0");

            List<float> solution = new List<float>();

            QuadraticEquation equation = new QuadraticEquation();
            try
            {
                solution = equation.solve(a, b, c);

            }catch(KamalovaException ex)
            {
                logger.log(ex.Message);
               
            }
           

            if (solution.Count > 0)
            {
                logger.log($"Корни уравнения: {solution[0]}");
              
                if (solution.Count == 2)
                {
                    logger.log(", " + solution[1]);
                 
                }
            }
            logger.write();


        }
    }
}
