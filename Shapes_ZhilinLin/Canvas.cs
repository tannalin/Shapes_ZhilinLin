﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhilinLin
{
    public class Canvas
    {
    
 
        public void ShowShape(IShape shape)
        {
            Console.WriteLine(shape.CalculatorArea());
            Console.WriteLine(shape.Display());
        }
    }
}