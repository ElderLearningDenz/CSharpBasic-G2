using System;

namespace cSharpBasic1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("Blah, Blah");
            Console.WriteLine(23);
            Console.WriteLine("Hello people of Blah blah land! \nThis is in new line");
            /*Console.WriteLine("    *");
            Console.WriteLine("   ***");
            Console.WriteLine("  *****");
            Console.WriteLine(" *******");
            Console.WriteLine("*********");*/

            /*Console.WriteLine("     *\n    ***\n   *****\n  *******\n *********");

            Console.WriteLine("    *\n    *\n *  *  *\n*   *   *\n    *\n    *\n  *   *\n *     *");*/

            Console.WriteLine("Please write some text...");
            var inputText = Console.ReadLine();

            Console.WriteLine(inputText);

        }
    }
}
