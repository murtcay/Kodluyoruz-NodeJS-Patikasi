using System;

namespace console_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Helo, " + name + " " + lastname);
        }
    }
}
