using System;
using ExamPorts;

namespace OperatingSystemsExam.Scheduling
{
    public class PrioritySchedulingSolver : ISolver<SchedulingParameters, SchedulingSolution>
    {
        public PrioritySchedulingSolver()
        {
        }

        public SchedulingSolution Solve(SchedulingParameters parameters)
        {
            var result = 0.0;
            var processes = parameters.Values.Length;
            var remainingProcesses = processes;
            foreach (var priority in new string[] { "sehr hoch", "hoch", "mittel", "niedrig", "sehr niedrig" })
            {
                var index = Array.FindIndex(parameters.Priorities, e => e == priority);
                result += (double)remainingProcesses * (double)parameters.Values[index] / (double)processes;
                remainingProcesses--;
            }
            return new SchedulingSolution()
            {
                Time = result
            };
        }
    }
}
