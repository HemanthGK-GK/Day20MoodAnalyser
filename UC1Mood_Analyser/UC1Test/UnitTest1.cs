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

    }
}
