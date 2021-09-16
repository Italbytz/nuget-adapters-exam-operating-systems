using System;
namespace OperatingSystemsExam.PageReplacement
{
    public class Fifo : BackwardDistanceStrategy
    {
        public Fifo(int[] requests, int memorySize) : base(requests, memorySize)
        {
        }
    }
}
