using System.Collections.Generic;

namespace CardGame.HandAnalysers
{
    public interface IHandAnalyser
    {
        bool IsHand(IHand hand);
    }
}