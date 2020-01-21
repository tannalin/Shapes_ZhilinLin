using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_ZhilinLin
{
    class GUI
    {
        public void ShowMenu()
        {
            Console.WriteLine("Calculator shape's area!");
            Console.WriteLine("What kind of shape you want to calculator?");
        }

        public IShape getShape()
        {
            IShape shape = new Circle();
            Console.WriteLine("Shape: ");
            var shapeKey = Console.ReadKey();
            switch (shapeKey.Key)
            {
                case ConsoleKey.C:
                    shape = new Circle();
                    Console.WriteLine("Please enter your circle's radius: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    ((Circle)shape).Radius = radius; 
                    break;
                case ConsoleKey.R:
                    shape = new Rectangle();
                    Console.WriteLine("Please enter your rectangle's length: ");
                    double length = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter your rectangle's width: ");
                    double width = Convert.ToDouble(Console.ReadLine());
                    ((Rectangle)shape).Length = length;
                    ((Rectangle)shape).Width = width;
                    break;
                case ConsoleKey.S:
                    shape = new Square();
                    Console.WriteLine("Please enter your rectangle's length: ");
                    double length1 = Convert.ToDouble(Console.ReadLine());
                    ((Square)shape).Length = length1;
                    break;
            }
            return shape;
        }
       
    }
}
