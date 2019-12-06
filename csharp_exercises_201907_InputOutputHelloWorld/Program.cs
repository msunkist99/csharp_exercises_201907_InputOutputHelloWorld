using System;

namespace csharp_exercises_201907_InputOutputHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name - ");

            string input;
            input = Console.ReadLine();
            Console.WriteLine("Hello " + input);

            /*
            string input = Console.ReadLine();
            Console.WriteLine("Hello " + input);
            */

            //Console.WriteLine("Hello " + Console.ReadLine());

            Console.ReadLine();
        }
    }
}
