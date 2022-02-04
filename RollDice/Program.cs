using System;

namespace RollDice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            
            while(play == true)
            {
                Console.WriteLine("Would you like to roll the dice? Enter Y for yes or N for no.");
                string rollAgain = Console.ReadLine();

                switch (rollAgain.ToUpper())
                {
                    case "Y":
                        
                        Random random = new Random();
                        int diceRoll = random.Next(1, 6);
                        Console.WriteLine($"You rolled: {diceRoll}");
                        break;
                    case "N":
                        Console.WriteLine("Thank you for playing. See you next time.");
                        play = false;
                        break;
                    default: Console.WriteLine("Invalid entry.");
                        break;
                }
            }           
        }
    }
}
