using System;

namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter 5 grades seperated by new line");

            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());
            double grade5 = Convert.ToDouble(Console.ReadLine());

            double avarege = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            double aroundavarage = Math.Round(avarege);

            Console.WriteLine(" The Total Average is " + avarege + " and around of " + aroundavarage);
            Console.WriteLine("Press any key to exit. . . ");
            Console.ReadKey();



        }

    }
}
