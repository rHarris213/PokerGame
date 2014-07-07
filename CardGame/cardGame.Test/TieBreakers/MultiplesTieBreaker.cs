using System.Collections.Generic;
using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class MultiplesTieBreaker
    {
        [Test]
        public void Highest_Card_Should_Determine_Winner()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardNine();

            var result =FindHigherValueGroupOfCards(handOne, handTwo, 1);

            Assert.That(result.Equals(handOne));
        }

        [Test]
        public void Same_Hand_Should_Result_In_Draw()
        {
            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardAce();

            var result = FindHigherValueGroupOfCards(handOne, handTwo, 1);

            Assert.IsNull(result);
        }

        

        public static Hand FindHigherValueGroupOfCards(Hand handOne, Hand handTwo, int multipleRequired)
        {
            Hand bestHand = null;
            for (var cardValue = Value.Ace; cardValue >= Value.Two; cardValue--)
            {

                var handOneCountOfCard = handOne.GetCards().Count(obj => obj.GetCardValue() == cardValue);
                var handTwoCountOfCard = handTwo.GetCards().Count(obj => obj.GetCardValue() == cardValue);
                

                if (handOneCountOfCard == multipleRequired && handTwoCountOfCard != multipleRequired)
                {
                    bestHand = handOne;
                    break;
                }
                if (handTwoCountOfCard == multipleRequired && handOneCountOfCard != multipleRequired)
                {
                    bestHand = handTwo;
                    break;
                }

            }

            return bestHand;
        }
    }
}
