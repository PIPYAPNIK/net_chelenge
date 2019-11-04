using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Crush_Master
{
    class SpriteData
    {
        static readonly Dictionary<string, Image> _sprites = new Dictionary<string, Image>();
        public static string ImagesFolderPath { get; set; } // папка со спрайтами

        static SpriteData()
        {
            ImagesFolderPath = Path.Combine(Environment.CurrentDirectory, "Sprite");
        }

        // костыльно, но суть ясна
        public static Image Load(string name)
        {
            if (_sprites.ContainsKey(name))
                return _sprites[name];

            var img = Image.FromFile(Path.Combine(ImagesFolderPath, name));
            _sprites.Add(name, img);
            return img;
        }
    }
}
