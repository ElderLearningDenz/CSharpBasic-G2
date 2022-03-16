using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numA;
            int numB;
            int numC;
            int numD;
            int avgNum;

           
            Console.WriteLine("Please enter value for value One:");
            numA = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for value Two:");
            numB = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for value Three:");
            numC = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter value for value Four:");
            numD = int.Parse(Console.ReadLine());

            if (numA <= 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
                return;
            }
            else if (numB <= 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
                return;
            }
            else if (numC <= 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
                return;
            }
            else if (numD <= 0)
            {
                Console.WriteLine("Error! Cannot calculate average of 0");
                return;
            }

            avgNum = (numA + numB + numC + numD) / 4;

            Console.WriteLine($"The average from numbers {numA}, {numB}, {numC}, {numD} is: {avgNum}");
        }
    }
}
