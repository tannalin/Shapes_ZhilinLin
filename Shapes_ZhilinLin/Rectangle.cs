﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhilinLin
{
    class Rectangle : IShape
    {

        public double Length { get; set; }

        public double Width { get; set; }

        public double CalculatorArea()
        {
            return Length * Width;
        }

        public string Display()
        {
            return $"This is a rectangle, length is {Length} and it's area is {this.CalculatorArea()}";
        }
    }
}
