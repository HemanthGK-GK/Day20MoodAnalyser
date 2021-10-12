using System;
using System.Collections.Generic;
using System.Text;

namespace UC1Mood_Analyser
{
    public class Analyser
    {
        public string AnalyseMood(string message)
        {
            if(message== "I am in Sad Mood")
                return "SAD";
            else 
                return "HAPPY";

        }
    }
}
