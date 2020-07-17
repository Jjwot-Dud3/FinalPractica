using System;

namespace DivisionLib
{
    public class Division
    {
        public static double DivisionMethod<T>(ref T a, ref T b)
        {
             double a1, a2;
            try
            {
                 a1 = Convert.ToDouble(a);
                 a2 =Convert.ToDouble(b);
            }
            catch (System.Exception)
            {
                a1 = 1;
                a2 =1 ;
                throw new System.Exception("Cannot divide by Incorrect");
            }
            
            double result =a1/a2;
            return  result;
        }
    }
}
