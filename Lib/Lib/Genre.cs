using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Genre
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string name { get; set; }

        public Genre(string _name)
        {
            name = _name;
        }
    }
}
