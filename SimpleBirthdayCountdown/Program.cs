using System;

namespace SimpleBirthdayCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What month is your birthday? (Enter a number between 01 and 12)");
            int birthMonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What day is your birthday? (Enter a number between 01 and 31)");
            int birthDay = Convert.ToInt32(Console.ReadLine());

            //Format users birthday and today's date 
            DateTime userBirthday = new DateTime(DateTime.Today.Year, birthMonth, birthDay);
            DateTime today = DateTime.Today; 

            //Calculate days and time until the user's birthday
            int daysUntilBirthday = (userBirthday - today).Days;

            //Display message based on days until user's birthday
            if(daysUntilBirthday < 0)
            {
                Console.WriteLine("Your birthday already passed. Happy belated birthday!");
            } else if (daysUntilBirthday == 0)
            {
                Console.WriteLine("Oh wow, your birthday is today! Happy birthday!");
            } else if (daysUntilBirthday > 0)
            {
                Console.WriteLine($"{daysUntilBirthday} day(s) until your birthday!");
            }
            
        }
    }
}
