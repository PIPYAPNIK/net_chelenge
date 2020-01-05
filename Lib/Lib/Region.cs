using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Region
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string name { get; set; }

        public Region(string _name)
        {
            name = _name;
        }
    }
}
