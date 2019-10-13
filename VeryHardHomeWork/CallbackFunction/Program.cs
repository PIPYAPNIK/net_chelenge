using System;
using System.Collections.Generic;
using System.Linq;

namespace CallbackFunction
{
    class Program
    {
        public delegate bool ArrayFilter (int[] data);
        static void Main(string[] args)
        {
            int[] filterArray = { 1, 2, 3, 4, 5, 6, -1, -2, -3, -4, -5, -6 };

            Filter(filterArray, AnyOdd);

            Console.ReadKey();
        }

        public static void Filter(int[] data, ArrayFilter filter)
        {
            Console.WriteLine(filter(data));
        }


        public static bool AnyOdd(int[] data)
        {
            return data.Any(s => (s % 2 == 0) && (s < 0));
        }

        public static bool AllMinTen(int[] data)
        {
            return data.All(s => s < 10);
        }

        public static bool AnyMinHundred(int[] data)
        {
            return data.Any(s => s < 100);
        }

    }
}
