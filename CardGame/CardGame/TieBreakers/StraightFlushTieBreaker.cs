using System.Linq;

namespace CardGame.TieBreakers
{
    public class StraightFlushTieBreaker : ITieBreaker
    {
        public Hand DetermineStrongestHand(Hand playerOne, Hand playerTwo)
        {
            Hand bestHand = null;


            var playerOneHighCard = FindHighestCard(playerOne);
            var playerTwoHighCard = FindHighestCard(playerTwo);

            if (playerOneHighCard > playerTwoHighCard)
            {
                bestHand = playerOne;
            }
            else if (playerTwoHighCard > playerOneHighCard)
            {
                bestHand = playerTwo;
            }



            return bestHand;


        }

        private Value FindHighestCard(Hand hand)
        {

            var sortedHand = hand.GetCards().OrderByDescending(c => c.GetCardValue()).ToList();

            var highestCardValue = sortedHand[0].GetCardValue();
            var secondHighestCardValue = sortedHand[1].GetCardValue();

            if (highestCardValue == Value.Ace && secondHighestCardValue == Value.Five)
            {
                highestCardValue = Value.Five;
            }

            return highestCardValue;
        }
    }
}
