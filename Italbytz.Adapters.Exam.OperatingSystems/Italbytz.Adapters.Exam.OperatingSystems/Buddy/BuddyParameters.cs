using System;
using System.Linq;
using Italbytz.Extensions;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class BuddyParameters : IBuddyParameters
    {
        private Random _random = new();

        public string[] Processes { get; set; }
        public int[] Requests { get; set; }
        public string[] FreeOrder { get; set; }

        public BuddyParameters()
        {
            var buddyRequests = new int[5];
            var memoryConsumption = 0;
            do
            {
                buddyRequests = _random.NextIntArray(5, 1, 512);
                memoryConsumption = buddyRequests.Aggregate(
                    0,
                    (temp, x) => (int)(temp + Math.Pow(2, Math.Ceiling(Math.Log(x, 2)))));
            } while (memoryConsumption > 1024);

            Processes = new string[] { "A", "B", "C", "D", "E" };
            Requests = buddyRequests;
            FreeOrder = _random.ShuffledStrings(new string[] { "A", "B", "C", "D", "E" });

        }
    }
}