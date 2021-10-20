using System;
using System.Collections.Generic;
using Italbytz.Infrastructure.Exam.OperatingSystems;
using NUnit.Framework;

namespace Italbytz.Adapters.Exam.OperatingSystems.Tests
{
    public class BuddyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var processes = new List<Process>() {
            new Process()
            {
                Id = 1,
                Name = "A",
                Size = 65,
                OpType = "Request"
            },
            new Process()
            {
                Id = 2,
                Name = "B",
                Size = 30,
                OpType = "Request"
            },
            new Process()
            {
                Id = 3,
                Name = "C",
                Size = 94,
                OpType = "Request"
            },
            new Process()
            {
                Id = 4,
                Name = "D",
                Size = 34,
                OpType = "Request"
            },
            new Process()
            {
                Id = 5,
                Name = "E",
                Size = 136,
                OpType = "Request"
            },
            new Process()
            {
                Id = 4,
                OpType = "Release"
            }
            };
            new BuddySystem().Start(processes);
        }
    }
}
