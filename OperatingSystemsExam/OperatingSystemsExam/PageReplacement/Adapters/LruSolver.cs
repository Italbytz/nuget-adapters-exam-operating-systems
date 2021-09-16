using System;
using System.Collections.Generic;
using ExamPorts;

namespace OperatingSystemsExam.PageReplacement.Adapters
{
    public class LruSolver : ISolver<PageReplacementParameters, List<SimulationResult>>
    {
        public List<SimulationResult> Solve(PageReplacementParameters parameters)
        {
            return new Lru(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
        }
    }
}
