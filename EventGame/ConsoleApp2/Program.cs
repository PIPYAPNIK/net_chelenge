using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            bool[] arr = { true, false };

            Player playerForst = new Player();
            Player playerSecond = new Player();
            playerForst.BallIsReflected += Win;
            playerForst.BallIsNotReflected += Lose;
            playerForst.x = RandomyzerValue();
            playerForst.y = RandomyzerValue();
            playerForst.deg = RandomyzerValue();
            playerForst.TryReflectBall(arr[rd.Next(arr.Length)]);
        }

        public static int RandomyzerValue()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Random rand = new Random();
            return array[rand.Next(array.Length)];
        }
        public static void Win(int x, int y, int deg)
        {
            Console.WriteLine($"Пытаюсь поймать мячик, отразил в точке ({x}, {y}), мяик отлетел под углом -  {deg}");
        }

        public static void Lose()
        {
            Console.WriteLine("Вы проиграли");
        }
    }
}
