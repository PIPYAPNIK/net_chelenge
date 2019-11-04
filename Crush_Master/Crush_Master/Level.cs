using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Crush_Master
{
    class Level : IDraw
    {
        // для создания(заполнения) данного объекта лучше создать отдельную форму/UI в которой уже и проводить заполнение. Для сохранения можно использовать сериализацию.

        public List<Block> Blocks { get; set; }

        public void Draw(Graphics graphics)
        {
            if (Blocks == null || Blocks.Count <= 0)
                return;

            foreach (var block in Blocks)
                if (block.IsAlive)
                    block.Draw(graphics);
        }

        public bool IsComplited()
        {
            return Blocks != null && Blocks.Count >= 0 && Blocks.Count(b => b.IsAlive) <= 0;
        }
    }
}
