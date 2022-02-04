using System;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Let's gnerate a random number between 1 and a number of your choice. Enter a number:");
            int startingNumber = Convert.ToInt32(Console.ReadLine());

            int randomNumber = random.Next(1, startingNumber);
            Console.WriteLine($"Random Number: {randomNumber}");
        }
    }
}
