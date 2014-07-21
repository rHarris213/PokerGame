using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;
using CardGame.TieBreakers;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class MultiplesTieBreakerTests
    {
        [TestCase]
        public void Should_Check_Subsequent_Multiples_If_Previous_Multiples_Are_Equal_Until_Multiples_Exhausted()
        {
            

            var handOne = HandBuilder.FivePairsHighFifthPair();
            var handTwo = HandBuilder.FivePairsLowFifthPair();

            var pairBreaker = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);

            var result = pairBreaker.DetermineStrongestHand(2);

            Assert.That(result.Equals(handOne));
        }

        [TestCase]
        public void Should_Return_Null_If_Multiples_Are_The_Same()
        {
            

            var handOne = HandBuilder.FivePairsHighFifthPair();
            var handTwo = HandBuilder.FivePairsHighFifthPair();

            var pairBreaker = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);
            var result = pairBreaker.DetermineStrongestHand(2);

            Assert.IsNull(result);
        }

        [TestCase]
        public void Should_Not_Be_Affected_By_Different_Multiples()
        {
            

            var handOne = HandBuilder.FourOfAKindKings();
            var handTwo = HandBuilder.TwoPairSevensOverTwosFourKicker();

            var pairBreaker = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);
            var result = pairBreaker.DetermineStrongestHand(2);

            Assert.That(result.Equals(handTwo));
        }


        [Test]
        public void Same_Hand_Should_Result_In_Draw()
        {
           

            var handOne = HandBuilder.HighCardAce();
            var handTwo = HandBuilder.HighCardAce();

            var pairBreaker = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);
            var result = pairBreaker.DetermineStrongestHand(2);

            Assert.IsNull(result);
        }

        

       
    }
}
