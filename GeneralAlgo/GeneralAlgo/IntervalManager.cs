using System.Linq;
using System.Collections.Generic;

// Reference: https://www.youtube.com/watch?v=nONCGxWoUfM

namespace GeneralAlgo
{
    public class IntervalManager
    {
        private readonly List<Interval> _intervals;

        public IntervalManager(List<Interval> intervals)
        {
            _intervals = intervals.OrderBy(interval => interval.StartTime).ToList();
        }

        public List<Interval> RemoveMinOverlappingIntervals()
        {
            int intervalIndex = 0;
            List<Interval> removedIntervals = new();
            while (intervalIndex < _intervals.Count - 1)
            {
                Interval currentInterval = _intervals[intervalIndex];
                Interval adjacentInterval = _intervals[intervalIndex + 1];

                if (currentInterval.IsOverlapping(adjacentInterval))
                {
                    Interval longerInterval = currentInterval.EndTime > adjacentInterval.EndTime
                        ? currentInterval
                        : adjacentInterval;
                    _intervals.Remove(longerInterval);
                    removedIntervals.Add(longerInterval);
                    continue;
                }
                intervalIndex++;
            }
            return removedIntervals;
        }
    }

    public class Interval
    {
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public Interval(int startTime, int endTime)
        {
            StartTime = startTime;
            EndTime = endTime;
        }

        public bool IsOverlapping(Interval nextInterval)
        {
            return nextInterval.StartTime < EndTime;
        }
    }
}
