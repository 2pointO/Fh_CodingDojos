using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Shapes
{
    public abstract class Shape :IComparable<Shape>
    {

        public Point CurrentPosition { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public abstract void Draw(Canvas containerControl);

        public int CompareTo(Shape other)
        {
            if (other.CalculateArea() == this.CalculateArea()) return 0;
            else if (other.CalculateArea() > this.CalculateArea()) return -1;
            else return 1;
        }

    }
}
