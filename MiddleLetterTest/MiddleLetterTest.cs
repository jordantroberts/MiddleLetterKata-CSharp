using GettingMiddleLetters;
using NUnit.Framework;

namespace MiddleLetterTest
{
    public class MiddleLetterTest
    {

        [TestCase("test", "es")]
        [TestCase("tests", "s")]

        public void GivenEvenWord_ReturnsTwoLetters(string word, string expected)
        {
            MiddleLetter middleletter = new MiddleLetter();
            string actual = middleletter.GetMiddle(word);
            Assert.AreEqual(expected, actual);
        }

        public void GivenOddWord_ReturnsOneLetter(string word, string expected)
        {
            MiddleLetter middleletter = new MiddleLetter();
            string actual = middleletter.GetMiddle(word);
            Assert.AreEqual(expected, actual);
        }
    }
}