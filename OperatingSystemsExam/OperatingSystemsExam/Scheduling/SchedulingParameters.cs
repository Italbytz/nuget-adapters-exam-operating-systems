using System;
using RandomExtensions;

namespace OperatingSystemsExam.Scheduling
{
    public class SchedulingParameters
    {
        public int[] Values { get; set; }
        public string[] Priorities { get; set; }

        public SchedulingParameters() : this(
            new Random().NextUniqueIntArray(5, 1, 8),
            new Random().ShuffledStrings(new string[] { "hoch", "mittel", "niedrig", "sehr niedrig", "sehr hoch" }))
        {
        }

        public SchedulingParameters(int[] values, string[] priorities)
        {
            Values = values;
            Priorities = priorities;
        }
    }
}
