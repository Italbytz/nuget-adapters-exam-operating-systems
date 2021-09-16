using System;
using System.Collections.Generic;
using ExamPorts;

namespace OperatingSystemsExam.PageReplacement.Adapters
{
    public class ClockSolver : ISolver<PageReplacementParameters, List<SimulationResult>>
    {
        public List<SimulationResult> Solve(PageReplacementParameters parameters)
        {
            return new Clock(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
        }
    }
}
