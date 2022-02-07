using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStreaming.Interfaces
{
    interface ILanguageFeatures
    {
        public void EnableFrenchSubtitles(String title);
        public void DisableFrenchSubtitles(String title);
    }
}
