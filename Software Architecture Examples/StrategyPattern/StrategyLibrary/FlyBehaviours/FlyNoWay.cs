﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.FlyBehaviours
{
    public class FlyNoWay : IFlyBehaviour
    {
        public string Fly()
        {
            return "I cannot fly";
        }
    }
}