using System;
using System.Collections.Generic;
using Italbytz.Infrastructure.Exam.OperatingSystems.PageReplacement;
using Italbytz.Ports.Exam;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class FIFOSolver : ISolver<PageReplacementParameters, List<SimulationResult>>
    {
        public List<SimulationResult> Solve(PageReplacementParameters parameters)
        {
            return new Fifo(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
        }
    }
}
