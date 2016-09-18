using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.Quack_Behaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        public string Quack()
        {
            return "I cant do quacks";
        }
    }
}
