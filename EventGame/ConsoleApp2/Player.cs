using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class Player
    {
        public event Action <int, int, int, string> BallIsReflected;
        public event Action <string> BallIsNotReflected;
        public int x;
        public int y;
        public int deg;
        public string playerName;

        public void TryReflectBall (bool randEvent)
        {
            if (randEvent)
                BallIsReflected?.Invoke(x, y, deg, playerName);
            else
                BallIsNotReflected?.Invoke(playerName);
            Thread.Sleep(500);
        }

        public void TryWin(int x, int y, int deg, string name)
        {
            Console.WriteLine($"{name}: пытаюсь поймать мячик, отразил в точке ({x}, {y}), мяик отлетел под углом -  {deg}");
        }

        public void Lose(string name)
        {
            Console.WriteLine($"{name}: вы проиграли");
            System.Environment.Exit(0);
        }
    }
}
