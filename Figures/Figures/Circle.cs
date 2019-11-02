using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Circle : Shape
    {
        private double _x;
        private double _y;
        private double _radius;

        public Circle (double x, double y, double radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override double AreaCalculation()
        {
            return Math.PI * _radius;
        }

        public override void Move(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string GetPosition()
        {
            return $"Circle position: {_x}, {_y}";
        }
    }
}
