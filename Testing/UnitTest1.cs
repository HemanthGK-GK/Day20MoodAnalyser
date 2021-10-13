using Microsoft.VisualStudio.TestTools.UnitTesting;
using UC1Mood_Analyser;

using UC1Mood_Analyser;
namespace UC1Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HappyMood()
        {
            //Arrangement 
            Analyser obj = new UC1Mood_Analyser.Analyser();
            string expected = "HAPPY";

            //Act
            string actual = obj.AnalyseMood("I am in Any Mood");

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void SadMood()
        {
            //Arrangement 
            Analyser obj = new UC1Mood_Analyser.Analyser();
            string expected ="SAD";

            //Act
            string actual = obj.AnalyseMood("I am in Sad Mood");

            //Assert
            Assert.AreEqual(expected, actual);

        }

        //Refactor-TC 1.1
        [TestMethod]  
        public void Sad()
        {
            Refactor obj = new Refactor("I am in Sad Mood");
            string message = "SAD";
  
            string result = obj.Analyse();

            Assert.AreEqual(message, result);
        }

        //Refactor-TC 1.2
        [TestMethod] 
        public void Happy()
        { 
            Refactor obj = new Refactor();
            string message = "HAPPY";

            string result = obj.Analyse();
 
            Assert.AreEqual(message, result);
        }

        [TestMethod]
         
        public void Giving_NullMood_Expecting_Exception_Results()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "Object reference not set to an instance of an object.";

            try
            {
                
                string actualMsg = mood.AnalyseMood();
            }

            catch (NullReferenceException ex)
            {
               
                Assert.AreEqual(expected, ex.Message);
            }

        }

        //TC 2.1
        [TestMethod]
        
        public void Null_Happy()
        {
            MoodAnalyser obj = new MoodAnalyser("null");
            string expected = "HAPPY";

            string actualMsg = obj.AnalyseMood();

            Assert.AreEqual(expected, actualMsg);

        }

        //TC 3.1
        [TestMethod]
       
        public void NullMood_CustomException()
        {
            MoodAnalyser obj = new MoodAnalyser(null);
            string expected = "Mood should not be NULL";

            try
            {
                string actualMsg = obj.AnalyseMood();
            }

            catch (CExcep ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }


        }

        //TC 3.2
        [TestMethod]
        
        public void EmptyMood_CustomException()
        {
            MoodAnalyser obj = new MoodAnalyser("");
            string expected = "Mood should not be EMPTY";

            try
            {
                string actualMsg = obj.AnalyseMood();
            }

            catch (CExcep ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }

        //TC 4.1
        [TestMethod]
        public void MoodAnalyseClassName()
        {
            string message = null;
            MoodAnalyser expected = new MoodAnalyser(message);

            object obj = MoodAnalyserFactory.CreateMoodAnalyser("Day20_MoodAnalyser_Test_Assignment.MoodAnalyser", "MoodAnalyser");
            
            Assert.AreNotEqual(expected, obj);
        }


        //TC 5.1
        [TestMethod]
        public void GivenMoodAnalyseClassName_ParameterizedConstructor()
        {
            
            object expected = new MoodAnalyser("HAPPY");

            try
            {
                object obj = MoodAnalyserFactory.CreateMoodAnalyseParameterizedConstructor("Day.MoodAnalyser", "MoodAnalyser", "SAD");
            }
            catch (Exception ex)
            {
                
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }

}
}
