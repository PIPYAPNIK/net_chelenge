using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            bool[] arr = { true, false, true, true, true, true };

            Player playerFirst = new Player();
            playerFirst.BallIsReflected += playerFirst.TryWin;
            playerFirst.BallIsNotReflected += playerFirst.Lose;

            Player playerSecond = new Player();
            playerSecond.BallIsReflected += playerSecond.TryWin;
            playerSecond.BallIsNotReflected += playerSecond.Lose;

            bool loop = true;
            while (loop)
            {
                loop = arr[rd.Next(arr.Length)];

                playerFirst.x = RandomyzerValue();
                playerFirst.y = RandomyzerValue();
                playerFirst.deg = RandomyzerValue();
                playerFirst.playerName = "First player";

                playerSecond.x = RandomyzerValue();
                playerSecond.y = RandomyzerValue();
                playerSecond.deg = RandomyzerValue();
                playerSecond.playerName = "Second player";

                playerFirst.TryReflectBall(arr[rd.Next(arr.Length)]);
                playerSecond.TryReflectBall(arr[rd.Next(arr.Length)]);

                if (loop == false) playerFirst.TryReflectBall(loop);
            }
        }

        public static int RandomyzerValue()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Random rand = new Random();
            return array[rand.Next(array.Length)];
        }
    }
}
