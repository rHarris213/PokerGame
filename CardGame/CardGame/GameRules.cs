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
        public void CompareCards(Hand playerOneHand, Hand playerTwoHand)
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;

            playerOneHand.CheckFlush();
            playerOneHand.CheckStraight();
            playerOneHand.CheckHighCard();

        }
    }
}
