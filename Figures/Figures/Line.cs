using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Line : Shape
    {
        private double _x;
        private double _y;
        private double _length;

        public Line(double x, double y, double length)
        {
            _x = x;
            _y = y;
            _length = length;
        }

        public override double AreaCalculation()
        {
            return 0.0;
        }

        public override void Move(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string GetPosition()
        {
            return $"Line position: {_x}, {_y}";
        }
    }
}
