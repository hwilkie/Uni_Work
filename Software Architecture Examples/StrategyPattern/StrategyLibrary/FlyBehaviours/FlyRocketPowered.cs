using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.FlyBehaviours
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        public string Fly()
        {
            return "I can fly like a rocket duck!";
        }
    }
}
