using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhilinLin
{
    class Circle : IShape
    {
        public double Radius { get; set; }

        public double CalculatorArea()
        {
            return this.Radius * (Math.PI);
        }

        public string Display()
        {
            return $"This is a circle. It's radius is {Radius}, and it's area is {this.CalculatorArea()}";
         }
    }
}
