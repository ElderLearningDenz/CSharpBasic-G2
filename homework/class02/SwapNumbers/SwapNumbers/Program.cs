using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int specialSwapper;

            Console.WriteLine("Hello human, please enter value:");
            numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine($"Variable numberOne has been assigned with: {numberOne}");
            numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Variable numberTwo has been assigned with: {numberTwo}");
            specialSwapper = numberOne;
            numberOne = numberTwo;
            numberTwo = specialSwapper;
            Console.WriteLine($"After the MAGIC swap numberOne is {numberOne}, and numberTwo became {numberTwo}");
        }
    }
}
