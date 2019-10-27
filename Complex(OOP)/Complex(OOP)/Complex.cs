using System;
using System.Collections.Generic;
using System.Text;

namespace Complex_OOP_
{
    class Complex
    {
        private double actual {get; set;}
        private double imaginary { get; set; }

        public void SetValue(double actual, double imaginary)
        {
            this.actual = actual;
            this.imaginary = imaginary;
        }

        public static void Addition (Complex first, Complex second)
        {
            Console.WriteLine(first.actual + second.actual + ", " + first.imaginary + second.imaginary + "i");
        }

        public static void Subtraction(Complex first, Complex second)
        {
            Console.WriteLine($"{first.actual - second.actual}, {first.imaginary - second.imaginary}i");
        }

        public static void Multiplication(Complex first, Complex second)
        {
            Console.WriteLine($"{first.actual * second.actual - first.imaginary * second.imaginary}, {first.actual * second.imaginary - second.actual * first.imaginary}i");
        }
    }
}
