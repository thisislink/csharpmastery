using System;

namespace SimpleStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            ComedyMusical comedyMusical = new ComedyMusical();
            comedyMusical.movieTitle = "Pitch Perfect";
            comedyMusical.PlayStream(comedyMusical.movieTitle);

            DramaMusical dramaMusical = new DramaMusical();
            dramaMusical.movieTitle = "The Greatest Showman";
            dramaMusical.PlayStream(dramaMusical.movieTitle);
            dramaMusical.EnableFrenchSubtitles(dramaMusical.movieTitle);
            dramaMusical.DisableFrenchSubtitles(dramaMusical.movieTitle);

            FamilyKidsMusical familyKidsMusical = new FamilyKidsMusical();
            familyKidsMusical.movieTitle = "Encanto";
            familyKidsMusical.PlayStream(familyKidsMusical.movieTitle);
            familyKidsMusical.StopStream(familyKidsMusical.movieTitle);

            Console.ReadKey();
        }
    }
}
