using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Library
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid regionId { get; set; }
        public string name { get; set; }

        public Library(string _name, Guid _regionId)
        {
            name = _name;
            regionId = _regionId;
        }
    }
}
