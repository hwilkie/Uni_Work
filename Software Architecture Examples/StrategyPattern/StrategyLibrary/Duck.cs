using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyLibrary.FlyBehaviours;
using StrategyLibrary.Quack_Behaviours;

namespace StrategyLibrary
{
    public abstract class Duck
    {
        protected IQuackBehaviour _quackBehaviour;
        protected IFlyBehaviour _flyBehaviour;


        public IFlyBehaviour FlyBehaviour
        {
            set { _flyBehaviour = value; }
        }

        public abstract string Display();

        public string PerformFly()
        {
            return _flyBehaviour.Fly();
        }

        public string PerformQuack()
        {
            return _quackBehaviour.Quack();
        }

    }
}
