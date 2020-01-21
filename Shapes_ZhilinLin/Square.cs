using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhilinLin
{
    class Square : IShape
    {
        public double Length
        {
            get; set;
        }

        public double CalculatorArea()
        {
            return Length * Length;
        }

        public string Display()
        {
           return $"This is a square, the radius is {Length}, it's area is {this.CalculatorArea()}";
        }
    }
}
