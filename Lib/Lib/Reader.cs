using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Reader
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string name { get; set; }

        public Reader(string _name)
        {
            name = _name;
        }
    }
}
