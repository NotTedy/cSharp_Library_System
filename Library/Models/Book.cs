using System;
using System.Collections.Generic;

namespace Library.Models
{
    /// <summary>
    /// The Book class is a representative of the books in the database.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// The Id of a book.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The ISBN of a book.
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// The title of a book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of a book.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The author of a book (foreign key).
        /// </summary>
        public virtual Author BookAuthor { get; set; }

        /// <summary>
        /// The copies of a book (foreign key).
        /// </summary>
        public virtual ICollection<BookCopy> BookCopies { get; set; }

        /// <summary>
        /// Book constructor that initializes a new instance of the BookCopies list.
        /// </summary>
        public Book()
        {
            BookCopies = new List<BookCopy>();
        }

        /// <summary>
        /// Useful for adding Book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Title);
        }
    }
}
