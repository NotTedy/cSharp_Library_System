using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    /// <summary>
    ///  The LoanService class executes the queries requested by the GUI. 
    ///  A service does its job by interacting with the corresponding repository.
    ///  When a service manipulates the data using a repository, 
    ///  it lets the GUI know by raising the Updated event.
    ///  The service objects never deals with the LibraryContext directly. 
    /// </summary>
    class LoanService : IService
    {
        /// <summary>
        /// Event to be raised whenever the contents of the database are altered.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        LoanRepository loanRepository;

        /// <summary>
        /// A repository factory, so the service can create its own repository.
        /// </summary>
        /// <param name="rFactory"> Services create its own repository. </param>
        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        /// <summary>
        /// Gets all the loans in the library.
        /// </summary>
        /// <returns> loans </returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        /// <summary>
        /// Gets all the loans made by a member.
        /// </summary>
        /// <param name="id"> Id of member. </param>
        /// <returns> loans by member </returns>
        public IEnumerable<Loan> GetAllFromMember(int id)
        {
            return loanRepository.All().Where(l => l.Member.Id == id);
        }

        /// <summary>
        /// Gets all the loans made on a book copy.
        /// </summary>
        /// <param name="id"> Id of book copy. </param>
        /// <returns> loans on book copy </returns>
        public IEnumerable<Loan> GetAllWithBookCopy(int id)
        {
            return loanRepository.All().Where(l => l.BookCopy.Id == id);
        }

        /// <summary>
        /// Gets all the active loans.
        /// </summary>
        /// <returns> active loans </returns>
        public IEnumerable<Loan> GetAllOnLoan()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn == new DateTime(1753, 1, 1));
        }

        /// <summary>
        /// Gets all the returned loans.
        /// </summary>
        /// <returns> non-active loans </returns>
        public IEnumerable<Loan> GetAllReturned()
        {
            return loanRepository.All().Where(l => l.TimeOfReturn != new DateTime(1753, 1, 1));
        }

        /// <summary>
        /// Adds a new loan to the catalogue.
        /// </summary>
        /// <param name="item"> Loan to be added. </param>
        public void Add(Loan l)
        {
            loanRepository.Add(l);
        }

        /// <summary>
        /// Removes a loan from the catalogue.
        /// </summary>
        /// <param name="item"> Loan to be removed. </param>
        public void Remove(Loan l)
        {
            loanRepository.Remove(l);
        }

        /// <summary>
        /// Makes sure that the given loan object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="l"> Loan to be edited. </param>
        public void Edit(Loan l)
        {
            loanRepository.Edit(l);
            OnUpdate(new EventArgs());
        }

        /// <summary>
        /// Raises the Updated() event.
        /// </summary>
        /// <param name="e"> Event argument for the Updated() event. </param>
        protected virtual void OnUpdate(EventArgs e)
        {
            if (Updated != null)
            {
                Updated(this, e);
            }
        }
    }
}
