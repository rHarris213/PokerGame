using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class GameRules
    {
        public int CompareCards(Hand playerOneHand, Hand playerTwoHand)
        {
            var playerOneScore = 0;
            var playerTwoScore = 0;

            if (playerOneHand.CheckFlush() > playerOneScore)
                playerOneScore = playerOneHand.CheckFlush();
            if (playerOneHand.CheckStraight() > playerOneScore)
                playerOneScore = playerOneHand.CheckStraight();
            if (playerOneHand.CheckMultiples() > playerOneScore)
                playerOneScore = playerOneHand.CheckMultiples();

            if (playerTwoHand.CheckFlush() > playerOneScore)
                playerTwoScore = playerTwoHand.CheckFlush();
            if (playerTwoHand.CheckStraight() > playerTwoScore)
                playerTwoScore = playerTwoHand.CheckStraight();
            if (playerTwoHand.CheckMultiples() > playerTwoScore)
                playerTwoScore = playerTwoHand.CheckMultiples();

            if (playerOneScore == playerTwoScore)
            {
                playerOneScore = playerOneHand.CheckHighCard();
                playerTwoScore = playerTwoHand.CheckHighCard();
            }

            if (playerOneScore > playerTwoScore)
            {
                return 1;
            }
            if (playerTwoScore > playerOneScore)
            {
                return 2;
            }
            if(playerOneScore == playerTwoScore)
            {
                return 0;
            }
            return 0;
        }
    }
}
