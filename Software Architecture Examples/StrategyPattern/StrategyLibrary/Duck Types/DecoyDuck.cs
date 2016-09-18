using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyLibrary.FlyBehaviours;
using StrategyLibrary.Quack_Behaviours;

namespace StrategyLibrary.Duck_Types
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            _flyBehaviour = new FlyNoWay();
            _quackBehaviour = new MuteQuack();
        }

        public override string Display()
        {
            return "I am a decoy Duck";
        }
    }
}
