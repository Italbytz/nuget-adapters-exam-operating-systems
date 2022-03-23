using System;
using System.Collections.Generic;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems.PageReplacement
{
    public class PageReplacementSolution : IPageReplacementSolution
    {
        public PageReplacementSolution()
        {
        }

        public List<IPageReplacementStep> Steps { get; set; }
    }
}
