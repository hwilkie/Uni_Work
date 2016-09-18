using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.FlyBehaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        public string Fly()
        {
            return "I fly with wings";
        }
    }
}
