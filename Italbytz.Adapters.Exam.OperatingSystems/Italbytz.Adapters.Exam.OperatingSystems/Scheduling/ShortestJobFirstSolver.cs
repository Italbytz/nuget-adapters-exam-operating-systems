using System;
using System.Linq;
using Italbytz.Ports.Exam;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class ShortestJobFirstSolver : ISolver<SchedulingParameters, SchedulingSolution>
    {
        public ShortestJobFirstSolver()
        {
        }

        public SchedulingSolution Solve(SchedulingParameters parameters)
        {
            var orderedValues = parameters.Values.OrderBy(s => s);
            var result = 0.0;
            var processes = parameters.Values.Length;
            var remainingProcesses = processes;
            foreach (var value in orderedValues)
            {
                result += (double)remainingProcesses * (double)value / (double)processes;
                remainingProcesses--;
            }
            return new SchedulingSolution()
            {
                Time = result
            };
        }
    }
}
