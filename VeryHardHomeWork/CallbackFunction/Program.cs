using System;
using System.Collections.Generic;
using System.Linq;

namespace CallbackFunction
{
    public delegate bool ArrayFilter(int i);

    static class MyExtensionMetod
    {
        public static bool MyAll(this int[] data, ArrayFilter filter)
        {
            int count = 0;
            for (int i = 0; i <= data.Length - 1; i++)
            {
                if (filter(i))
                {
                    count++;
                }
            }

            if (count == data.Length - 1) return true;
            else return false;
        }

        public static bool MyAny(this int[] data, ArrayFilter filter)
        {
            int count = 0;
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (filter(i))
                {
                    count++;
                }
            }

            if (count > 0)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] filterArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine(filterArray.MyAll(MinTen));

            Console.ReadKey();
        }

        public static bool Odd(int s)
        {
            return s % 2 == 0 && s < 0;
        }

        public static bool MinTen(int s)
        {
            return s < 6;
        }

        public static bool MinHundred(int s)
        {
            return s < 100;
        }

    }
}
