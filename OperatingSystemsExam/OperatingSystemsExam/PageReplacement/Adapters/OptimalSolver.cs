using System;
using System.Collections.Generic;
using ExamPorts;

namespace OperatingSystemsExam.PageReplacement.Adapters
{
    public class OptimalSolver : ISolver<PageReplacementParameters, List<SimulationResult>>
    {
        public List<SimulationResult> Solve(PageReplacementParameters parameters)
        {
            return new Optimal(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
        }
    }
}
