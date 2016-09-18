using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyLibrary.FlyBehaviours;
using StrategyLibrary.Quack_Behaviours;

namespace StrategyLibrary.Duck_Types
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehaviour = new FlyWithWings();
            _quackBehaviour = new NormalQuack();
        }

        public override string Display()
        {
            return "I am a mallard Duck!";
        }
    }
}
