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
        public void CheckFlush_Will_Return_True_With_All_Suits_Same()
        {
            var aHand = new Hand();
            aHand.TakeCards(new Card(2, 2));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(4, 2));
            aHand.TakeCards(new Card(5, 2));
            aHand.TakeCards(new Card(8, 2));
            
            Assert.That(aHand.CheckFlush().Equals(true));
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

            Assert.That(aHand.CheckStraight().Equals(true));
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

            Assert.That(aHand.CheckStraight().Equals(true));
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

            Assert.That(aHand.CheckStraightFlush().Equals(true));
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
        public void Multiples_Can_Be_Identified()
        {
            var aHand = new Hand();
            
            aHand.TakeCards(new Card(2, 0));
            aHand.TakeCards(new Card(2, 1));
            aHand.TakeCards(new Card(3, 2));
            aHand.TakeCards(new Card(4, 3));
            aHand.TakeCards(new Card(5, 4));
           
            
            Assert.That(aHand.CheckMultiples().Equals());
        }
    }
}
