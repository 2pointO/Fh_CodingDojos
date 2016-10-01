using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Shapes
{
    public class Circle : Shape
    {
        public double diameter { get; set; }

        public override double CalculateArea()
        {
            return Math.Pow(diameter/2,2)* Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * diameter;
        }

        public override void Draw(Canvas containerControl)
        {
            throw new NotImplementedException();
        }
    }
}
