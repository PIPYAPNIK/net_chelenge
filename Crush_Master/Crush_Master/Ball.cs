using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Crush_Master
{
    public class Ball : GameObject
    {
        // тем дальше будет шар. Правильнее: создать глобальную переменную DateTime и после каждого кадра записывать туда текущее время
        // А потом при каждом новом кадре(метод Update) высчитывать разниц между датой прошлого кадра и этого и умножать на скорость.
        public BallDirection Direction { get; set; } // Направление
        public int Velocity { get; set; }

        public Ball(Image sprite) : base(sprite)
        {
            Velocity = 30;
            Direction = BallDirection.RightUp;
        }


        // Разворачивание движения по горизонтальной оси
        public void ReflectHorizontal()
        {
            if (Direction == BallDirection.LeftUp)
                Direction = BallDirection.LeftBottom;
            else if (Direction == BallDirection.RightUp)
                Direction = BallDirection.RightBottom;
            else if (Direction == BallDirection.LeftBottom)
                Direction = BallDirection.LeftUp;
            else if (Direction == BallDirection.RightBottom)
                Direction = BallDirection.RightUp;
        }

        // Разворачивание движения по вертикальной оси
        public void ReflectVertical()
        {
            if (Direction == BallDirection.LeftUp)
                Direction = BallDirection.RightUp;
            else if (Direction == BallDirection.LeftBottom)
                Direction = BallDirection.RightBottom;
            else if (Direction == BallDirection.RightUp)
                Direction = BallDirection.LeftUp;
            else if (Direction == BallDirection.RightBottom)
                Direction = BallDirection.LeftBottom;
        }

        // Определение стороны столкновения и отражение направления полета мячика
        public void Collide(GameObject gameObject)
        {
            // Обьект столкнулся сверху или снизу, отражаем направление полета по горизонтали
            if (gameObject.Bounds.Left <= Bounds.X + (Bounds.Width / 2) && Bounds.X + (Bounds.Width / 2) <= gameObject.Bounds.Right)
                ReflectHorizontal();

            // Обьект столкнулся слева или справа, отражаем направление полета по вертикали
            else if (gameObject.Bounds.Top <= Bounds.Y + (Bounds.Width / 2) && Bounds.Y + (Bounds.Width / 2) <= gameObject.Bounds.Bottom)
                ReflectVertical();
        }
    }
}
