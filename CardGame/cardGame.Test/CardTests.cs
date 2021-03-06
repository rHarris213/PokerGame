﻿using System;
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
        [TestCase(Value.Ace,Suit.Hearts)]
        [TestCase(Value.Three, Suit.Clubs)]
        [TestCase(Value.Four,Suit.Diamonds)]
        [TestCase(Value.Jack, Suit.Spades)]
        public void Created_Card_Will_Return_Correct_Suit_And_Value(Value testCardValue, Suit testSuitValue)
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
