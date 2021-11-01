using System;
using System.Collections.Generic;

namespace Kamalova
{
    public class LinearEquation
    {
        //должен хранить любое количество корней (0, 1, 2)
        private List<float> x;

        public List<float> X { get => x; set => x = value; }

        public List<float> solve(float a, float b)
        {
            KamalovaLog logger = KamalovaLog.I();

            if (a != 0)
            {
                X = new List<float>();


                logger.log("Определено, что это линейное уравнение");


                if (b != 0)
                {
                    X.Add(-(b / a));
                    return X;
                }

                X.Add(0);

                return X;


            }
            else
            {
                //Уравнения не существует, поэтому Х = NaN
                throw new KamalovaException("Определено, что такое уравнение не существует");
                
            }


        }

    }
}
