using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using NUnit.Framework;

namespace cardGame.Test
{
    [TestFixture]
    class CardTests
    {
        [TestCase(0,0)]
        [TestCase(3,5)]
        [TestCase(100,20)]
        [TestCase(41,41)]
        public void Created_Card_Will_Return_Correct_Suit_And_Value(int testSuitValue, int testCardValue)
        {
            var aCard = new Card(testCardValue,testSuitValue);

            Assert.That(aCard.GetCardValue().Equals(testCardValue) && aCard.GetCardSuit().Equals(testSuitValue));

        }

        [Test]
        public void Check_Hands_Are_Unique()
        {
            var deck = new Deck();
            var handOne = new Hand();
            var handTwo = new Hand();

            deck.Deal(handOne);
            deck.Deal(handTwo);

            Assert.That(!handOne.GetCards().SequenceEqual(handTwo.GetCards()));



        }

        [Test]
        public void Specific_Number_Of_Cards_Can_Be_Returned_From_Hand()
        {
        }

    }




}
