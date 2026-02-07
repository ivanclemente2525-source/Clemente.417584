using System;

namespace MathApp
{
    class MathProgram
    {

        static void Main(string[] args)
        {
            double num1 = 9.21;
            double num2 = 11.0;
            double baseNum = 2.0;
            double exponent = 3.0;

            Console.WriteLine("The Absolute value of " + num2 + " is " + Math.Abs(num2));
            Console.WriteLine("The Higher value between " + num1 + " and 10 is " + Math.Max(num1, 10));
            Console.WriteLine(baseNum + " to the power of " + exponent + " is " +Math.Pow(baseNum, exponent));
            Console.WriteLine("The square root of 150 is " + Math.Sqrt(150));
            Console.WriteLine("The celling value of " + num1 + " is " + Math.Ceiling(num1));

            Console.WriteLine("\nPress any key to exit. . .");
            Console.ReadKey();



        }   
    }
}
