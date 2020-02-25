using System.Collections.Generic;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    ///  The LoanRepository class is a representative of the Loans.
    ///  The LoanRepository class Fetches/writes objects from the database through the LibraryContext class.
    ///  It responds to requests from the service layer and either fetches and returns data, or calls
    ///  SaveChanges() on the LibraryContext to save the current changes.
    /// </summary>
    class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        /// <summary>
        /// The constructor of LoanRepository takes in object c.
        /// from the LibraryContext class.
        /// </summary>
        /// <param name="c"> A LibraryContext that will be shared among repositories </param>
        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds/creates a Loan object.
        /// </summary>
        /// <param name="l"> Loan object to be added. </param>
        public void Add(Loan l) 
        {
            context.Loans.Add(l);
        }

        /// <summary>
        /// Removes/deletes a Loan object.
        /// </summary>
        /// <param name="l"> Loan object to be removed. </param>
        public void Remove(Loan l)
        {
            context.Loans.Remove(l);
        }

        /// <summary>
        /// Retrieves a Loan object with specified Id.
        /// </summary>
        /// <param name="id"> Id of Loan object. </param>
        /// <returns> A Loan object from the database. </returns>
        public Loan Find(int id) 
        {
            return context.Loans.Find(id);
        }

        /// <summary>
        /// Updates Loan objects.
        /// </summary>
        /// <param name="l"> Loan object to be updated. </param>
        public void Edit(Loan l) 
        {
            // Because the object l was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Loan object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        /// <summary>
        /// Retrieves all Loan objects from the database.
        /// </summary>
        /// <returns> All Loan objects in the database. </returns>
        public IEnumerable<Loan> All() 
        {
            return context.Loans;
        }
    }
}
