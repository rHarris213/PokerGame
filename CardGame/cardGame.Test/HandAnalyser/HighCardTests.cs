using CardGame;
using CardGame.HandAnalysers;
using cardGame.Test.Builders;
using NUnit.Framework;


namespace cardGame.Test.HandAnalyser
{
    class HighCardTests
    {
        [Test]
        public void Pair_Should_Not_Include_Multiple_Sets_Of_Two_Cards_Of_The_Same_Value()
        {
           

            var analyser = new HighCardAnalyser();

            var result = analyser.IsHand(HandBuilder.TwoPair());

            Assert.IsFalse(result);


        }
    }

    internal class HighCardAnalyser
    {
        public bool IsHand(Hand twoPair)
        {
            throw new System.NotImplementedException();
        }
    }
}
