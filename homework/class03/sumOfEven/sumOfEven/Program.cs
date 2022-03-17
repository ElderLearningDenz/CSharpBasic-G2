using System;

namespace sumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sumOfEven = new int[6];

            
            for (int i = 0; i <6; i++)
            {
                Console.WriteLine($"Please Enter integer number {i+1}");
                string number = Console.ReadLine();
                int.TryParse(number, out int parsedNumber);
                sumOfEven[i] = parsedNumber;
                
                
            }

            int sum = 0;
            foreach (int num in sumOfEven)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                
            }
            Console.WriteLine($"The sum of the array sumOfEven is: {sum}.");

        }
    }
}
