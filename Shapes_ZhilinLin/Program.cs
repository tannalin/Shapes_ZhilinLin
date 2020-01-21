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
            bool yesToContinue = true;
            GUI display = new GUI();
            Canvas canvas = new Canvas();
            while (yesToContinue)
            {
                Console.Clear();
                display.ShowMenu();
                var shape = display.getShape();

                canvas.ShowShape(shape);
                Console.Write("Continue: (Y/N)? ");
                var contKey = Console.ReadKey();
                yesToContinue = (contKey.Key == ConsoleKey.Y ? true : false);
            }
        }
    }
}
