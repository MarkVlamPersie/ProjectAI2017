﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS.entity
{
    abstract class Obstacle : BaseGameEntity
    {
        protected Obstacle(Vector2D pos, World w) : base(pos, w)
        {}


        public override void Update(float delta)
        {}
    }
}
