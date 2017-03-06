﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SteeringCS
{
   
    public class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double W { get; set; }

        public Vector2D() : this(0,0)
        {
        }

        public Vector2D(double x, double y, double w = 1)
        {
            X = x;
            Y = y;
            W = w;
        }

        public double Length() //Returns C
        {
            //sqrt(A^2 + B^2) = C
            return Math.Sqrt(LengthSquared());
        }

        public double LengthSquared() //Returns C^2
        {
            //A^2 + B^2 = C^2
            return Math.Pow(X, 2) + Math.Pow(Y, 2);
        }

        public Vector2D Add(Vector2D v)
        {
            this.X += v.X;
            this.Y += v.Y;
            return this;
        }

        public Vector2D Sub(Vector2D v)
        {
            this.X -= v.X;
            this.Y -= v.Y;
            return this;
        }

        public Vector2D Multiply(double value)
        {
            this.X *= value;
            this.Y *= value;
            return this;
        }

        public Vector2D Divide(double value)
        {
            if (value != 0)
            {
                this.X /= value;
                this.Y /= value;
            }
            return this;
        }

        public Vector2D Normalize() //Is this correct?
        {
            Divide(Length());
            return this;
        }

        public Vector2D truncate(double maX)
        {
            if (Length() > maX)
            {
                Normalize();
                Multiply(maX);
            }
            return this;
        }
        
        public Vector2D Clone()
        {
            return new Vector2D(this.X, this.Y);
        }
        
        public override string ToString()
        {
            return String.Format("({0},{1})", X, Y);
        }

        public Vector2D Perpendicular()
        {
            return new Vector2D(-Y, X); //Turn X and Y around and multiply one with -1
        }



        public static float ToDegrees(Vector2D v1)
        {
            Vector2D tempV = v1.Clone().Normalize();
            
            float result = (float)(Math.Atan(tempV.Y/tempV.X)/(Math.PI/180));
            if (tempV.X < 0)
            {
                result = 0 - result;
            }
            return result;
        }

        public PointF ToPointF()
        {
            return new PointF((float)this.X, (float)this.Y);
        }
        

        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            Vector2D v = v1.Clone();
            v.Add(v2);
            return v;
        }
        public static Vector2D operator -(Vector2D v1, Vector2D v2)
        {
            Vector2D v = v1.Clone();
            v.Sub(v2);
            return v;
        }

        public static Vector2D operator *(Vector2D v1, double value)
        {
            Vector2D v = v1.Clone();
            v.Multiply(value);
            return v;
        }
        public static Vector2D operator /(Vector2D v1, double value)
        {
            Vector2D v = v1.Clone();
            v.Divide(value);
            return v;
        }
    }


}
