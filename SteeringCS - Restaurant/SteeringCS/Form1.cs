﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SteeringCS.behaviour;

namespace SteeringCS
{
    public partial class Form1 : Form
    {
        World world;
        System.Timers.Timer timer;
        
        public const int FPS = 60;
        public const float timeDelta = 1/(float)FPS;

        public Form1()
        {
            InitializeComponent();

            world = new World(w: dbPanel1.Width, h: dbPanel1.Height);

            timer = new System.Timers.Timer();
            timer.Elapsed += Timer_Elapsed;
            timer.Interval = 1000/FPS;
            timer.Enabled = true;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            world.Update(timeDelta);
            dbPanel1.Invalidate();
        }

        private void dbPanel1_Paint(object sender, PaintEventArgs e)
        {
            world.Render(e.Graphics);
        }
        
        private void dbPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            world.Target.Pos = new Vector2D(e.X, e.Y);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'q':
                    label_CurrentBehaviour.Text = "None";
                    world.SwitchAgentBehaviour(CombineForces.Behaviours.None);
                    break;
                case 'w':
                    label_CurrentBehaviour.Text = "Seek";
                    world.SwitchAgentBehaviour(CombineForces.Behaviours.Seek);
                    break;
                case 'e':
                    label_CurrentBehaviour.Text = "Arrive";
                    world.SwitchAgentBehaviour(CombineForces.Behaviours.Arrive);
                    break;
                case 'r':
                    label_CurrentBehaviour.Text = "Wander";
                    world.SwitchAgentBehaviour(CombineForces.Behaviours.Wander);
                    break;
                
                case '1':
                    label_DecelerationSpeed.Text = "Slow";
                    world.SetArriveDeceleration(ArriveBehaviour.Deceleration.Slow);
                    break;
                case '2':
                    label_DecelerationSpeed.Text = "Normal";
                    world.SetArriveDeceleration(ArriveBehaviour.Deceleration.Normal);
                    break;
                case '3':
                    label_DecelerationSpeed.Text = "Fast";
                    world.SetArriveDeceleration(ArriveBehaviour.Deceleration.Fast);
                    break;
                case 'd':
                    world.graphVisible = !world.graphVisible;
                    break;
            }
        }
    }
}
