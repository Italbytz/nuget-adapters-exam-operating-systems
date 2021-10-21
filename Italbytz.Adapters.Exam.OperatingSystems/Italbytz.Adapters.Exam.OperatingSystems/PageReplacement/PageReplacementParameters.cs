using System;
using Italbytz.Extensions;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class PageReplacementParameters
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
