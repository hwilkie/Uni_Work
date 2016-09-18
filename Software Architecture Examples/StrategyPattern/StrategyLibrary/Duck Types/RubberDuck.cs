using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyLibrary.FlyBehaviours;
using StrategyLibrary.Quack_Behaviours;

namespace StrategyLibrary.Duck_Types
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            _flyBehaviour = new FlyNoWay();
            _quackBehaviour = new Squeak();
        }

        public override string Display()
        {
            return "I am a rubber duck";
        }
    }
}
