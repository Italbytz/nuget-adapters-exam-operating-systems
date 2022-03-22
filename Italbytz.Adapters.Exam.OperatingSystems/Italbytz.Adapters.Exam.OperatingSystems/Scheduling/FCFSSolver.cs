using System;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class FCFSSolver : ISchedulingSolver
    {
        public FCFSSolver()
        {
        }

        public ISchedulingSolution Solve(ISchedulingParameters parameters)
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
