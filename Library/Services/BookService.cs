using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    /// <summary>
    ///  The BookService class executes the queries requested by the GUI. 
    ///  A service does its job by interacting with the corresponding repository.
    ///  When a service manipulates the data using a repository, 
    ///  it lets the GUI know by raising the Updated event.
    ///  The service objects never deals with the LibraryContext directly. 
    /// </summary>
    class BookService : IService
    {
        /// <summary>
        /// Event to be raised whenever the contents of the database are altered.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        /// <summary>
        /// A repository factory, so the service can create its own repository.
        /// </summary>
        /// <param name="rFactory"> Services create its own repository. </param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }

        /// <summary>
        /// Gets all the books in the library.
        /// </summary>
        /// <returns> books </returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        /// <summary>
        /// Gets all the books that have a title containing a string.
        /// </summary>
        /// <param name="a"> String to be searched for. </param>
        /// <returns> books containing string in title </returns>
        public IEnumerable<Book> GetAllThatContainsInTitle(string a)
        {
            return bookRepository.All().Where(b => b.Title.Contains(a));
        }

        /// <summary>
        /// Gets all the books written by an author.
        /// </summary>
        /// <param name="a"> Author to search for. </param>
        /// <returns> book by author </returns>
        public IEnumerable<Book> GetAllByAuthor(Author a)
        {
            return bookRepository.All().Where(x => x.BookAuthor == a);
        }

        /// <summary>
        /// Gets the Id of the last book.
        /// </summary>
        /// <returns> book Id </returns>
        public int GetLastId()
        {
            return bookRepository.All().Max(x => x.Id);
        }

        /// <summary>
        /// Adds a new book to the catalogue.
        /// </summary>
        /// <param name="b"> Book to be added. </param>
        public void Add(Book b)
        {
            bookRepository.Add(b);
        }

        /// <summary>
        /// Removes a book from the catalogue.
        /// </summary>
        /// <param name="b"> Book to be removed. </param>
        public void Remove(Book b)
        {
            bookRepository.Remove(b);
        }

        /// <summary>
        /// Makes sure that the given book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b"> Book to be edited. </param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);
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
