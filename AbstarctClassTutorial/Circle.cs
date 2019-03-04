﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctClassTutorial
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }
    }
}
