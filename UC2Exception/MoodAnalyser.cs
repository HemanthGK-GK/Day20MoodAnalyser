using System;
using System.Collections.Generic;
using System.Text;

namespace UC2Exception
{
    class MoodAnalyser
    {
        string message;

        
        public MoodAnalyser()
        {
        }

        
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

       
        public string AnalyseMood()
        {
            
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new CExcep(CExcep.ExceptionType.empty_message, "Mood should not be EMPTY");
                    throw new Exception();
                }
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e);
                throw new CExcep(CExcep.ExceptionType.null_message, "Mood Should not be NULL");
                throw new Exception(e.Message);
               
            }
        }
    }
}
