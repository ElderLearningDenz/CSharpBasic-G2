using System;

namespace RealCalculator
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to Real Calculator!");


            //Create variables
            int numOne;
            int numTwo;
            string oper;
            int result;


            // Enter values from input:
            Console.WriteLine("Please enter first number:");

            numOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Please select an opperand from given choice (+, -, /, *) ");

            oper = Console.ReadLine();

            Console.WriteLine("Please Enter second number:");

            numTwo = int.Parse(Console.ReadLine());


            //Check Validation
            if (numOne < 0)
            {
                Console.WriteLine("Please Enter Positive number!");
                return;
            }
            else if (numTwo < 0)
            {
                Console.WriteLine("Please Enter Positive Number");
                return;
            }
            else
            {
                Console.WriteLine("Please Enter valid operator");
            }
      

            //Check operator value
            switch (oper)
            {
                case "+":

                    {
                        result = numOne + numTwo;
                        Console.WriteLine($"The result from {numOne} {oper} {numTwo} is: {result}");
                    }
                    break;
                case "-":

                    {
                        result = numOne - numTwo;
                        Console.WriteLine($"The result from {numOne} {oper} {numTwo} is: {result}");
                    }
                    break;
                case "/" :

                    {
                        result = numOne / numTwo;
                        Console.WriteLine($"The result from {numOne} {oper} {numTwo} is: {result}");
                    }
                    break;
                case "*":

                    {
                        result = numOne * numTwo;
                        Console.WriteLine($"The result from {numOne} {oper} {numTwo} is: {result}");
                    }
                    break;

            }
     
        }
    }
}
