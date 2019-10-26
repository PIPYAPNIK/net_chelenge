using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Player
    {
        public event Action <int, int, int> BallIsReflected;
        public event Action BallIsNotReflected;
        public int x;
        public int y;
        public int deg;

        public void TryReflectBall (bool randEvent)
        {
            if (randEvent)
                BallIsReflected?.Invoke(x, y, deg);
            else
                BallIsNotReflected?.Invoke();
        }
    }
}
