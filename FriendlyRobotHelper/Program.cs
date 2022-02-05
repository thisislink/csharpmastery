using System;

namespace FriendlyRobotHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot.IntroduceYourself();
            string getName = Console.ReadLine();
            Robot.SayGoodMorning(getName);
            Robot.CleanKitchen();
            Robot.MakeDinner();
        }
    }
}
