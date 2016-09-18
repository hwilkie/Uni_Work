using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.Quack_Behaviours
{
    public class Squeak : IQuackBehaviour
    {
        public string Quack()
        {
            return "I squeak";
        }
    }
}
