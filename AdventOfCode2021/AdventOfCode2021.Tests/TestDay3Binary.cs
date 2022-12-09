using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode2021.Models;

namespace AdventOfCode2021.Tests
{
    [TestClass]
    public class TestDay3Binary
    {
        [TestMethod]
        public void TestFiveValues()
        {
            // arrange
            var day3Binary = new Day3Binary();

            // act
            day3Binary.AddBit('1');
            day3Binary.AddBit('0');
            day3Binary.AddBit('1');
            day3Binary.AddBit('0');
            day3Binary.AddBit('1');

            // assert
            Assert.AreEqual("1", day3Binary.MostCommonBit(), "The MostCommonBit is wrong");
            Assert.AreEqual("0", day3Binary.LeastCommonBit(), "The LeastCommonBit is wrong");
        }

        [TestMethod]
        public void TestDay3LifeSupportRating()
        {
            // arrange
            var day3LifeSupportRating = new Day3LifeSupportRating();

            // act
            day3LifeSupportRating.AddBit('1');
            day3LifeSupportRating.AddBit('0');
            day3LifeSupportRating.AddBit('1');
            day3LifeSupportRating.AddBit('0');
            day3LifeSupportRating.AddBit('1');

            // assert
            Assert.AreEqual("1", day3LifeSupportRating.OxygenGeneratorRating());
            Assert.AreEqual("0", day3LifeSupportRating.CO2ScrubberRating());
        }
    }
}