using System.Linq;
using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeneralAlgoTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void ShouldConvertArray()
        {
            var nums = new int[] { 1, 16, 7, 8, 9, 12, 6, 3, 2, 5 };
            var expectedFizzBuzz = new string[] { null, "Fizz", null, "Fizz", "Buzz", "FizzBuzz", "FizzBuzz", "Buzz", "Fizz", null };

            var actualFizzBuzz = FizzBuzz.Convert(nums);
            Assert.IsTrue(expectedFizzBuzz.SequenceEqual(actualFizzBuzz));
        }
    }
}
