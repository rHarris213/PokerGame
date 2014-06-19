using System.Collections.Generic;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test
{
    [TestFixture]
    class EvaluatorTests
    {
        [Test] public void Evaluator_Should_Accept_Multiple_Hands()
        {
            //arrange
            //act
            //var royalFlush = new List<Card>
            //{

            //    new Card(14, 1),
            //    new Card(13, 1),
            //    new Card(12, 1),
            //    new Card(11, 1),
            //    new Card(10, 1)
            //};
            //var result = evaluator.EvaluateHandScore(royalFlush);
            //assert

            var playerOne = HandBuilder.TwoPair();
            var playerTwo = HandBuilder.TwoPair();
            var playerThree = HandBuilder.TwoPair();
            var playerFour = HandBuilder.TwoPair();
            var playerFive = HandBuilder.TwoPair();
            var playerSix = HandBuilder.RoyalFlush();

            var hands = new List<Hand> { playerOne, playerTwo,playerThree,playerFour,playerFive,playerSix };


            var evaluator = new Evaluator(PokerHandAnalysers.FiveCardPoker());
            var result = evaluator.DetermineWinner(hands);
            Assert.That(result.Equals(playerSix));
        }

        [Test]
        public void Evaluator_Should_Determine_A_Winner()
        {
            //arrange
            //act
            //var royalFlush = new List<Card>
            //{

            //    new Card(14, 1),
            //    new Card(13, 1),
            //    new Card(12, 1),
            //    new Card(11, 1),
            //    new Card(10, 1)
            //};
            //var result = evaluator.EvaluateHandScore(royalFlush);
            //assert
            
            var playerOne = HandBuilder.RoyalFlush();
            var playerTwo = HandBuilder.ThreeOfAKind();

            var hands = new List<Hand> {playerOne, playerTwo};


            var evaluator = new Evaluator(PokerHandAnalysers.FiveCardPoker());
            var result = evaluator.DetermineWinner(hands);
            Assert.That(result.Equals(playerOne));
        }

        [Test]
        public void Evaluator_Should_Not_Allow_A_Lower_Ranked_Card_Set_Win()
        {
            //arrange
            //act
            //var royalFlush = new List<Card>
            //{

            //    new Card(14, 1),
            //    new Card(13, 1),
            //    new Card(12, 1),
            //    new Card(11, 1),
            //    new Card(10, 1)
            //};
            //var result = evaluator.EvaluateHandScore(royalFlush);
            //assert

            var playerOne = HandBuilder.ThreeOfAKind();
            var playerTwo = HandBuilder.RoyalFlush();

            var hands = new List<Hand> { playerOne, playerTwo };


            var evaluator = new Evaluator(PokerHandAnalysers.FiveCardPoker());
            var result = evaluator.DetermineWinner(hands);
            Assert.That(result.Equals(playerTwo));
        }

        [Test]
        public void Evaluator_Should_Identify_A_Draw()
        {
            

            var playerOne = HandBuilder.ThreeOfAKind();
            var playerTwo = HandBuilder.RoyalFlush();

            var hands = new List<Hand> { playerOne, playerTwo };


            var evaluator = new Evaluator(PokerHandAnalysers.FiveCardPoker());
            var result = evaluator.DetermineWinner(hands);
            Assert.That(result.Equals(playerTwo));
        }
    }

    internal class Evaluator
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
                int handScore = _analysers.Count;

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
            }
            return bestHand;
        }
    }
}
