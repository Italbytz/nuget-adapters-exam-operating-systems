using System;
using System.Collections.Generic;
using Italbytz.Infrastructure.Exam.OperatingSystems.Buddy;
using Italbytz.Ports.Exam;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems
{
    public class BuddySolver : IBuddySolver
    {
        public BuddySolver()
        {
        }

        public IBuddySolution Solve(IBuddyParameters parameters)
        {
            var operations = new List<Process>();

            for (int i = 0; i < parameters.Requests.Length; i++)
            {
                operations.Add(new Process()
                {
                    Id = i,
                    Name = parameters.Processes[i],
                    Size = parameters.Requests[i],
                    OpType = "Request"
                });
            }
            foreach (var freeItem in parameters.FreeOrder)
            {
                operations.Add(new Process()
                {
                    Id = Array.FindIndex(parameters.Processes, process => freeItem == process),
                    OpType = "Release"
                });
            }

            var buddy = new BuddySystem();
            buddy.Start(operations);

            return new BuddySolution() { History = buddy.History };
        }
    }
}
