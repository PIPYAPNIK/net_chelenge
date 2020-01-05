using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class VisitToLibrary
    {
        public Guid readerId { get; set; }
        public Guid libraryId { get; set; }
        public Guid bookExemplarId { get; set; }

        public VisitToLibrary(Guid _readerId, Guid _libraryId, Guid _bookExemplarId)
        {
            readerId = _readerId;
            libraryId = _libraryId;
            bookExemplarId = _bookExemplarId;
        }
    }
}
