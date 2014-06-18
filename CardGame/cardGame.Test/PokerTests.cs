using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using NUnit.Framework;

namespace cardGame.Test
{
    [TestFixture]
    class PokerTests
    {
        [Test]
        public void CheckHighCard_Returns_Highest_Card_Value()
        {
            
            var aHand = new Hand();
            aHand.TakeCards(new Card(2,2));
            aHand.TakeCards(new Card(6,2));
            aHand.TakeCards(new Card(3,2));
            
            Assert.That(aHand.CheckHighCard().Equals(6));
        }
        
        [Test]
        public void Returns_Highest_Card_Value()
        {

            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(6, 2));
            aHand.TakeCards(new Card(3, 2));

            Assert.That(aHand.CheckHighCard().Equals(6));
        }

        [Test]
        public void CheckFlush_Can_Be_Identified_With_All_Suits_Same()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(5, 2));
            aHand.TakeCards(new Card(8, 2));
            
            Assert.That(aHand.CheckFlush().Equals(5));
        }

        [Test]
        public void CheckStraight_Will_Return_True_With_All_Suits_Same()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(5, 3));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(6, 0));

            Assert.That(aHand.CheckStraight().Equals(4));
        }
        [Test]
        public void CheckStraight_Will_Return_True_With_Ace_Low()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(5, 3));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(14, 0));

            Assert.That(aHand.CheckStraight().Equals(4));
        }

        [Test]
        public void StraightFlush_Can_Be_Identified()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(5, 2));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(14, 2));

            Assert.That(aHand.CheckStraightFlush().Equals(8));
        }

        [Test]
        public void Royal_Flush_Can_Be_Identified()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(10, 2));
            aHand.TakeCards(new Card(11, 2));
            aHand.TakeCards(new Card(12, 2));
            aHand.TakeCards(new Card(13, 2));
            aHand.TakeCards(new Card(14, 2));

            Assert.That(aHand.CheckRoyalFlush().Equals(true));
        }

        [Test]
        public void Three_Of_A_Kind_Can_Be_Determined()
        {
            var aHand = new Hand();
            
            aHand.TakeCards(new Card(3, 0));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(5, 4));
           
            
            Assert.That(aHand.CheckMultiples().Equals(3));
        }

        [Test]
        public void Pair_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(3, 0));
            aHand.TakeCards(new Card(2, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(6, 4));


            Assert.That(aHand.CheckMultiples().Equals(1));
        }

        [Test]
        public void Two_Pair_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(2, 0));
            aHand.TakeCards(new Card(2, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(6, 4));


            Assert.That(aHand.CheckMultiples().Equals(2));
        }

        [Test]
        public void Four_Of_A_Kind_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(4, 0));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(6, 4));


            Assert.That(aHand.CheckMultiples().Equals(7));
        }

        [Test]
        public void Full_House_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(3, 0));
            aHand.TakeCards(new Card(3, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(4, 4));


            Assert.That(aHand.CheckMultiples().Equals(6));
        }

        [Test]
        public void Winner_Can_Be_Determined()
        {
            var poker = new GameRules();
            
            var playerOne = new Hand();

            playerOne.TakeCards(new Card(13, 0));
            playerOne.TakeCards(new Card(3, 1));
            playerOne.TakeCards(new Card(4, 2));
            playerOne.TakeCards(new Card(5, 3));
            playerOne.TakeCards(new Card(7, 4));

            var playerTwo = new Hand();

            playerTwo.TakeCards(new Card(14, 0));
            playerTwo.TakeCards(new Card(3, 1));
            playerTwo.TakeCards(new Card(2, 2));
            playerTwo.TakeCards(new Card(5, 3));
            playerTwo.TakeCards(new Card(7, 4));

            Assert.That(poker.CompareCards(playerOne, playerTwo).Equals(2));

        }

        //[Test]
        //public void Cards_Can_Be_Returned()
        //{
        //    var aHand = new Hand();

        //    aHand.TakeCards(new Card(2, 0));
        //    aHand.TakeCards(new Card(2, 1));
        //    aHand.TakeCards(new Card(2, 2));
        //    aHand.TakeCards(new Card(4, 3));
        //    aHand.TakeCards(new Card(5, 4));

          

        //    Assert.That(aHand.GetCards().Count == 4);
        //}

        
        [Test]
        public void Evaluator_Should_Determine_Hand_Score()
        {
            var threeOfAKind = new List<Card>
            {
                new Card(2, 2),
                new Card(3, 3),
                new Card(3, 2),
                new Card(3, 1),
                new Card(5, 1)
            };

            var evaluator = new HandEvaluator(threeOfAKind);

            var result = evaluator.ScoreHand();

            Assert.That(result == 3);
        }
    }

    internal class HandEvaluator
    {
        private readonly List<Card> _hand;

        public HandEvaluator(List<Card> hand)
        {
            _hand = hand;
        }

        public int ScoreHand()
        {

            if (IsThreeOfAKind())
                return 3;
            if (IsTwoPair())
                return 2;
            if (IsOnePair())
                return 1;
            else
                return 0;



        }

        public bool IsThreeOfAKind()
        {
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    return true;

                }
               
            }
            return false;
        }

        public bool IsTwoPair()
        {
            var numberOfPairs = 0;
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 2)
                {
                    numberOfPairs++;
                    if (numberOfPairs == 2)
                    {
                        return true;
                    }
                }

            }
            return false;
        }

        public bool IsOnePair()
        {
            var numberOfPairs = 0;
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 2)
                {
                    numberOfPairs++;
                }

            }
            if (numberOfPairs == 1)
            {
                return true;
            }
            return false;
        }
       
    }

    public interface IHand
    {
        IEnumerable<ICard> Cards { get; }
    }

    public interface IEvaluator
    {
        IHand GetWinningHand(IEnumerable<IHand> hands);
    }

    public interface IDealer
    {
        IEnumerable<IHand> Deal(int numberOfPlayers);
    }
}
