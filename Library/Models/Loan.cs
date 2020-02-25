using System;

namespace Library.Models
{
    /// <summary>
    /// The Loan class is a representative of the loans in the database.
    /// </summary>
    public class Loan
    {
        /// <summary>
        /// The Id of a loan.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The date on which a loan was made.
        /// </summary>
        public virtual DateTime TimeOfLoan { get; set; }

        /// <summary>
        /// The last date on which a loan is to be returned.
        /// </summary>
        public virtual DateTime DueDate  { get; set; }

        /// <summary>
        /// The date on which a loan was returned.
        /// </summary>
        public virtual  DateTime TimeOfReturn { get; set; }

        /// <summary>
        /// The associated book copy of a loan (foreign key).
        /// </summary>
        public virtual BookCopy BookCopy { get; set; }

        /// <summary>
        /// The associated member of a loan (foreign key).
        /// </summary>
        public virtual Member Member { get; set; }

        /// <summary>
        /// The fine to be paid for a late return, if applicable.
        /// </summary>
        public int Fine { get; set; }

        /// <summary>
        /// Loan constructor that sets TimeOfLoan, DueDate and TimeOfReturn to the
        /// SQL minimum value and sets Fine to 0.
        /// </summary>
        public Loan()
        {
            TimeOfLoan = new DateTime(1753, 1, 1);
            DueDate = new DateTime(1753, 1, 1);
            TimeOfReturn = new DateTime(1753, 1, 1);
            Fine = 0;
        }

        /// <summary>
        /// Useful for adding Loan objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            if (TimeOfReturn == new DateTime(1753, 1, 1))
            {
                if ((DateTime.Now - DueDate).Days <= 0)
                {
                    return String.Format("[{0}]\t{1}    {2}    {3}\t  {4}", this.Id, this.TimeOfLoan.ToString("dd-MM-yyyy"),
                    this.DueDate.ToString("dd-MM-yyyy"), "On loan", this.BookCopy.Id);
                }
                else
                {
                    return String.Format("[{0}]\t{1}    {2}    {3}\t  {4}", this.Id, this.TimeOfLoan.ToString("dd-MM-yyyy"),
                    this.DueDate.ToString("dd-MM-yyyy"), "Overdue", this.BookCopy.Id);
                }
            }
            else
            {
                if (Fine == 0)
                {
                    return String.Format("[{0}]\t{1}    {2}    {3}\t  {4}", this.Id, this.TimeOfLoan.ToString("dd-MM-yyyy"),
                    this.DueDate.ToString("dd-MM-yyyy"), this.TimeOfReturn.ToString("dd-MM-yyyy"), this.BookCopy.Id);
                }
                else
                {
                    return String.Format("[{0}]\t{1}    {2}    {3}\t  {4}\t{5} kr", this.Id, this.TimeOfLoan.ToString("dd-MM-yyyy"),
                    this.DueDate.ToString("dd-MM-yyyy"), this.TimeOfReturn.ToString("dd-MM-yyyy"), this.BookCopy.Id, this.Fine);
                }
            }
        }
    }
}
