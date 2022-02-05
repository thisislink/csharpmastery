using System;

namespace ListMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] movies = { "Toy Story 3", "Terminator 2", "The Matrix" };
            Console.WriteLine("Movies:");
            for(int movie = 0; movie < movies.Length; movie++)
            {
                Console.WriteLine(movies[movie]);
            }
        }
    }
}
