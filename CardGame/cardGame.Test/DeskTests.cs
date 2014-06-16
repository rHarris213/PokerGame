using System;
using CardGame;
using NUnit.Framework;

namespace cardGame.Test
{
    [TestFixture]
    public class DeskTests
    {
        [Test]
        public void CheckDeckContains52Cards()
        {
            var deck = new Deck();
            
      
            Assert.That(deck.Count(), Is.EqualTo(52));
        }

        [Test]
        [ExpectedException(typeof (Exception))]
        public void ShouldTestSomething()
        {
            CalculateAge();
        }

        [Test]
        public void TestName()
        {
            Assert.Throws<Exception>(() => CalculateAge());
        }

        private int CalculateAge()
        {
            throw new Exception();
        }

        
    }
}