using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Square :Shape
    {
        private double _x;
        private double _y;
        private double _length;

        public Square(double x, double y, double length)
        {
            _x = x;
            _y = y;
            _length = length;
        }

        public override double AreaCalculation()
        {
            return Math.Pow(_length, 2);
        }

        public override void Move(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string GetPosition()
        {
            return $"Square position: {_x}, {_y}";
        }
    }
}
