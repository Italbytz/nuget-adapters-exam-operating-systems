using System;
using System.Collections.Generic;
using Italbytz.Infrastructure.Exam.OperatingSystems;
using Italbytz.Ports.Exam;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class FifoSolver : ISolver<PageReplacementParameters, List<SimulationResult>>
    {
        public List<SimulationResult> Solve(PageReplacementParameters parameters)
        {
            return new Fifo(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
        }
    }
}
