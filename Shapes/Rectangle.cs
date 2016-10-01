using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public double height { get; set; }
        public double width { get; set; }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override double CalculatePerimeter()
        {
            return height * 2 + width * 2;
        }

        public override void Draw(Canvas containerControl)
        {
            throw new NotImplementedException();
        }
    }
}
