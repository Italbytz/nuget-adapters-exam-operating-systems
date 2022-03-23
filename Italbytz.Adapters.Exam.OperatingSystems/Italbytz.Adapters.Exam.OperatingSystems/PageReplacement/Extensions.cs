using System;
using Italbytz.Infrastructure.Exam.OperatingSystems.PageReplacement;
using Italbytz.Ports.Exam.OperatingSystems;

namespace Italbytz.Adapters.Exam.OperatingSystems.PageReplacement
{
    public static class Extensions
    {
        public static IPageReplacementStep ToStep(this SimulationResult sim)
        {
            return new PageReplacementStep()
            {
                AdditionalInfo = sim.AdditionalInfo,
                Count = sim.Count,
                Element = sim.Element,
                FrameInformation = sim.FrameInformation,
                Frames = sim.Frames
            };
    }
}
}
