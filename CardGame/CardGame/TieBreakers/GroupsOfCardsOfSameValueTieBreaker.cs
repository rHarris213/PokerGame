using System.Linq;

namespace CardGame.TieBreakers
{
    public class GroupsOfCardsOfSameValueTieBreaker : ITieBreaker
    {
        private readonly Hand _handOne;
        private readonly Hand _handTwo;

        public GroupsOfCardsOfSameValueTieBreaker(Hand handOne, Hand handTwo)
        {
            
            _handOne = handOne;
            _handTwo = handTwo;
        }
        
        public Hand DetermineStrongestHand( int amountOfCardsOfSameValueRequired)
        {
              
            Hand bestHand = null;
            for (var cardValue = Value.Ace; cardValue >= Value.Two; cardValue--)
            {
                
                var handOneCountOfCard = _handOne.GetCards().Count(obj => obj.GetCardValue() == cardValue);
                var handTwoCountOfCard = _handTwo.GetCards().Count(obj => obj.GetCardValue() == cardValue);


                if (handOneCountOfCard == amountOfCardsOfSameValueRequired && handTwoCountOfCard != amountOfCardsOfSameValueRequired)
                {
                    bestHand = _handOne;
                    break;
                }
                if (handTwoCountOfCard == amountOfCardsOfSameValueRequired && handOneCountOfCard != amountOfCardsOfSameValueRequired)
                {
                    bestHand = _handTwo;
                    break;
                }

            }

            return bestHand;
        }

        public Hand DetermineStrongestHand(Hand handOne, Hand handTwo)
        {
            throw new System.NotImplementedException();
        }
    }
}
