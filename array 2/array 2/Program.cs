using System;

namespace array_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatur = { 4.5, 3.2, 6.7, 6.1, 2.1, 1.6, 2.9 };
            Console.WriteLine("Medeltemperatur:" + Math.Round(Medel(temperatur),2));
           
        }
         public static double Medel(double[] temperatur)
        {
            double summa = 0;
            for (int i = 0; i < temperatur.Length; i++)
                summa += temperatur[i];
            return (summa / temperatur.Length);
            

        }
    }
}
