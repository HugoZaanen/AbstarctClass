﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstarctClassTutorial
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length,
            double width)
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length of {Length} and Width of {Width}");
        }
    }
}
