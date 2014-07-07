using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.TieBreakers
{
    public interface ITieBreaker
    {
        Hand DetermineStrongestHand(Hand handOne, Hand handTwo);
    }
}
