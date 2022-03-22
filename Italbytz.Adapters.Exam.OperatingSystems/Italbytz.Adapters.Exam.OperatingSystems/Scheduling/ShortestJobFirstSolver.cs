using System;
using System.Linq;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class ShortestJobFirstSolver : ISchedulingSolver
    {
        public ShortestJobFirstSolver()
        {
        }

        public ISchedulingSolution Solve(ISchedulingParameters parameters)
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
