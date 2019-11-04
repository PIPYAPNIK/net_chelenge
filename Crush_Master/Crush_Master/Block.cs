using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Crush_Master
{
    class Block : GameObject
    {
        public float Value { get; set; } // Цена/ценность/очки
        public bool IsAlive { get; set; } // Жив ли 

        public Block(Image sprite) : base(sprite)
        {
            IsAlive = true;
        }
    }
}
