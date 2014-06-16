using System.Collections.Generic;
using System.Linq;
using CardGame;
using NUnit.Framework;


namespace cardGame.Test
{
    [TestFixture]
    public class TestClass
    {
        

       [TestCase]
        public void NumberOfSpadesTest()
        {
            var aDeck = new Deck();

            const int name = 0;

            var actualNumberOfCards = aDeck.Cards.Count(x => x.GetCardSuit() == name);
            Assert.AreEqual(actualNumberOfCards, 13);

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void NumberOfDiamondsTest(int suit)
        {
            var aDeck = new Deck();

            var i = aDeck.Cards.Count(x => x.GetCardSuit() == suit);
            Assert.AreEqual(i, 13);

        }
        [TestCase]
        public void NumberOfClubsTest()
        {
            var aDeck = new Deck();

            const int name = 1;

            int i = aDeck.Cards.Count(x => x.GetCardSuit() == name);
            Assert.AreEqual(i, 13);

        }
        [TestCase]
        public void NumberOfHeartsTest()
        {
            var aDeck = new Deck();

            const int name = 2;

            int i = aDeck.Cards.Count(x => x.GetCardSuit() == name);
            Assert.AreEqual(i, 13);

        }
        
        [TestCase]
        public void No_Repeating_Cards()
        {

            var aDeck = new Deck();

            Assert.AreEqual(aDeck.Count(), aDeck.Cards.Distinct().Count());

        }

        [TestCase]
        public void Card_Suit_Is_A_Number_That_Returns()
        {

            var aDeck = new Deck();

            Assert.AreEqual(aDeck.GetCards()[0].GetCardSuit(), 0);

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
        public void Card_With_Invalid_Suit_Value_Given_Default_Name()
        {

            var aHand = new Hand();
            aHand.TakeCards(new Card(12,12));

            



            Assert.AreEqual(aHand.GetCards()[0].GetCardSuit(), 12);

        }
        [TestCase]
        public void Write_Cards()
        {

            var aHand = new Hand();
            aHand.TakeCards(new Card(12, 12));
           

            


            

        }
    }
}
