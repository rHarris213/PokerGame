using System.Collections.Generic;
using System.Configuration;
using CardGame;

namespace cardGame.Test.Builders
{
    public static class HandBuilder
    {
        public static Hand StraightFlushLow()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Five, Suit.Clubs),
                new Card(Value.Six, Suit.Clubs)
            });

            return hand;
        }

        public static Hand StraightFlushHigh()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Nine, Suit.Clubs),
                new Card(Value.Ten, Suit.Clubs),
                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.King, Suit.Clubs)
            });

            return hand;
        }

        public static Hand HighCardHand()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Five, Suit.Clubs),
                new Card(Value.Seven, Suit.Hearts)
            });

            return hand;
        }

        public static Hand StraightFlushWithAceLow()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Five, Suit.Clubs),
                new Card(Value.Ace, Suit.Clubs)
            });

            return hand;
        }

        public static Hand FlushSevenHigh()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Six, Suit.Clubs),
                new Card(Value.Seven, Suit.Clubs)
            });
            return hand;
        }

        public static Hand FlushAceHighTwoLow()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.King, Suit.Clubs)
                
            });
            return hand;
        }

        public static Hand FlushAceHighThreeLow()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.King, Suit.Clubs)
                
            });
            return hand;
        }

        public static Hand FourOfAKindSevens()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Seven, Suit.Clubs),
                 new Card(Value.Seven, Suit.Hearts),
                 new Card(Value.Seven, Suit.Diamonds),
                 new Card(Value.Seven, Suit.Spades),
                 new Card(Value.Eight, Suit.Diamonds)
            });

            return hand;
        }

        public static Hand FourOfAKindKings()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.King, Suit.Clubs),
                 new Card(Value.King, Suit.Hearts),
                 new Card(Value.King, Suit.Diamonds),
                 new Card(Value.King, Suit.Spades),
                 new Card(Value.Eight, Suit.Diamonds)
            });

            return hand;
        }

        public static Hand FourOfAKindKingsHighKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.King, Suit.Clubs),
                 new Card(Value.King, Suit.Hearts),
                 new Card(Value.King, Suit.Diamonds),
                 new Card(Value.King, Suit.Spades),
                 new Card(Value.Queen, Suit.Diamonds)
            });

            return hand;
        }

        public static Hand FourOfAKindKingsLowKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.King, Suit.Clubs),
                 new Card(Value.King, Suit.Hearts),
                 new Card(Value.King, Suit.Diamonds),
                 new Card(Value.King, Suit.Spades),
                 new Card(Value.Two,  Suit.Diamonds)
            });

            return hand;
        }

        public static Hand FullHouseLargeHand()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Seven, Suit.Clubs),
                 new Card(Value.Seven, Suit.Hearts),
                 new Card(Value.Seven, Suit.Diamonds),
                 new Card(Value.Two, Suit.Clubs),
                 new Card(Value.Two, Suit.Diamonds),
                 new Card(Value.King, Suit.Clubs),
                
            });
            return hand;
        }

        public static Hand FullHouseThreeAces()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                
                 new Card(Value.Two, Suit.Clubs),
                 new Card(Value.Two, Suit.Diamonds),
                  new Card(Value.Ace, Suit.Clubs),
                 new Card(Value.Ace, Suit.Hearts),
                 new Card(Value.Ace, Suit.Diamonds)
                
                
            });
            return hand;
        }

        public static Hand FullHouseThreeFours()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Four, Suit.Clubs),
                 new Card(Value.Four, Suit.Hearts),
                 new Card(Value.Four, Suit.Diamonds),
                 new Card(Value.Two, Suit.Clubs),
                 new Card(Value.Two, Suit.Diamonds),
                
                
            });
            return hand;
        }

        public static Hand FullHouseThreeEightsPairOfFours()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Eight, Suit.Clubs),
                 new Card(Value.Eight, Suit.Hearts),
                 new Card(Value.Eight, Suit.Diamonds),
                 new Card(Value.Four, Suit.Clubs),
                 new Card(Value.Four, Suit.Diamonds),
                
                
            });
            return hand;
        }

        public static Hand FullHouseThreeEightsPairOfKings()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Eight, Suit.Clubs),
                 new Card(Value.Eight, Suit.Hearts),
                 new Card(Value.Eight, Suit.Diamonds),
                 new Card(Value.King, Suit.Clubs),
                 new Card(Value.King, Suit.Diamonds),
                
                
            });
            return hand;
        }

        public static Hand TwoPairSevensOverTwosThreeKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Seven, Suit.Hearts),
                new Card(Value.Seven, Suit.Diamonds),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Two, Suit.Diamonds),
            });
            return hand;
        }
        public static Hand TwoPairKingsOverThreesEightKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Eight, Suit.Clubs),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Three, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand TwoPairKingsOverSixesSevenKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Seven, Suit.Clubs),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Six, Suit.Clubs),
                new Card(Value.Six, Suit.Diamonds),
            });
            return hand;
        }
        public static Hand TwoPairKingsOverTensThreeKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Three, Suit.Clubs),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Ten, Suit.Clubs),
                new Card(Value.Ten, Suit.Diamonds),
            });
            return hand;
        }
        public static Hand TwoPairKingsOverNinesThreeKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Three, Suit.Clubs),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Nine, Suit.Clubs),
                new Card(Value.Nine, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand TwoPairQueensOverJacksThreeKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Queen, Suit.Hearts),
                new Card(Value.Queen, Suit.Diamonds),
                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.Jack, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand TwoPairSevensOverTwosFourKicker()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Seven, Suit.Hearts),
                new Card(Value.Seven, Suit.Diamonds),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Two, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand PairJacksHighKickers()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.Jack, Suit.Diamonds),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.Ace, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand PairJacksLowKickers()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(Value.Jack, Suit.Clubs),
                new Card(Value.Three, Suit.Hearts),
                new Card(Value.Jack, Suit.Diamonds),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Two, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand ThreeOfAKind()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                 new Card(Value.Seven, Suit.Clubs),
                 new Card(Value.Seven, Suit.Hearts),
                 new Card(Value.Seven, Suit.Diamonds),
                 new Card(Value.Three, Suit.Clubs),
                 new Card(Value.Two, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand RoyalFlush()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Ten, Suit.Clubs),
                 new Card(Value.Jack, Suit.Clubs),
                 new Card(Value.Queen, Suit.Clubs),
                 new Card(Value.King, Suit.Clubs),
                 new Card(Value.Ace, Suit.Clubs),
            });
            return hand;
        }

        public static Hand OnePair()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                 new Card(Value.Eight, Suit.Clubs),
                 new Card(Value.Seven, Suit.Hearts),
                 new Card(Value.Seven, Suit.Diamonds),
                 new Card(Value.Jack, Suit.Clubs),
                 new Card(Value.Two, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand StraightJackHigh()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
               new Card(Value.Seven, Suit.Clubs),
               new Card(Value.Eight, Suit.Hearts),
               new Card(Value.Nine, Suit.Diamonds),
               new Card(Value.Ten, Suit.Clubs),
               new Card(Value.Jack, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand StraightSixHigh()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
               new Card(Value.Two, Suit.Hearts),
               new Card(Value.Three, Suit.Diamonds),
               new Card(Value.Four, Suit.Clubs),
               new Card(Value.Five, Suit.Diamonds),
               new Card(Value.Six, Suit.Clubs)
            });
            return hand;
        }

        public static Hand StraightAceLow()
        {

            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.Two, Suit.Diamonds),
                new Card(Value.Three, Suit.Hearts),
                new Card(Value.Four, Suit.Spades),
                new Card(Value.Five, Suit.Diamonds)
            });
            return hand;

        }
        

        public static Hand FiveOfAKind()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Seven, Suit.Clubs),
                 new Card(Value.Seven, Suit.Hearts),
                 new Card(Value.Seven, Suit.Diamonds),
                 new Card(Value.Seven, Suit.Spades),
                 new Card(Value.Seven, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand HighCardAce()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                 new Card(Value.Seven, Suit.Clubs),
                 new Card(Value.Nine, Suit.Hearts),
                 new Card(Value.Jack, Suit.Diamonds),
                 new Card(Value.Four, Suit.Clubs),
                 new Card(Value.Ace, Suit.Diamonds),
            });
            return hand;
        }
        
        public static Hand HighCardSeven()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Two, Suit.Clubs),
                 new Card(Value.Three, Suit.Hearts),
                 new Card(Value.Four, Suit.Diamonds),
                 new Card(Value.Five, Suit.Clubs),
                 new Card(Value.Seven, Suit.Diamonds),
            });
            return hand;
        }

        public static Hand AceHighStraightWithoutFlush()
        {
            var hand = new Hand();
            hand .AddCards(new List<Card>
            {
                new Card(Value.Ten, Suit.Hearts),
                new Card(Value.Jack,Suit.Hearts),
                new Card(Value.Queen, Suit.Hearts),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.Ace, Suit.Clubs)
            });
            return hand;
        }

        public static Hand FlushAceHighNineLow()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Nine, Suit.Hearts),
                new Card(Value.Jack, Suit.Hearts),
                new Card(Value.Queen, Suit.Hearts),
                new Card(Value.King, Suit.Hearts),
                new Card(Value.Ace, Suit.Hearts)
            });
            return hand;
            
        }

        public static Hand ThreeOfAKindThreesLowKickers()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Three, Suit.Hearts),
                new Card(Value.Three, Suit.Spades),
                new Card(Value.Three, Suit.Diamonds),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Four, Suit.Hearts)
            });
            return hand;

        }

        public static Hand ThreeOfAKindThreesHighKickers()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Three, Suit.Hearts),
                new Card(Value.Three, Suit.Spades),
                new Card(Value.Three, Suit.Diamonds),
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.King, Suit.Hearts)
            });
            return hand;

        }

        public static Hand ThreeOfAKindKingsLowKickers()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Spades),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Hearts)
            });
            return hand;

       }
        public static Hand ThreeOfAKindKingsHighKickers()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Spades),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Ace, Suit.Clubs),
                new Card(Value.Queen, Suit.Hearts)
            });
            return hand;

        }

        public static Hand HighCardNine()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Nine, Suit.Hearts),
                new Card(Value.Eight, Suit.Diamonds),
                new Card(Value.Four, Suit.Spades),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Two, Suit.Diamonds)
            });
            return hand;
        }

        public static Hand FivePairsLowFifthPair()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Queen, Suit.Spades),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.Jack, Suit.Diamonds),
                new Card(Value.Jack, Suit.Hearts),
                new Card(Value.Ten, Suit.Diamonds),
                new Card(Value.Ten, Suit.Spades),
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Two, Suit.Diamonds)
            });
            return hand;
        }

        public static Hand FivePairsHighFifthPair()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.King, Suit.Hearts),
                new Card(Value.King, Suit.Diamonds),
                new Card(Value.Queen, Suit.Spades),
                new Card(Value.Queen, Suit.Clubs),
                new Card(Value.Jack, Suit.Diamonds),
                new Card(Value.Jack, Suit.Hearts),
                new Card(Value.Ten, Suit.Diamonds),
                new Card(Value.Ten, Suit.Spades),
                new Card(Value.Nine, Suit.Clubs),
                new Card(Value.Nine, Suit.Diamonds)
            });
            return hand;
        }

    }
}
