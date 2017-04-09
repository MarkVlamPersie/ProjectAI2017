﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.goal_driven_behaviour.ThinkGoals
{
    class Goal_NullThink : Goal_Think
    {
        public Goal_NullThink(World theWorld) : base(theWorld)
        {
        }
        
        public override void HandleMessageToBrain(string simpleMessage, object data)
        {
            //cant handle messages
        }

        public override string GetName()
        {
            return "Braindead";
        }
    }
}
