using System;
using System.Collections.Generic;

namespace Library.Models
{
    /// <summary>
    /// The Author class is a representative of the authors in the database.
    /// </summary>
    public class Author
    {
        /// <summary>
        /// The Id of an author.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of an author.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The books written by an author (foreign key).
        /// </summary>
        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        /// Author constructor that initializes a new instance of the Books list.
        /// </summary>
        public Author()
        {
            Books = new List<Book>();
        }

        /// <summary>
        /// Useful for adding Author objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }
    }
}
