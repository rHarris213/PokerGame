using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.HandAnalysers;
using CardGame.TieBreakers;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
namespace CardGame
{
    public class HandContainer
    {
        public IHand ResolveAnalyser()
        {
            var analyser = new UnityContainer();
            
            analyser.RegisterType<IHand, Hand>();

            return analyser.Resolve<IHand>();

        }
    }
}
