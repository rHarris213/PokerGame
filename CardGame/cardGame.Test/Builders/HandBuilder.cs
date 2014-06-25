using System.Collections.Generic;
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

        public static Hand Flush()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Two, Suit.Clubs),
                new Card(Value.Three, Suit.Clubs),
                new Card(Value.Four, Suit.Clubs),
                new Card(Value.Five, Suit.Clubs),
                new Card(Value.Seven, Suit.Clubs)
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

        public static Hand TwoPair()
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

        public static Hand Straight()
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

        public static Hand AceHighFlushNoStraight()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(Value.Ten, Suit.Hearts),
                new Card(Value.Jack, Suit.Hearts),
                new Card(Value.Eight, Suit.Hearts),
                new Card(Value.Queen, Suit.Hearts),
                new Card(Value.Ace, Suit.Hearts)
            });
            return hand;
        }

       

    }
}
