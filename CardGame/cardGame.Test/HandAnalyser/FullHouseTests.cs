using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class FullHouseTests
    {
        [Test]
        public void Full_House_Should_Be_Identified_In_larger_lists_than_5()
        {
            var analyser = new FullHouseAnalyser();

            var result = analyser.IsHand(HandBuilder.FullHouseLargeHand());

            Assert.IsTrue(result);
        }

//        [TestCase(new Card(3, 1), new Card(3, 2), new Card(3, 3), new Card(4, 2), new Card(5, 2))]
//        [TestCase(new Card(3, 1), new Card(3, 2), new Card(3, 3), new Card(4, 2), new Card(5, 2))]
//        [TestCase(new Card(3, 1), new Card(3, 2), new Card(3, 3), new Card(4, 2), new Card(5, 2))]
//        [TestCase(new Card(3, 1), new Card(3, 2), new Card(3, 3), new Card(4, 2), new Card(5, 2))]
//        public void Not_A_Full_House(Card c1, Card c2, Card c3, Card c4, Card c5)
//        {
//            var hand = new Hand();
//            hand.AddCards(new List<Card> { c1,c2,c3,c4,c5});
//
//            var analyser = new FullHouseAnalyser();
//
//            var result = analyser.IsHand(hand);
//
//            Assert.IsFalse(result);
//
//        }
    }
}
