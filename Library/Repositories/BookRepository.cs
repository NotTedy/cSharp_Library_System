using System.Collections.Generic;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    ///  The BookRepository class is a representative of the books.
    ///  The BookRepository class Fetches/writes objects from the database through the LibraryContext class.
    ///  It responds to requests from the service layer and either fetches and returns data, or calls
    ///  SaveChanges() on the LibraryContext to save the current changes.
    /// </summary>
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        /// <summary>
        /// The constructor of BookRepository takes in object c.
        /// from the LibraryContext class.
        /// </summary>
        /// <param name="c"> A LibraryContext that will be shared among repositories </param>
        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds/creates a Book object.
        /// </summary>
        /// <param name="b"> Book object to be added. </param>
        public void Add(Book b) 
        {
            context.Books.Add(b);
        }

        /// <summary>
        /// Removes/deletes a Book object.
        /// </summary>
        /// <param name="b"> Book object to be removed. </param>
        public void Remove(Book b)
        {
            context.Books.Remove(b);
        }

        /// <summary>
        /// Retrieves a Book object with specified Id.
        /// </summary>
        /// <param name="id"> Id of Book object. </param>
        /// <returns> A Book object from the database. </returns>
        public Book Find(int id) 
        {
            return context.Books.Find(id);
        }

        /// <summary>
        /// Updates Book objects.
        /// </summary>
        /// <param name="b"> Book object to be updated. </param>
        public void Edit(Book b) 
        {
            // Because the object b was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Book object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        /// <summary>
        /// Retrieves all Book objects from the database.
        /// </summary>
        /// <returns> All Book objects in the database. </returns>
        public IEnumerable<Book> All() 
        {
            return context.Books;
        }
    }
}
