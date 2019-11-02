using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    abstract class Shape
    {
        public abstract double AreaCalculation();
        public abstract string GetPosition();
        public abstract void Move(double x, double y);
    }
}
