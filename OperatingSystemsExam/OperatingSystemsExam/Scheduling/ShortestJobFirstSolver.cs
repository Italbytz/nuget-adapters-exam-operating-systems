using System;
using System.Linq;
using ExamPorts;

namespace OperatingSystemsExam.Scheduling
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
