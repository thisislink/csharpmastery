using System;

namespace SimpleStreaming
{
    class Program
    {
        static void Main(string[] args)
        {
            ComedyMusical comedyMusical = new ComedyMusical("Pitch Perfect");         
            comedyMusical.PlayStream(comedyMusical.MovieTitle);

            DramaMusical dramaMusical = new DramaMusical("The Greatest Showman");
            String dramaTitle = dramaMusical.MovieTitle;
            dramaMusical.PlayStream(dramaTitle);
            dramaMusical.EnableFrenchSubtitles(dramaTitle);
            dramaMusical.DisableFrenchSubtitles(dramaTitle);

            FamilyKidsMusical familyKidsMusical = new FamilyKidsMusical("Encanto");
            String familyTitle = familyKidsMusical.MovieTitle;
            familyKidsMusical.PlayStream(familyTitle);
            familyKidsMusical.StopStream(familyTitle);

            Console.ReadKey();
        }
    }
}