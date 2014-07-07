using System.Collections.Generic;
using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class HighCardTieBreaker
    {
        [Test]
        public void Highest_Card_Should_Determine_Winner()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardNine();

            var result = FindBestHighCardHand(handOne, handTwo);

            Assert.That(result.Equals(handOne));
        }

        [Test]
        public void Same_Hand_Should_Result_In_Draw()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardAce();

            var result = FindBestHighCardHand(handOne, handTwo);

            Assert.IsNull(result);
        }

        private Hand FindBestHighCardHand(Hand handOne, Hand handTwo)
        {
            Hand bestHand = null;

            var handOneHighest = FindHighestSingleCard(handOne.GetCards());
            var handTwoHighest = FindHighestSingleCard(handTwo.GetCards());

            if (handOneHighest > handTwoHighest)
                return handOne;
            if (handTwoHighest > handOneHighest)
                return handTwo;

          
            return bestHand;
        }

        private Value FindHighestSingleCard(List<Card> cards)
        {
            for (var cardValue = Value.Ace; cardValue >= Value.Two; cardValue--)
            {

                var amountOfCard = cards.Count(obj => obj.GetCardValue() == cardValue);
                

                if (amountOfCard == 1)
                {
                    return cardValue;
                }
                
            }

            return 0;
        }
    }
}
