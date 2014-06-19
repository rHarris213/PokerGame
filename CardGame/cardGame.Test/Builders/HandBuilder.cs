using System.Collections.Generic;
using CardGame;

namespace cardGame.Test.Builders
{
    public static class HandBuilder
    {
        public static Hand StraightFlush()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            });

            return hand;
        }

        public static Hand RandomHand()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 2),
                new Card(5, 1),
                new Card(6, 1)
            });

            return hand;
        }

        public static Hand StraightFlushWithAceLow()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(14, 1)
            });

            return hand;
        }

        public static Hand Flush()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(4, 1),
                new Card(6, 1),
                new Card(8, 1),
                new Card(10, 1)
            });
            return hand;
        }

        public static Hand FourOfAKind()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(9, 1)
            });

            return hand;
        }

        public static Hand FullHouse()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(1, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            });
            return hand;
        }

        public static Hand TwoPair()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(1, 2),
                new Card(2, 3),
                new Card(2, 2),
                new Card(9, 1),
                new Card(9, 1)
            });
            return hand;
        }

        public static Hand ThreeOfAKind()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(1, 2),
                new Card(2, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            });
            return hand;
        }

        public static Hand RoyalFlush()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(10, 1),
                new Card(11, 1),
                new Card(12, 1),
                new Card(13, 1),
                new Card(14, 1)
            });
            return hand;
        }

        public static Hand OnePair()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {

                new Card(2, 2),
                new Card(2, 3),
                new Card(3, 2),
                new Card(4, 1),
                new Card(5, 1)
            });
            return hand;
        }

        public static Hand Straight()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            });
            return hand;
        }

        public static Hand FiveOfAKind()
        {
            var hand = new Hand();
            hand.AddCards(new List<Card>
            {
                new Card(2, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(2, 5)
            });
            return hand;
        }
    }
}
