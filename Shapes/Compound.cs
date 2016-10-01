using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Shapes
{
    public class Compound : Shape
    {
        public List<Shape> ShapeList { get; set; }

        public override double CalculateArea()
        {
            double foo = 0;

            foreach (var shape in ShapeList)
            {
                foo += shape.CalculateArea();
            }

            return foo;
        }

        public override double CalculatePerimeter()
        {
            double pi = 0;

            foreach (var shape in ShapeList)
            {
                pi += shape.CalculatePerimeter();
            }

            return pi;
        }

        public override void Draw(Canvas containerControl)
        {
            foreach (var shape in ShapeList)
            {
                shape.Draw(containerControl); ;
            }
        }
    }
}
