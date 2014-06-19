using System.Collections.Generic;

namespace CardGame
{
    public class Evaluator
    {
        private List<Card> _hand = new List<Card>(); 
        public Evaluator(List<Card> hand)
        {
            _hand = hand;
        }

        

        public int EvaluateHandScore()
        {

           
           
    
            //var handAnalysers = new PokerHandAnalysers();

            //var pokerHands = handAnalysers.GetList();
            

            //var handScore = pokerHands.Count;
            //foreach (var handEval in pokerHands)
            //{
            //    var ishand = handEval.IsHand(_hand);

            //    if (ishand)
            //        return handScore;

            //    handScore--;
            //}

            return 0;
            
           



            
        }
    }
}