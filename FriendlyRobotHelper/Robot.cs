using System;
using System.Collections.Generic;
using System.Text;

namespace FriendlyRobotHelper
{
    static class Robot
    {
        public static void IntroduceYourself()
        {
            Console.WriteLine("Hello, I am Robot1111. You can call me Robi for short. What is your name?");
        }

        public static void SayGoodMorning(string name)
        {
            Console.WriteLine($"Good morning, {name}!");
        }

        public static void CleanKitchen()
        {
            Console.WriteLine("I am cleaning the kitchen.");
        }

        public static void Dust()
        {
            Console.WriteLine("I am dusting the entire house.");
        }

        public static void MakeBreakfast()
        {
            Console.WriteLine("I am making breakfast");
        }

        public static void MakeLunch()
        {
            Console.WriteLine("I am making lunch.");
        }

        public static void MakeDinner()
        {
            Console.WriteLine("I am making dinner");
        }
    }
}
