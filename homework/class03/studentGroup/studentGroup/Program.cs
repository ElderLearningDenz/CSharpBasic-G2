using System;

namespace studentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentGroupOne = { "Kratos", "Aloy", "Drake", "Ellie", "Jin" };
            string[] studentGroupTwo = { "Chief", "Markus", "Frank", "Senua", "Ori" };

            

            Console.WriteLine("Please enter a student group: (enter 1 or 2)");
            string showStudents = Console.ReadLine();
            int.TryParse(showStudents, out int printStudents);

            switch (printStudents)

            {
                case 1:
                    {
                        foreach (string student in studentGroupOne)
                        {
                            Console.WriteLine(student);
                        }
                        break;

                    }
                case 2:
                    {
                        foreach (string student in studentGroupTwo)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    }
            }
        }
    }
}
