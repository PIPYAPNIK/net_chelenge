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

            Console.WriteLine(Complex.Add(itemFirst, itemSecond));
            Console.WriteLine(Complex.Subtract(itemFirst, itemSecond));
            Console.WriteLine(Complex.Multiplicat(itemFirst, itemSecond));

            Console.ReadKey();
        }
    }
}
