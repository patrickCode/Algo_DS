using GeneralAlgo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GeneralAlgoTests
{
    [TestClass]
    public class IntervalManagerTests
    {
        [TestMethod]
        public void TestCase1_RemoveSingleInterval()
        {
            List<Interval> intervals = new()
            {
                new Interval(1, 2),
                new Interval(2, 3),
                new Interval(3, 3),
                new Interval(1, 3),
            };
            IntervalManager manager = new(intervals);
            List<Interval> removedIntervals = manager.RemoveMinOverlappingIntervals();

            Assert.AreEqual(1, removedIntervals.Count);
            Assert.AreEqual(1, removedIntervals.First().StartTime);
            Assert.AreEqual(3, removedIntervals.First().EndTime);
        }

        [TestMethod]
        public void TestCase1_Remove2Intervals()
        {
            List<Interval> intervals = new()
            {
                new Interval(1, 2),
                new Interval(1, 2),
                new Interval(1, 2)
            };
            IntervalManager manager = new(intervals);
            List<Interval> removedIntervals = manager.RemoveMinOverlappingIntervals();

            Assert.AreEqual(2, removedIntervals.Count);
            Assert.AreEqual(1, removedIntervals.First().StartTime);
            Assert.AreEqual(2, removedIntervals.First().EndTime);
            Assert.AreEqual(1, removedIntervals.Last().StartTime);
            Assert.AreEqual(2, removedIntervals.Last().EndTime);
        }
    }
}
