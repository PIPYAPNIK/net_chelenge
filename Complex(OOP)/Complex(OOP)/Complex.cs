using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_OOP_
{
    class Complex
    {
        private double _actual {get; set;}
        private double _imaginary { get; set; }

        public void SetValue(double actual, double imaginary)
        {
            _actual = actual;
            _imaginary = imaginary;
        }

        public static string Add (Complex first, Complex second)
        {
            return first._actual + second._actual + ", " + first._imaginary + second._imaginary + "i";
        }

        public static string Subtract (Complex first, Complex second)
        {
            return $"{first._actual - second._actual}, {first._imaginary - second._imaginary}i";
        }

        public static string Multiplicat (Complex first, Complex second)
        {
            return $"{first._actual * second._actual - first._imaginary * second._imaginary}, {first._actual * second._imaginary - second._actual * first._imaginary}i";
        }
    }
}
