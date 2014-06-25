using System.Collections.Generic;
using System.Linq;
using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;

namespace cardGame.Test.HandAnalyser
{
    [TestFixture]
    class ThreeOfAKindTests
    {
        [Test]
        public void Three_Of_A_Kind_Should_Have_Three_Cards_Of_The_Same_Value()
        {
           

            var analyser = new ThreeOfAKindAnalyser();

            var result = analyser.IsHand(HandBuilder.ThreeOfAKind());

            Assert.IsTrue(result);


        }


        [Test]
        public void Three_Of_A_Kind_Should_Not_Trigger_Work_With_More_Than_Three_Cards_Alike()
        {
          
            var analyser = new ThreeOfAKindAnalyser();

            var result = analyser.IsHand(HandBuilder.FourOfAKindSevens());

            Assert.IsFalse(result);


        }
    }
}
