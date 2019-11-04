using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Crush_Master
{
    public class GameObject : IDraw
    {
        public Image Sprite { get; set; } // Спрайт

        public Point Position { get; set; } // Положение

        public int Width { get { return Sprite.Width; } }// Ширина
        public int Height { get { return Sprite.Height; } }// Высота

        public Rectangle Bounds { get { return new Rectangle((int)Position.X, (int)Position.Y, Width, Height); } } // Границы обьекта 


        public GameObject(Image sprite)
        {
            Sprite = sprite;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawImage(Sprite, Bounds);
        }
    }
}
