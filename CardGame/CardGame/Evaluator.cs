using System;
using System.Collections.Generic;
using CardGame.HandAnalysers;

namespace CardGame
{
    public class Evaluator
    {
        private readonly IList<IHandAnalyser> _analysers;

        public Evaluator(IList<IHandAnalyser> analysers)
        {
            _analysers = analysers;
        }
        
        public Hand DetermineWinner(IEnumerable<Hand> hands)
        {
            Hand bestHand = null;
            
            var highestScore = 0;

            foreach (var hand in hands)
            {
                int handScore = _analysers.Count + 1;

                foreach (var analyser in _analysers)
                {
                    handScore--;
                    if (!analyser.IsHand(hand)) continue;
                    if (handScore > highestScore)
                    {
                        bestHand = hand;
                        highestScore = handScore;

                    }
                    break;
                }
                if (bestHand == null)
                {
                    bestHand = hand;
                }
            }

            return bestHand;
        }
    }
}