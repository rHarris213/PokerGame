using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class OnePair
    {
        [Test]
        public void Pair_Should_Include_Two_Cards_Of_The_Same_Value()
        {
           

            var analyser = new OnePairAnalyser();

            var result = analyser.IsHand(HandBuilder.OnePair());

            Assert.IsTrue(result);


        }

        [Test]
        public void Pair_Should_Not_Include_Multiple_Sets_Of_Two_Cards_Of_The_Same_Value()
        {
           

            var analyser = new OnePairAnalyser();

            var result = analyser.IsHand(HandBuilder.TwoPair());

            Assert.IsFalse(result);


        }

        [Test]
        public void Pair_Should_Not_Include_Three_Of_A_Kind_As_Pair()
        {
           var analyser = new OnePairAnalyser();

            var result = analyser.IsHand(HandBuilder.ThreeOfAKind());

            Assert.IsFalse(result);


        }
    }
}
