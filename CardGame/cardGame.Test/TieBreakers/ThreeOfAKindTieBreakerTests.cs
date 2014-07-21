using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;
using CardGame;
using cardGame.Test.Builders;
using NUnit.Framework;
using cardGame.Test.TieBreakers;
using CardGame.TieBreakers;

namespace cardGame.Test.TieBreakers
{
    [TestFixture]
    class ThreeOfAKindTieBreakerTests
    {
        [Test]
        public void Three_Of_A_Kind_With_Higher_Triplet_Should_Win()
        {
            var handOne = HandBuilder.ThreeOfAKindThreesHighKickers();
            var handTwo = HandBuilder.ThreeOfAKindKingsHighKickers();

            var result = FindBestHand(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }

        [Test]
        public void Three_Of_A_Kind_With_Higher_Kicker_Should_Win_If_Triplet_Are_Same()
        {
            var handOne = HandBuilder.ThreeOfAKindKingsLowKickers();
            var handTwo = HandBuilder.ThreeOfAKindKingsHighKickers();

            var result = FindBestHand(handTwo, handOne);

            Assert.That(result.Equals(handTwo));
        }
        
        private Hand FindBestHand(Hand handTwo, Hand handOne)
        {

            var repeatingCardsComparer = new GroupsOfCardsOfSameValueTieBreaker(handOne, handTwo);

            var bestThreeOfAKindHand = repeatingCardsComparer.DetermineStrongestHand(3) ;

            if (bestThreeOfAKindHand != null)
            {
                return bestThreeOfAKindHand;
            }
            var bestKickerHand = repeatingCardsComparer.DetermineStrongestHand(1);

            return bestKickerHand;
            
        }

        


        
    }
}
