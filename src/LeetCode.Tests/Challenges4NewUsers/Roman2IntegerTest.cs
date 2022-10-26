using LeetCode.Challenges4NewUsers;
using NUnit.Framework;

namespace LeetCode.Tests.Challenges4NewUsers
{
    [TestFixture]
    public class Roman2IntegerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, "III")]
        [TestCase(58, "LVIII")]
        [TestCase(1994, "MCMXCIV")]
        public void RomanValueConvertingTest(int expectedValue, string input)
        {
            var convertedValue = Roman2Integer.RomanToInt(input);
            
            Assert.AreEqual(expectedValue, convertedValue);
        }
    }
}