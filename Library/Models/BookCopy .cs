using System;
using System.Collections.Generic;

namespace Library.Models
{
    /// <summary>
    /// The BookCopy class is a representative of the book copies in the database.
    /// </summary>
    public class BookCopy
    {
        /// <summary>
        /// The Id of a book copy (primary key).
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The associated book of a book copy (foreign key).
        /// </summary>
        public virtual Book Book { get; set; }

        /// <summary>
        /// The condition of a book copy.
        /// </summary>
        public int Condition { get; set; }

        /// <summary>
        /// The availability status of a book copy.
        /// </summary>
        public bool Available { get; set; }

        /// <summary>
        /// The loans made on a book copy (foreign key).
        /// </summary>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// BookCopy constructor that sets Condition to 10, sets Available to true
        /// and initializes a new instace of the Loans list.
        /// </summary>
        public BookCopy()
        {
            Available = true;
            Condition = 10;
            Loans = new List<Loan>();
        }

        /// <summary>
        /// Useful for adding BookCopy objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            if (Available)
            {
                return String.Format("[{0}] -- {1} -- {2} -- {3}", this.Id, this.Book.Title, this.Condition, "Available");
            }
            else
            {
                return String.Format("[{0}] -- {1} -- {2} -- {3}", this.Id, this.Book.Title, this.Condition, "On loan");
            }
        }
    }
}
