using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shapes
{
    public abstract class Shape
    {

        public Point Position { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public abstract void Draw();

    }
}
