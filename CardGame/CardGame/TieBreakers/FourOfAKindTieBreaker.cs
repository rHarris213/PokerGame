namespace CardGame.TieBreakers
{
    internal class FourOfAKindTieBreaker : ITieBreaker
    {
        private readonly ITieBreaker _multBreaker;

        public FourOfAKindTieBreaker(ITieBreaker multBreaker)
        {
            this._multBreaker = multBreaker;
        }

        public Hand DetermineStrongestHand(Hand handOne, Hand handTwo)
        {
            //inject this
            

            var highestFourOfAKindHand = _multBreaker.DetermineStrongestHand(handOne, handTwo);

            if (highestFourOfAKindHand != null)
            {
                return highestFourOfAKindHand;
            }
            var highestKickerHand = _multBreaker.DetermineStrongestHand(handOne, handTwo);

            return highestKickerHand;
        
            
        }

        
    } 
}
