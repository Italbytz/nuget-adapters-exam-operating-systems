﻿using System;
using System.Collections.Generic;
using System.Linq;
using ExamPorts;

namespace OperatingSystemsExam.Scheduling.Realtime
{
    public class RMSSolver : ISolver<SchedulingParameters, SchedulingSolution>
    {
        public RMSSolver()
        {
        }

        public SchedulingSolution Solve(SchedulingParameters parameters)
        {
            var result = new int[32];
            var waiting = new List<(int, int)>();
            for (int i = 0; i < 32; i++)
            {
                var index = 0;
                foreach (var process in parameters.Requests)
                {
                    if (i % process.Item2 < process.Item1)
                    {
                        waiting.Add((index, process.Item2));
                    }
                    index++;
                }
                if (waiting.Count == 0)
                {
                    result[i] = -1;
                }
                else
                {
                    var winner = waiting.OrderBy(e => e.Item2).ThenBy(e => e.GetHashCode()).First();
                    result[i] = winner.Item1;
                    waiting.Remove(winner);
                }

            }
            return new SchedulingSolution()
            {
                Processes = result
            };
        }
    }
}
