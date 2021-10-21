using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Italbytz.Adapters.Exam.OperatingSystems.Tests
{
    public class SchedulingTests
    {
        private SchedulingParameters parameters;

        [SetUp]
        public void Setup()
        {
            parameters = new SchedulingParameters(new int[] { 4, 3, 8, 1, 5 }, new string[] { "sehr hoch", "mittel", "sehr niedrig", "hoch", "niedrig" });
        }

        [Test]
        public void TestShortestJobFirst()
        {
            var solver = new ShortestJobFirstSolver();
            var solution = solver.Solve(parameters);
            Assert.AreEqual(9.4, solution.Time);
        }

        [Test]
        public void TestPriorityScheduling()
        {
            var solver = new PrioritySchedulingSolver();
            var solution = solver.Solve(parameters);
            Assert.AreEqual(10.2, solution.Time);
        }

        [Test]
        public void TestFCFS()
        {
            var solver = new FCFSSolver();
            var solution = solver.Solve(parameters);
            Assert.AreEqual(12.6, solution.Time);
        }

        [Test]
        public void TestRoundRobin()
        {
            var solver = new RoundRobinSolver();
            var solution = solver.Solve(parameters);
            Assert.AreEqual(14.6, solution.Time);
        }

    }
}
