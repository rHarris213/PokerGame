using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.HandAnalysers;

namespace CardGame
{
    public class PokerHandAnalysers
    {
        public static List<IHandAnalyser> FiveCardPoker()
        {
            var handAnalysers = new List<IHandAnalyser>
            {
                new RoyalFlushHandAnalyser(),
                new StraightFlushAnalyser(),
                new FourOfAKindAnalyser(),
                new FullHouseAnalyser(),
                new FlushAnalyser(),
                new StraightAnalyser(),
                new ThreeOfAKindAnalyser(),
                new TwoPairAnalyser(),
                new OnePairAnalyser()
            };

            return handAnalysers;
        }
    }
}
