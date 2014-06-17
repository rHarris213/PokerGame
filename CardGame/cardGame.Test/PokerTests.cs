using System.Collections.Generic;
using System.Linq;
using CardGame;
using NUnit.Framework;

namespace cardGame.Test
{
    [TestFixture]
    class PokerTests
    {
        [Test]
        public void CheckHighCard_Returns_Highest_Card_Value()
        {
            
            var aHand = new Hand();
            aHand.TakeCards(new Card(2,2));
            aHand.TakeCards(new Card(6,2));
            aHand.TakeCards(new Card(3,2));
            
            Assert.That(aHand.CheckHighCard().Equals(6));
        }
        
        [Test]
        public void Returns_Highest_Card_Value()
        {

            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(6, 2));
            aHand.TakeCards(new Card(3, 2));

            Assert.That(aHand.CheckHighCard().Equals(6));
        }

        [Test]
        public void CheckFlush_Can_Be_Identified_With_All_Suits_Same()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(5, 2));
            aHand.TakeCards(new Card(8, 2));
            
            Assert.That(aHand.CheckFlush().Equals(5));
        }

        [Test]
        public void CheckStraight_Will_Return_True_With_All_Suits_Same()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(5, 3));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(6, 0));

            Assert.That(aHand.CheckStraight().Equals(4));
        }
        [Test]
        public void CheckStraight_Will_Return_True_With_Ace_Low()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(5, 3));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(14, 0));

            Assert.That(aHand.CheckStraight().Equals(4));
        }

        [Test]
        public void StraightFlush_Can_Be_Identified()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(5, 2));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(14, 2));

            Assert.That(aHand.CheckStraightFlush().Equals(8));
        }

        [Test]
        public void Royal_Flush_Can_Be_Identified()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(10, 2));
            aHand.TakeCards(new Card(11, 2));
            aHand.TakeCards(new Card(12, 2));
            aHand.TakeCards(new Card(13, 2));
            aHand.TakeCards(new Card(14, 2));

            Assert.That(aHand.CheckRoyalFlush().Equals(true));
        }

        [Test]
        public void Three_Of_A_Kind_Can_Be_Determined()
        {
            var aHand = new Hand();
            
            aHand.TakeCards(new Card(3, 0));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(5, 4));
           
            
            Assert.That(aHand.CheckMultiples().Equals(3));
        }

        [Test]
        public void Pair_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(3, 0));
            aHand.TakeCards(new Card(2, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(6, 4));


            Assert.That(aHand.CheckMultiples().Equals(1));
        }

        [Test]
        public void Two_Pair_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(2, 0));
            aHand.TakeCards(new Card(2, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(6, 4));


            Assert.That(aHand.CheckMultiples().Equals(2));
        }

        [Test]
        public void Four_Of_A_Kind_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(4, 0));
            aHand.TakeCards(new Card(4, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(6, 4));


            Assert.That(aHand.CheckMultiples().Equals(7));
        }

        [Test]
        public void Full_House_Can_Be_Determined()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(3, 0));
            aHand.TakeCards(new Card(3, 1));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(4, 4));


            Assert.That(aHand.CheckMultiples().Equals(6));
        }

        [Test]
        public void Winner_Can_Be_Determined()
        {
            var poker = new GameRules();
            
            var playerOne = new Hand();

            playerOne.TakeCards(new Card(13, 0));
            playerOne.TakeCards(new Card(3, 1));
            playerOne.TakeCards(new Card(4, 2));
            playerOne.TakeCards(new Card(5, 3));
            playerOne.TakeCards(new Card(7, 4));

            var playerTwo = new Hand();

            playerTwo.TakeCards(new Card(14, 0));
            playerTwo.TakeCards(new Card(3, 1));
            playerTwo.TakeCards(new Card(2, 2));
            playerTwo.TakeCards(new Card(5, 3));
            playerTwo.TakeCards(new Card(7, 4));

            Assert.That(poker.CompareCards(playerOne, playerTwo).Equals(2));

        }

        [Test]
        public void Cards_Can_Be_Returned()
        {
            var aHand = new Hand();

            aHand.TakeCards(new Card(2, 0));
            aHand.TakeCards(new Card(2, 1));
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(5, 4));

          

            Assert.That(aHand.GetCards().Count == 4);
        }

        [Test]
        public void Royal_Flush_Should_Only_Contain_Cards_From_The_Same_Suit()
        {
            // arrange
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 1),
                new Card(12, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
            var analyser = new RoyalFlushHandAnalyser(royalFlush);
            // act
            var result = analyser.IsHand();
            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Royal_Flush_Should_not_Contain_Cards_From_other_suits()
        {
            // arrange
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 2),
                new Card(12, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
            var analyser = new RoyalFlushHandAnalyser(royalFlush);
            // act
            var result = analyser.IsHand();
            // assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Royal_Flush_Should_Contain_correct_sequence_of_cards()
        {
            // arrange
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 1),
                new Card(12, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
            var analyser = new RoyalFlushHandAnalyser(royalFlush);
            // act
            var result = analyser.IsHand();
            // assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Royal_Flush_Should_not_Contain_incorrect_sequence_of_cards()
        {
            // arrange
            var royalFlush = new List<Card>
            {
                new Card(10, 1),
                new Card(11, 1),
                new Card(8, 1),
                new Card(13, 1),
                new Card(14, 1)
            };
            var analyser = new RoyalFlushHandAnalyser(royalFlush);
            // act
            var result = analyser.IsHand();
            // assert
            Assert.IsFalse(result);
        }

        [Test]
        public void Straight_Flush_Should_Contain_Cards_Of_The_Same_Suit()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Straight_Flush_Should_Not_Contain_Cards_Of_The_Same_Suit()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 2),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }

        [Test]
        public void Straight_Flush_Should_Contain_Correct_Sequence_Of_Cards()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Straight_Flush_Should_Not_Contain_Inorrect_Sequence_Of_Cards()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(9, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }

        [Test]
        public void Straight_Flush_Should_Allow_Ace_To_Be_Low()
        {
            var straightFlush = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(14, 1)
            };

            var analyser = new StraightFlushAnalyser(straightFlush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Four_Of_A_Kind_Should_Contain_Same_Card_Values()
        {
            var fourOfAKind = new List<Card>
            {
                new Card(2, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(9, 1)
            };

            var analyser = new FourOfAKindAnalyser(fourOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Four_Of_A_Kind_Should_Not_Be_Counted_When_Five_Of_A_Kind()
        {
            var fourOfAKind = new List<Card>
            {
                new Card(2, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(2, 1)
            };

            var analyser = new FourOfAKindAnalyser(fourOfAKind);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }

        [Test]
        public void Full_House_Should_Be_Identified_In_larger_lists_than_5()
        {
            var fullHouse = new List<Card>
            {
                new Card(1, 1),
                new Card(2, 2),
                new Card(2, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new FullHouseAnalyser(fullHouse);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        

        [Test]
        public void Flush_Should_Contain_A_Single_Suit()
        {
            var flush = new List<Card>
            {
                new Card(2, 1),
                new Card(4, 1),
                new Card(6, 1),
                new Card(8, 1),
                new Card(10, 1)
            };

            var analyser = new FlushAnalyser(flush);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Straight_Should_Contain_Correct_Sequence_Of_Cards()
        {
            var straight = new List<Card>
            {
                new Card(2, 1),
                new Card(3, 1),
                new Card(4, 1),
                new Card(5, 1),
                new Card(6, 1)
            };

            var analyser = new StraightAnalyser(straight);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Have_Three_Cards_Of_The_Same_Value()
        {
            var threeOfAKind = new List<Card>
            {
               
                new Card(1, 2),
                new Card(2, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Work_With_More_Than_Five_Cards()
        {
            var threeOfAKind = new List<Card>
            {
                new Card(1, 2),
                new Card(2, 3),
                new Card(4, 2),
                new Card(5, 1),
                new Card(7, 2),
                new Card(8, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Work_With_Less_Than_Five_Cards()
        {
            var threeOfAKind = new List<Card>
            {
              
                new Card(8, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }

        [Test]
        public void Three_Of_A_Kind_Should_Not_Trigger_Work_With_More_Than_Three_Cards_Alike()
        {
            var threeOfAKind = new List<Card>
            {
                new Card(8, 3),
                new Card(9, 3),
                new Card(9, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new ThreeOfAKindAnalyser(threeOfAKind);

            var result = analyser.IsHand();

            Assert.IsFalse(result);


        }
        [Test]
        public void Two_Pairs_Should_Have_Two_Sets_Of_Cards_With_Same_Value()
        {
            var twoPair = new List<Card>
            {
               
                new Card(1, 2),
                new Card(2, 3),
                new Card(2, 2),
                new Card(9, 1),
                new Card(9, 1)
            };

            var analyser = new TwoPairAnalyser(twoPair);

            var result = analyser.IsHand();

            Assert.IsTrue(result);


        }


    }

    internal class TwoPairAnalyser
    {
        public TwoPairAnalyser(List<Card> twoPair)
        {
            throw new System.NotImplementedException();
        }
    }

    internal class ThreeOfAKindAnalyser
    {
        private readonly List<Card> _hand; 
        public ThreeOfAKindAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            for (var i = 0; i < 15; i++)
            {
                IEnumerable<Card> cardsOfSameValue = _hand.Where(obj => obj.GetCardValue() == i);


                if (cardsOfSameValue.Count() == 3)
                {
                    return true;

                }
               
            }
            return false;
        }
    }

    internal class StraightAnalyser
    {
        private readonly List<Card> _hand; 
        public StraightAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int cardsChecked = 0;
            int? expectedCard = null;
            foreach (var card in _hand.OrderBy(c => c.GetCardValue()))
            {
                if (!expectedCard.HasValue)
                {
                    expectedCard = card.GetCardValue();
                }
                if (cardsChecked == 4 && expectedCard == 6 && card.GetCardValue() == 14)
                {
                    return true;
                }
                if ( card.GetCardValue() != expectedCard)
                {

                    return false;
                }

                cardsChecked ++;
                expectedCard ++;

            }
            return true;
        }
    }

    internal class FlushAnalyser
    {
        private readonly List<Card> _hand; 
        public FlushAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int? suit = null;
            foreach (var card in _hand)
            {
                if (suit.HasValue && suit != card.GetCardSuit())
                {
                    return false;
                }
                suit = card.GetCardSuit();
            }
            return true;
        }
    }

    internal class FullHouseAnalyser
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

    internal class FourOfAKindAnalyser
    {
        private readonly List<Card> _hand ;
        public FourOfAKindAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {

            for (var i = 0; i < 15; i ++)
            {
                IEnumerable<Card> fourMatchCheck = _hand.Where(obj => obj.GetCardValue() == i);


                if (fourMatchCheck.Count() == 4)
                {
                    return true;

                }
            }
            return false;
        }
    }

    internal class StraightFlushAnalyser
    {
        private readonly List<Card> _hand;

        public StraightFlushAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int? suit = null;
            int? expectedCard = null;
            int cardsChecked = 0;

            foreach (var card in _hand.OrderBy(c => c.GetCardValue()))
            {
                if (!expectedCard.HasValue)
                {
                    expectedCard = card.GetCardValue();
                }
                if (cardsChecked == 4 && expectedCard == 6 && card.GetCardValue() == 14)
                {
                    return true;
                }
               
                if ((suit.HasValue && suit.Value != card.GetCardSuit())|| card.GetCardValue() != expectedCard)
                {
                   
                    return false;
                }
                suit = card.GetCardSuit();
                expectedCard ++;
                cardsChecked++;
               

            }
            return true;
        }
    }

    internal class RoyalFlushHandAnalyser
    {
        private readonly List<Card> _hand;

        public RoyalFlushHandAnalyser(List<Card> hand)
        {
            _hand = hand;
        }

        public bool IsHand()
        {
            int? suit = null;
            int expectedCard = 10;
            foreach (var card in _hand.OrderBy(c => c.GetCardValue()))
            {
                if ((suit.HasValue && suit.Value != card.GetCardSuit()) || (card.GetCardValue() != expectedCard))
                {
                    return false;
                }
                expectedCard++;
                suit = card.GetCardSuit();
            }
            return true;
        }
    }
}
