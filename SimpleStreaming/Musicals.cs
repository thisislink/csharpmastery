using SimpleStreaming.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStreaming
{
    class Musicals
    {
        public String movieTitle;
        public int movieYear;
    }

    class ComedyMusical : Musicals, IStreamingFeatures
    {
        public void PlayStream(String title)
        {
            Console.WriteLine($"{title} is streaming.");
        }

        public void PauseStream(String title)
        {
            Console.WriteLine($"{title} is paused.");
        }
        public void StopStream(String title)
        {
            Console.WriteLine($"{title} is stopped.");
        }
        public void SkipAhead(String title)
        {
            Console.WriteLine($"{title} is fast forwarding.");
        }
        public void ReverseStream(String title)
        {
            Console.WriteLine($"{title} is reversing.");
        }
    }

    class DramaMusical : Musicals, IStreamingFeatures, ILanguageFeatures
    {
        public void PlayStream(String title)
        {
            Console.WriteLine($"{title} is streaming.");
        }

        public void PauseStream(String title)
        {
            Console.WriteLine($"{title} is paused.");
        }
        public void StopStream(String title)
        {
            Console.WriteLine($"{title} is stopped.");
        }
        public void SkipAhead(String title)
        {
            Console.WriteLine($"{title} is fast forwarding.");
        }
        public void ReverseStream(String title)
        {
            Console.WriteLine($"{title} is reversing.");
        }
        public void EnableFrenchSubtitles(String title)
        {
            Console.WriteLine($"French subtitles are on for {title}.");
        }
        public void DisableFrenchSubtitles(String title)
        {
            Console.WriteLine($"French subtitles are off for {title}.");
        }
    }

    class FamilyKidsMusical : Musicals, IStreamingFeatures
    {
        public void PlayStream(String title)
        {
            Console.WriteLine($"{title} is streaming.");
        }

        public void PauseStream(String title)
        {
            Console.WriteLine($"{title} is paused.");
        }
        public void StopStream(String title)
        {
            Console.WriteLine($"{title} is stopped.");
        }
        public void SkipAhead(String title)
        {
            Console.WriteLine($"{title} video is fast forwarding.");
        }
        public void ReverseStream(String title)
        {
            Console.WriteLine($"{title} is reversing.");
        }
    }
}
