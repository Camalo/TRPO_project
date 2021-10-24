using System;

namespace Project1
{
    public class A 
    {
        //должен хранить любое количество корней (0, 1, 2)
        private float[] x;

        public float[] X { get => x; set => x = value; }

        public float[] SolveEquation(float a, float b)
        {

            if (a != 0 && b != 0)
            {
                X = new float[1];
                X[0] = -(b / a);
               
            } else if (a != 0)
            {
                X = new float[1];
                X[0] = 0;
                return X;

            } else {
                //Уравнения не существует, поэтому Х = NaN

                X = new float[1];
                X[0] = (float)Double.NaN;
            }

            return X;

        }

    }
}
