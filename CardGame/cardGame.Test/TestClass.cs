using System.Collections.Generic;
using System.Linq;
using CardGame;
using NUnit.Framework;


namespace cardGame.Test
{
    [TestFixture]
    public class TestClass
    {
        

      

        [TestCase(Suit.Clubs)]
        [TestCase(Suit.Diamonds)]
        [TestCase(Suit.Hearts)]
        [TestCase(Suit.Spades)]
        public void Suits_Should_Have_13_Cards(Suit suit)
        {
            var aDeck = new Deck();

            var i = aDeck.Cards.Count(x => x.GetCardSuit() == suit);
            Assert.AreEqual(i,13);

        }
        
        
        [TestCase]
        public void No_Repeating_Cards()
        {

            var aDeck = new Deck();

            Assert.AreEqual(aDeck.Count(), aDeck.Cards.Distinct().Count());

        }

        [TestCase]
        public void Card_Suit_Is_A_Enum_That_Returns()
        {

            var fiveOfHearts = new Card(Value.Five, Suit.Hearts);

            Assert.AreEqual(fiveOfHearts.GetCardSuit(), Suit.Hearts);

        }
     
        [TestCase]
        public void deal_gives_five_Cards_to_Hand()
        {

            var aHand = new Hand();
            var aDeck = new Deck();

            aDeck.Deal(aHand);

            

            Assert.AreEqual(aHand.GetLength(), 5);

        }
        
        [TestCase]
        public void Write_Cards()
        {

            var aHand = new Hand();
            aHand.TakeCards(new Card(Value.Ace, Suit.Spades));
           

            


            

        }
    }
}
