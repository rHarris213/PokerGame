using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class TwoPairTests
    {
        [Test]
        public void Two_Pairs_Should_Have_Two_Sets_Of_Cards_With_Same_Value()
        {
       
            var analyser = new TwoPairAnalyser();

            var result = analyser.IsHand(HandBuilder.TwoPair());

            Assert.IsTrue(result);


        }

        [Test]
        public void Two_Pairs_Should_Not_Include_Three_Of_A_Kind()
        {
           

            var analyser = new TwoPairAnalyser();

            var result = analyser.IsHand(HandBuilder.ThreeOfAKind());

            Assert.IsFalse(result);


        }
    }
}
