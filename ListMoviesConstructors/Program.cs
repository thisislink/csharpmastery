using System;
using ListMoviesConstructors;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool createMovies = true;
            Console.WriteLine("You're creating indie movies and it is your job to come up with the movie titles, the year of release, and cast people to be in the movies you make.");
            Console.WriteLine("What is the title of your movie?");
            String movieTitle = Console.ReadLine();

            Console.WriteLine("What year will the movie be released?");
            int releaseYear = Convert.ToInt32(Console.ReadLine());

            Movies movie = new Movies(movieTitle, releaseYear);

            Console.WriteLine("Who would you like to add as a new cast member in your movie?");
            String newCastMember = Console.ReadLine();
            movie.AddCastMember(newCastMember);

            while (createMovies)
            {
                Console.WriteLine("Would you like to add another cast member? Type Y for yes or N for no.");
                String addNewCastMember = Console.ReadLine().ToUpper();
                switch (addNewCastMember)
                {
                    case "Y":
                        Console.WriteLine("Who would you like to add as a new cast member in your movie?");
                        newCastMember = Console.ReadLine();
                        movie.AddCastMember(newCastMember);
                        break;
                    case "N":
                        Console.WriteLine($"Your movie \"{movieTitle}\" will be released in {releaseYear}.");
                        Console.WriteLine("Here's the people who are cast in your movie:");
                        movie.DisplayCastMembers();
                        createMovies = false;
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try again.");
                        break;
                }
            }
            
            Console.ReadKey();
        }
    }
}