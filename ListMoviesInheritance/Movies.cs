using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMoviesInheritance
{
    abstract internal class Movies
    {
        String title;
        int year;
        List<String> castMembers = new List<String>();

        public Movies(String title, int year)
        {
            this.title = title;
            this.year = year;
        }

        public void AddCastMember(string castMemberName)
        {
            castMembers.Add(castMemberName);
            Console.WriteLine("New cast member added.");
        }

        public void DisplayCastMembers()
        {
            foreach (String castMember in castMembers)
            {
                Console.WriteLine(castMember);
            }
        }
    }

    class ComedyMovies : Movies
    {
        public ComedyMovies(String title, int year) : base(title, year)
        {
        }

        public String genre = "Comedy";
    }

    class DramaMovies : Movies
    {
        public DramaMovies(String title, int year) : base(title, year)
        {
        }

        public String genre = "Drama";
    }

    class HorrorMovies : Movies
    {
        public HorrorMovies(String title, int year) : base(title, year)
        {
        }

        public String genre = "Horror";
    }

    class FamilyMovies : Movies
    {
        public FamilyMovies(String title, int year) : base(title, year)
        {
        }

        public String genre = "Family";
    }
}