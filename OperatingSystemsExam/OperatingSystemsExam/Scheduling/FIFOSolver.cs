using System;
using ExamPorts;

namespace OperatingSystemsExam.Scheduling
{
    public class FIFOSolver : ISolver<SchedulingParameters, SchedulingSolution>
    {
        public FIFOSolver()
        {
        }

        public SchedulingSolution Solve(SchedulingParameters parameters)
        {
            var result = 0.0;
            var processes = parameters.Values.Length;
            var remainingProcesses = processes;
            foreach (var value in parameters.Values)
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
