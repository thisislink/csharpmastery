using System;

namespace Greeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name? (Type your name below and press the Enter key.)");
            String nameEntered = Console.ReadLine();
            Console.WriteLine($"Hello {nameEntered}!");
        }
    }
}
