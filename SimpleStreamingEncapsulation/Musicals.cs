using SimpleStreaming.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStreaming
{
    class Musicals
    {
        private String _movieTitle;

        public Musicals(String title)
        {
            _movieTitle = title;
        }

        public String MovieTitle
        {
            get { return _movieTitle; }
            set { _movieTitle = value; }
        }
    }

    class ComedyMusical : Musicals, IStreamingFeatures
    {
        public ComedyMusical(String title) : base(title) 
        {

        }
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
        public DramaMusical(String title) : base(title)
        {

        }
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
        public FamilyKidsMusical(String title) : base(title)
        {

        }
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