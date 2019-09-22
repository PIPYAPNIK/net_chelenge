using System;

namespace ArrayInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayTwoDimensionalWidth = 3;
            int arrayTwoDimensionalHeight = 3;
            int count = 0;

            string[,] arrayTwoDimensional = new string[arrayTwoDimensionalWidth, arrayTwoDimensionalHeight];
            string[] arrayOneDimensional = new string[arrayTwoDimensionalWidth * arrayTwoDimensionalHeight];

            for (int i = 0; i < arrayTwoDimensionalWidth; i++)
            {
                for (int j = 0; j < arrayTwoDimensionalHeight; j++)
                {
                    arrayTwoDimensional[i, j] = $"{(i, j)}";
                    Console.Write($"{arrayTwoDimensional[i, j]} ");
                    arrayOneDimensional[count] = arrayTwoDimensional[i, j];
                    count++;
                }
                Console.WriteLine("");
            }

            Console.WriteLine("");

            for (int i = 0; i < arrayOneDimensional.Length; i++)
            {
                Console.Write($"{arrayOneDimensional[i]} ");
            }
            Console.ReadKey();
        }
    }
}
