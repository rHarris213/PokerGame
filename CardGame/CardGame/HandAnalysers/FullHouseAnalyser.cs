using System.Collections.Generic;
using System.Linq;

namespace CardGame.HandAnalysers
{
    public class FullHouseAnalyser : IHandAnalyser 
    {
        private readonly List<Card> _hand;
        public FullHouseAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            var threeOfAKind = false;
            var pair = false;

            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() > 2 && !threeOfAKind)
                {
                    threeOfAKind = true;

                }
                else if (cardsOfSameValue.Count() > 1 && !pair)
                {
                    pair = true;

                }
                if (threeOfAKind && pair)
                {
                    return true;
                }
            }
            return false;
        }
    }
}