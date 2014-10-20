﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometriska_figurer
{
    public class Rectangle : Shape
    {
        //Egenskaper
        public override double Area
        {
            get { return Length * Width; }

        }

        
        public override double Perimeter
        {
            get { return 2 * Length + 2 * Width; }
        }

        //Konstruktor
        public Rectangle(double length, double width)
            : base(length, width)
        {

        }
    }
}
