using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Edition
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid bookId { get; set; }
        public int pageCount { get; set; }

        public Edition(Guid _bookId, int _pageCount)
        {
            bookId = _bookId;
            pageCount = _pageCount;
        }
    }
}
