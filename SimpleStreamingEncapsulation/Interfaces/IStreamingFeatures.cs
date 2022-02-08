using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStreaming.Interfaces
{
    interface IStreamingFeatures
    {
        void PlayStream(String title);
        void PauseStream(String title);
        void StopStream(String title);
        void SkipAhead(String title);
        void ReverseStream(String title);
    }
}