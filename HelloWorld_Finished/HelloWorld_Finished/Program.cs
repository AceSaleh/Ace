using System;

namespace HelloWorld_Finished
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}