using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    class Book
    {
        public Guid Id { get; } = Guid.NewGuid();
        public Guid genreId { get; set; }
        public string name { get; set; }
        public string author { get; set; }

        public Book(string _name, string _author, Guid _genreId)
        {
            name = _name;
            author = _author;
            genreId = _genreId;
        }
    }
}
