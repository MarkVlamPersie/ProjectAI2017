﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.goal_driven_behaviour
{
    abstract class Goal_Think : CompositeGoal
    {
        protected Goal_Think(World theWorld) : base(theWorld)
        {}

        
        public override void Activate()
        {
            state = Enums.State.Active;
        }

        public override int Process()
        {
            ActivateIfIdle();
            
            int subgoalStatus = ProcessSubgoals();

            if (subgoalStatus == (int)Enums.State.Complete || subgoalStatus == (int)Enums.State.Failed)
            {
                state = Enums.State.Idle;
            }

            return (int)state;
        }

        public override void Terminate()
        {
            //Only happens when brain dies.
        }



        //Checks what goal is currently active
        public bool IsCurrentActiveSubgoal(string goalName)
        {
            if (SubgoalStack.Count != 0)
                return SubgoalStack.Peek().GetName() == goalName;

            return false;
        }


        //This is a VERY crude function. But we don't have time to develop and test the Telegram messaging system.
        public abstract void HandleMessageToBrain(string simpleMessage, object data = null);


        public override string GetName()
        {
            return "Think";
        }
    }
}
