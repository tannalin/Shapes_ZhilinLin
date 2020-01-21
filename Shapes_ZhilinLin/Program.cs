using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhilinLin
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 5.0;

            Canvas canvas = new Canvas();
            canvas.ShowShape(circle);

            Console.ReadKey();
        }
    }
}
