using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Library
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid regionId { get; set; }
        public string title { get; set; }

        public Library(string _title, Guid _regionId)
        {
            title = _title;
            regionId = _regionId;
        }
    }
}
