using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class BookExemplar
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid libraryId { get; set; }
        public Guid bookId { get; set; }
        public Guid editionId { get; set; }
        public string bookCover { get; set; }

        public BookExemplar(string _bookCover, Guid _bookId, Guid _editionId, Guid _libraryId)
        {
            bookCover = _bookCover;
            bookId = _bookId;
            editionId = _editionId;
            libraryId = _libraryId;
        }
    }
}
