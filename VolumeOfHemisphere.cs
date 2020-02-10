using System;

namespace VolumeHemisphere
{
    class Program
    {
        static void Main(string[] args)
        {

            double pI = Math.PI;

            double r;
            r = Convert.ToDouble(Console.ReadLine());

            if (r > 0)
            {
                r = Math.Pow(r , 3);
                double volume = (2 * (r * pI)) / 3;
                Console.WriteLine("The Volume is: " + volume);
            }

        }
    }
}
