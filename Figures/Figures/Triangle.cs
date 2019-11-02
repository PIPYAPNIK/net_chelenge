using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    class Triangle : Shape
    {
        private double _x;
        private double _y;
        private double _deg;
        private double _sideFirstLength;
        private double _sideSecondLength;

        public Triangle (double x, double y, double deg, double sideFirstLength, double sideSecondLength)
        {
            _x = x;
            _y = y;
            _deg = deg;
            _sideFirstLength = sideFirstLength;
            _sideSecondLength = sideSecondLength;
        }

        public override double AreaCalculation()
        {
            return 0.5 * _sideFirstLength * _sideSecondLength * Math.Sin(_deg);;
        }

        public override void Move(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public override string GetPosition()
        {
            return $"Triangle position: {_x}, {_y}";
        }
    }
}
