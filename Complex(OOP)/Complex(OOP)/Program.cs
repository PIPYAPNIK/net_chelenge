using System;

namespace Complex_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex itemFirst = new Complex();
            Complex itemSecond = new Complex();
            Complex action = new Complex();

            itemFirst.SetValue(18, 29);
            itemSecond.SetValue(21, 5);

            Complex.Addition(itemFirst, itemSecond);
            Complex.Subtraction(itemFirst, itemSecond);
            Complex.Multiplication(itemFirst, itemSecond);

            Console.ReadKey();
        }
    }
}
