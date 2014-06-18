using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test
{
    [TestFixture]
    class EvaluatorTests
    {
        [Test]
        public void Evaluator_Should_Assign_Correct_Value_To_Hand()
        {
            //arrange
 
            
            //act
            var royalFlush = new List<Card>
            {
               
                new Card(14, 1),
                new Card(13, 1),
                new Card(12, 1),
                new Card(11, 1),
                new Card(10, 1)
            };

            var evaluator = new Evaluator(royalFlush);

            var result = evaluator.EvaluateHandScore();
            //assert
            Assert.That(result.Equals(9));
        }
    }

    internal class Evaluator
    {
        private List<Card> _hand = new List<Card>(); 
        public Evaluator(List<Card> hand)
        {
            _hand = hand;
        }

        public int EvaluateHandScore()
        {

            //var handEvaluators = new HandEvaluators();
            List<IHandAnalyser> handAnalysers = new List<IHandAnalyser> 
            {   new RoyalFlushHandAnalyser(_hand),
                new StraightFlushAnalyser(_hand),
                new FourOfAKindAnalyser(_hand),
                new FullHouseAnalyser(_hand),
                new FlushAnalyser(_hand),
                new StraightAnalyser(_hand),
                new ThreeOfAKindAnalyser(_hand),
                new TwoPairAnalyser(_hand),
                new OnePairAnalyser(_hand)};

            int handScore = 10;
            foreach (var handEval in handAnalysers)
            {
                var ishand = handEval.IsHand();

                if (ishand)
                    return handScore;

                handScore--;
            }

            IHandAnalyser royalFlushAnalyser = new RoyalFlushHandAnalyser(_hand);
           



            if(royalFlushAnalyser.IsHand())
            return 10;
            
            if (royalFlushAnalyser.IsHand())
            return 9;
            return 0;
        }
    }
}
