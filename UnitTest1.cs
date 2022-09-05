namespace MoodAnaylserUC2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnaylser2()
        {
            string meassage = "I am in Sad Mood";
            MoodAnasyle moodAnalyzer = new MoodAnasyle(meassage);
            string ExpectedOutput = "SAD";

            string result = moodAnalyzer.AnalyseMood();

            Assert.AreEqual(result, ExpectedOutput);
        }
    }
}