using System;
using Italbytz.Extensions;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class PageReplacementParameters : IPageReplacementParameters
    {
        public int[] ReferenceRequests { get; set; }
        public int MemorySize { get; set; }

        public PageReplacementParameters() : this(new Random().NextIntArray(13, 1, 6))
        {

        }

        public PageReplacementParameters(int[] referenceRequests)
        {
            ReferenceRequests = referenceRequests;
        }

    }
}
