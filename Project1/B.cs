using System;
namespace Project1
{
    public class B : A
    {
        private float discriminant;
        public float[] SolveEquation(float a , float b, float c)
        {
            if (a == 0)
            {
                X = base.SolveEquation(b, c);
                return X;
            }

            if (b == 0 && c < 0)
            {
                X = new float[2];
                X[0] = (float)Math.Sqrt(-c);
                X[1] = -X[0];

                return X;
            }
            else if(b == 0 && c == 0){
                X = new float[1];
                X[0] = 0;
                return X;
            }

            discriminant = GetDiscriminant(a, b, c);
           
            if(discriminant > 0)
            {
                X = new float[2];
                X[0] = (float)(-b + Math.Sqrt(discriminant)) / (2 * a);
                X[1] = (float)(-b - Math.Sqrt(discriminant)) / (2 * a);
                return X;
            }
            else if (discriminant == 0)
            {
                X = new float[1];
                X[0]=-(b/2*a);
                return X;
            }
            //В случаях когда дискриминант = 0 и (b == 0 && c > 0), корней нет, поэтому Х = NaN 
            X = new float[1];
            X[0] = (float)Double.NaN;

            return X;
        }
        protected float GetDiscriminant(float a,float b,float c)
        {

            return (float)(Math.Pow(b,2) - 4 * a * c);
        }

    }
}
