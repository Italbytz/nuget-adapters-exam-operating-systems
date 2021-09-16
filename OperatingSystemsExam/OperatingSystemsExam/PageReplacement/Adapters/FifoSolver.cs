using System;
using System.Collections.Generic;
using ExamPorts;

namespace OperatingSystemsExam.PageReplacement.Adapters
{
    public class FifoSolver : ISolver<PageReplacementParameters, List<SimulationResult>>
    {
        public List<SimulationResult> Solve(PageReplacementParameters parameters)
        {
            return new Fifo(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
        }
    }
}
