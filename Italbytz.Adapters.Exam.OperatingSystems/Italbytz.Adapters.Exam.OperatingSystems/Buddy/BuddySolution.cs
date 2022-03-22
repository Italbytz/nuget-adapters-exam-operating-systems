using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class BuddySolution : IBuddySolution
    {
        public List<int[]> History { get; set; }

        public BuddySolution()
        {
        }
    }
}
