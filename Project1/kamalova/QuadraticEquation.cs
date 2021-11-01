using System;
using System.Collections.Generic;
using core;
namespace Kamalova
{
    public class QuadraticEquation : LinearEquation, EquationInterface
    {
        private float discriminant;
        public List<float> solve(float a, float b, float c)
        {
            KamalovaLog logger = KamalovaLog.I();

            if (a == 0)
            {
                X = base.solve(b, c);
                return X;
            }
            else
            {
                logger.log("Определено, что это квадратное уравнение");
            }

            if (b == 0 && c < 0)
            {
                X = new List<float>();

                X.Add((float)Math.Sqrt(-c));
                X.Add(-X[0]);
                

                return X;
            }
            else if (b == 0 && c == 0)
            {
                X = new List<float>();
                X.Add(0);
                

                return X;
            }

            discriminant = GetDiscriminant(a, b, c);

            if (discriminant > 0)
            {
                X = new List<float>();
                X.Add((float)(-b + Math.Sqrt(discriminant)) / (2 * a));
                X.Add((float)(-b - Math.Sqrt(discriminant)) / (2 * a));
                

                return X;
            }
            else if (discriminant == 0)
            {
                X = new List<float>();
                X.Add(-(b / 2 * a));
               

                return X;
            }
            //В случаях когда дискриминант = 0 и (b == 0 && c > 0), корней нет, поэтому Х = NaN 
            throw new KamalovaException("Ошибка: уравнение не имеет решений");
          
        }
        protected float GetDiscriminant(float a, float b, float c)
        {

            return (float)(Math.Pow(b, 2) - 4 * a * c);
        }

    }
}
