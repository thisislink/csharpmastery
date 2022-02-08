using System;
using ListMoviesInheritance;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool createMovies = true;
            String newCastMember = "";
            String addNewCastMember = "";

            AppIntroduction();

            Console.WriteLine("What is the title of your movie?");
            String movieTitle = Console.ReadLine();

            Console.WriteLine("What year will the movie be released?");
            int releaseYear = Convert.ToInt32(Console.ReadLine());
            ComedyMovies comedyMovie = new ComedyMovies(movieTitle, releaseYear);
            DramaMovies dramaMovie = new DramaMovies(movieTitle, releaseYear);
            HorrorMovies horrorMovie = new HorrorMovies(movieTitle, releaseYear);
            FamilyMovies familyMovie = new FamilyMovies(movieTitle, releaseYear);

            Console.WriteLine("Choose a genre for your movie:");
            DisplayMovieGenres();
            int genreSelected = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add a new cast member in your movie:");
            newCastMember = Console.ReadLine();

            if (genreSelected == 1)
            {
                comedyMovie.AddCastMember(newCastMember);
                AddCastMembers(addNewCastMember, createMovies, newCastMember, movieTitle, releaseYear, genreSelected, comedyMovie, dramaMovie, horrorMovie, familyMovie);

            }
            else if (genreSelected == 2)
            {
                dramaMovie.AddCastMember(newCastMember);
                AddCastMembers(addNewCastMember, createMovies, newCastMember, movieTitle, releaseYear, genreSelected, comedyMovie, dramaMovie, horrorMovie, familyMovie);

            }
            else if (genreSelected == 3)
            {
                horrorMovie.AddCastMember(newCastMember);
                AddCastMembers(addNewCastMember, createMovies, newCastMember, movieTitle, releaseYear, genreSelected, comedyMovie, dramaMovie, horrorMovie, familyMovie);

            }
            else if (genreSelected == 4)
            {
                familyMovie.AddCastMember(newCastMember);
                AddCastMembers(addNewCastMember, createMovies, newCastMember, movieTitle, releaseYear, genreSelected, comedyMovie, dramaMovie, horrorMovie, familyMovie);
            }
            Console.ReadKey();
        }

        public static void AppIntroduction()
        {
            Console.WriteLine("You're creating a movie and it is your job to come up with the movie titles, the year of release, and cast people to be in the movie you make.");
        }
        public static void DisplayMovieGenres()
        {
            Console.WriteLine("Type the corresponding number to select a genre:\n" +
                "1. Comedy\n" +
                "2. Drama\n" +
                "3. Horror\n" +
                "4. Family");
        }

        public static void AddCastMembers(String addNewCastMember, bool createMovies, String newCastMember, String movieTitle, int releaseYear, int genreSelected, ComedyMovies comedyMovies, DramaMovies dramaMovies, HorrorMovies horrorMovies, FamilyMovies familyMovies)
        {
            ComedyMovies comedyMovie = comedyMovies;
            DramaMovies dramaMovie = dramaMovies;
            HorrorMovies horrorMovie = horrorMovies;
            FamilyMovies familyMovie = familyMovies;

            while (createMovies)
            {
                Console.WriteLine("Would you like to add another cast member? Type Y for yes or N for no.");
                addNewCastMember = Console.ReadLine().ToUpper();

                switch (addNewCastMember)
                {
                    case "Y":
                        Console.WriteLine("Add another cast member:");
                        newCastMember = Console.ReadLine();
                        if (genreSelected == 1)
                        {
                            comedyMovie.AddCastMember(newCastMember);
                        }
                        else if (genreSelected == 2)
                        {
                            dramaMovie.AddCastMember(newCastMember);
                        }
                        else if (genreSelected == 3)
                        {
                            horrorMovie.AddCastMember(newCastMember);
                        }
                        else if (genreSelected == 4)
                        {
                            familyMovie.AddCastMember(newCastMember);
                        }
                        break;
                    case "N":
                        createMovies = false;
                        if (genreSelected == 1)
                        {
                            Console.WriteLine($"Your movie \"{movieTitle}\" is a {comedyMovie.genre} movie and will be released in {releaseYear}.");
                            Console.WriteLine("Here's the people who are cast in your movie:");
                            comedyMovie.DisplayCastMembers();
                        }
                        else if (genreSelected == 2)
                        {
                            Console.WriteLine($"Your movie \"{movieTitle}\" is a {dramaMovie.genre} movie and  will be released in {releaseYear}.");
                            Console.WriteLine("Here's the people who are cast in your movie:");
                            dramaMovie.DisplayCastMembers();
                        }
                        else if (genreSelected == 3)
                        {
                            Console.WriteLine($"Your movie \"{movieTitle}\" is a {horrorMovie.genre} movie and will be released in {releaseYear}.");
                            Console.WriteLine("Here's the people who are cast in your movie:");
                            horrorMovie.DisplayCastMembers();
                        }
                        else if (genreSelected == 4)
                        {
                            Console.WriteLine($"Your movie \"{movieTitle}\" is a {familyMovie.genre} movie and will be released in {releaseYear}.");
                            Console.WriteLine("Here's the people who are cast in your movie:");
                            horrorMovie.DisplayCastMembers();
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid entry. Try again.");
                        break;
                }
            }
        }
    }
}