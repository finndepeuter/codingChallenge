using CodingChallengeLibrary;

namespace CombinationTest
{
    [TestClass]
    public class CombinationTest
    {
        [TestMethod]
        public void Test_CombineTwoWordsTimesTwo_Returns4()
        {
            // ARRANGE
            Combination combination = new Combination();
            string[] words = { "zambia", "appeal" };
            string[] components = { "zam", "bia", "za", "mbia", "appe", "al", "appea", "l" };
            // ACT
            List<string> combinations =  combination.FindCombinationTwoParts(words, components);
            // ASSERT
            Assert.AreEqual(4, combinations.Count);

        }

        [TestMethod]
        public void Test_Combine3Parts_Returns1CorrectMatch()
        {
            Combination combination = new Combination();
            string[] words = { "zambia"};
            string[] components = { "zam", "bia", "za", "mb", "ia"};
            // ACT
            List<string> combinations = combination.FindCombinationMultipleParts(words, components, 3);
            // ASSERT
            Assert.AreEqual(1, combinations.Count);
        }
    }
}