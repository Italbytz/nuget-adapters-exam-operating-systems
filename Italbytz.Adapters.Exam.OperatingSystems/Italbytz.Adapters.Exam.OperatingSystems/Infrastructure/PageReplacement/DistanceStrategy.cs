using System;
using System.Linq;

namespace Italbytz.Infrastructure.Exam.OperatingSystems
{
    public abstract class DistanceStrategy : PageReplacementStrategy
    {
        protected DistanceStrategy(int[] requests, int memorySize) : base(
            requests, memorySize)
        {
        }

        protected override int IndexToReplace(int element) =>
            Array.IndexOf(FrameInformation, FrameInformation.Max());
    }
}
