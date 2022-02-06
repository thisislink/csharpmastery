using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMoviesConstructors
{
    internal class Movies
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
            foreach(String castMember in castMembers)
            {
                Console.WriteLine(castMember);
            }
        }
    }
}
