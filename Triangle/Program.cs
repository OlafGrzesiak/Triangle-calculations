using System;
using System.Globalization;
using System.Net.NetworkInformation;


namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            


            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double sideC = double.Parse(Console.ReadLine());


            double circuit = Math.Round(sideA + sideB + sideC);
            double area = Math.Sqrt(circuit / 2 * (circuit / 2 - sideA) * (circuit / 2 - sideB) * (circuit / 2 - sideC)); //triangle area pattern
            double pitG = Math.Pow(sideA, 2) + Math.Pow(sideB, 2); // pitagoras 


            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Incorrect data. Side lengths must be positive!");
                
            }


            if (sideA + sideB < sideC)
            {
                Console.WriteLine("Incorrect data. The triangle cannot be built!");
               
            }

            if (circuit > 0)
            {
                Console.WriteLine("circuit = {0:N2}", circuit);
            }


            if (area >= 0)
            {
                Console.WriteLine("area = {0:N2}", area);
            }

            if (pitG == Math.Pow(sideC, 2))
            {
                Console.WriteLine("The triangle is rectangular");
            }

            if (pitG < Math.Pow(sideC, 2))
            {
                Console.WriteLine("The triangle is obtuse");
            }


            if (pitG > Math.Pow(sideC, 2))
            {
                Console.WriteLine("The triangle is acute");
            }


            if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                if (sideA == sideB && sideB == sideC)
                {
                    Console.WriteLine("Equilateral triangle");
                }
                else
                    Console.WriteLine("Isosceles triangle");
            }

            Console.ReadKey();






        }
    }

}
