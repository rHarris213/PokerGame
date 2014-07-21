using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using cardGame.Test.Builders;
using NUnit;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class KickerBreaker
    {
       
        [Test]
        public void ShouldIdentifyBestStraightFlushHand()
        {
            var handOne = HandBuilder.StraightFlushLow();
            var handTwo = HandBuilder.StraightFlushHigh();
            Hand highestHand;

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

            if (IsAceLowStraight(handOne) && !IsAceLowStraight(handTwo))
                highestHand = handTwo;
            if (IsAceLowStraight(handTwo) && !IsAceLowStraight(handOne))
                highestHand = handOne;
            else
            highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handTwo));


        }
        [Test]
        public void ShouldIdentifyBestFourOfAKindHand()
        {
            var handOne = HandBuilder.FourOfAKindKingsLowKicker();
            var handTwo = HandBuilder.FourOfAKindKingsHighKicker();

            handOne.SortCardsByGroups();
            handTwo.SortCardsByGroups();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handTwo));


        }
        [Test]
        public void ShouldIdentifyBestFullHouseHand()
        {
            var handOne = HandBuilder.FullHouseThreeAces();
            var handTwo = HandBuilder.FullHouseThreeEightsPairOfKings();

            handOne.SortCardsByGroups();
            handTwo.SortCardsByGroups();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handOne));


        }
        [Test]
        public void ShouldIdentifyBestFlushHand()
        {
            var handOne = HandBuilder.FlushAceHighNineLow();
            var handTwo = HandBuilder.FlushAceHighThreeLow();

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handOne));


        }

        [Test]
        public void ShouldIdentifyBestStraightHand()
        {
            var handOne = HandBuilder.StraightJackHigh();
            var handTwo = HandBuilder.StraightAceLow();
            Hand highestHand;
            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

            if (IsAceLowStraight(handOne) && !IsAceLowStraight(handTwo))
                highestHand = handTwo;
            if (IsAceLowStraight(handTwo) && !IsAceLowStraight(handOne))
                highestHand = handOne;
            else

            highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handOne));


        }
        [Test]
        public void ShouldIdentifyBestThreeOfAKindHand()
        {
            var handOne = HandBuilder.ThreeOfAKindKingsHighKickers();
            var handTwo = HandBuilder.ThreeOfAKindKingsLowKickers();

            handOne.SortCardsByGroups();
            handTwo.SortCardsByGroups();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handOne));


        }
        [Test]
        public void ShouldIdentifyBestTwoPairHand()
        {
            var handOne = HandBuilder.TwoPairKingsOverThreesEightKicker();
            var handTwo = HandBuilder.TwoPairKingsOverSixesSevenKicker();

            handOne.SortCardsByGroups();
            handTwo.SortCardsByGroups();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handTwo));


        }
        [Test]
        public void ShouldIdentifyBestPairHand()
        {
            var handOne = HandBuilder.PairJacksHighKickers();
            var handTwo = HandBuilder.PairJacksLowKickers();

            handOne.SortCardsByGroups();
            handTwo.SortCardsByGroups();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handOne));


        }
        [Test]
        public void ShouldIdentifyBestHighCardHand()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardSeven();
            

            handOne.ArrangeCardsHighToLow();
            handTwo.ArrangeCardsHighToLow();

            var highestHand = CheckHighest(handOne, handTwo);

            Assert.That(highestHand.Equals(handOne));


        }
        

       

        public Hand CheckHighest(Hand handOne, Hand handTwo)
        {
            var handSize = handOne.GetLength();
            Hand bestHand = null;
            for (int i = 0; i < handSize; i++)
            {
                if (handOne.GetCards()[i].GetCardValue() > handTwo.GetCards()[i].GetCardValue())
                {
                    bestHand = handOne;
                }
                if (handTwo.GetCards()[i].GetCardValue() > handOne.GetCards()[i].GetCardValue())
                {
                    bestHand = handTwo;
                }
                if (bestHand != null)
                    return bestHand;


            }


            return bestHand;
        }

        private static bool IsAceLowStraight(Hand hand)
        {


            return (hand.GetCards()[0].GetCardValue() == Value.Ace
                  && hand.GetCards()[1].GetCardValue() == Value.Five
                  && hand.GetCards()[2].GetCardValue() == Value.Four
                  && hand.GetCards()[3].GetCardValue() == Value.Three
                  && hand.GetCards()[4].GetCardValue() == Value.Two);



        }
        
    }
    
}
