using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    /// <summary>
    ///  The BookCopyService class executes the queries requested by the GUI. 
    ///  A service does its job by interacting with the corresponding repository.
    ///  When a service manipulates the data using a repository, 
    ///  it lets the GUI know by raising the Updated event.
    ///  The service objects never deals with the LibraryContext directly. 
    /// </summary>
    class BookCopyService : IService
    {
        /// <summary>
        /// Event to be raised whenever the contents of the database are altered.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        BookCopyRepository bookCopyRepository;

        /// <summary>
        /// A repository factory, so the service can create its own repository.
        /// </summary>
        /// <param name="rFactory"> Services create its own repository. </param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.bookCopyRepository = rFactory.CreateBookCopyRepository();
        }

        /// <summary>
        /// Gets all the book copies in the library.
        /// </summary>
        /// <returns> book copies </returns>
        public IEnumerable<BookCopy> All()
        {
            return bookCopyRepository.All();
        }
        
        /// <summary>
        /// Gets all the book copies of a book.
        /// </summary>
        /// <param name="b"> Book to be searched for. </param>
        /// <returns> book copies of a book </returns>
        public IEnumerable<BookCopy> GetAllFromBook(Book b)
        {
            return bookCopyRepository.All().Where(x => x.Book == b);
        }

        /// <summary>
        /// Gets all the available book copies in the library.
        /// </summary>
        /// <returns> available book copies </returns>
        public IEnumerable<BookCopy> GetAllAvailable()
        {
            return bookCopyRepository.All().Where(x => x.Available);
        }

        /// <summary>
        /// Adds a new book copy to the catalogue.
        /// </summary>
        /// <param name="b"> Book copy to be added. </param>
        public void Add(BookCopy b)
        {
            bookCopyRepository.Add(b);
        }

        /// <summary>
        /// Removes a book copy from catalogue.
        /// </summary>
        /// <param name="b"> Book copy to be removed. </param>
        public void Remove(BookCopy b)
        {
            bookCopyRepository.Remove(b);
        }

        /// <summary>
        /// Makes sure that the given book copy object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"> Book copy to be edited. </param>
        public void Edit(BookCopy b)
        {
            bookCopyRepository.Edit(b);
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
