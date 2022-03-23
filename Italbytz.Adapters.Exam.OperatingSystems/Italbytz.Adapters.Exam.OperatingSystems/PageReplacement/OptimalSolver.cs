using System;
using System.Collections.Generic;
using System.Linq;
using Italbytz.Adapters.Exam.OperatingSystems.PageReplacement;
using Italbytz.Infrastructure.Exam.OperatingSystems.PageReplacement;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class OptimalSolver : IPageReplacementSolver
    {
        public IPageReplacementSolution Solve(IPageReplacementParameters parameters)
        {
            var simResult = new Optimal(parameters.ReferenceRequests, parameters.MemorySize).Simulate();
            var steps = simResult.Select(sim => sim.ToStep()).ToList();
            return new PageReplacementSolution()
            {
                Steps = steps
            };

        }
    }
}
