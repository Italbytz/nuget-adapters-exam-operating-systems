using System;
using System.Linq;
using ExamPorts;

namespace OperatingSystemsExam.Scheduling
{
    public class RoundRobinSolver : ISolver<SchedulingParameters, SchedulingSolution>
    {
        public RoundRobinSolver()
        {
        }

        public SchedulingSolution Solve(SchedulingParameters parameters)
        {
            var orderedValues = parameters.Values.OrderBy(s => s);
            var result = 0.0;
            var processes = parameters.Values.Length;
            var remainingProcesses = processes;
            var sharedTime = 0;
            foreach (var value in orderedValues)
            {
                result += (double)remainingProcesses * ((double)value - (double)sharedTime) / (double)processes * (double)remainingProcesses;
                sharedTime = value;
                remainingProcesses--;
            }
            return new SchedulingSolution()
            {
                Time = result
            };
        }
    }
}
