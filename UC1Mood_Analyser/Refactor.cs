using System;
using System.Collections.Generic;
using System.Text;

namespace UC1Mood_Analyser
{
    public class Refactor
     {
        string message;

        public Refactor()
        {

        }
         public Refactor(string msg)
        {
            this.message = msg;

        }
        public string Analyse()
        {

            if (this.message.Contains("I am in Sad Mood"))
                return "SAD";
            else
                return "HAPPY";

        }
    }
}
