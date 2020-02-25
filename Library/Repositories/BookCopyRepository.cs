using System.Collections.Generic;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    ///  The BookCopyRepository class is a representative of the book copies.
    ///  The BookCopyRepository class Fetches/writes objects from the database through the LibraryContext class.
    ///  It responds to requests from the service layer and either fetches and returns data, or calls
    ///  SaveChanges() on the LibraryContext to save the current changes.
    /// </summary>
    class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        /// <summary>
        /// The constructor of BookCopyRepository takes in object c.
        /// from the LibraryContext class.
        /// </summary>
        /// <param name="c"> A LibraryContext that will be shared among repositories </param>
        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds/creates a BookCopy object.
        /// </summary>
        /// <param name="bc"> BookCopy object to be added. </param>
        public void Add(BookCopy bc) 
        {
            context.BookCopies.Add(bc);
        }

        /// <summary>
        /// Removes/deletes a BookCopy object.
        /// </summary>
        /// <param name="bc"> BookCopy object to be removed. </param>
        public void Remove(BookCopy bc)
        {
            context.BookCopies.Remove(bc);
        }

        /// <summary>
        /// Retrieves a BookCopy object with specified Id.
        /// </summary>
        /// <param name="id"> Id of BookCopy object. </param>
        /// <returns> A BookCopy object from the database. </returns>
        public BookCopy Find(int id) 
        {
            return context.BookCopies.Find(id);
        }

        /// <summary>
        /// Updates BookCopy objects.
        /// </summary>
        /// <param name="bc"> BookCopy object to be updated. </param>
        public void Edit(BookCopy bc)
        {
            // Because the object bc was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the BookCopy object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        /// <summary>
        /// Retrieves all BookCopy objects from the database.
        /// </summary>
        /// <returns> All BookCopy objects in the database. </returns>
        public IEnumerable<BookCopy> All() 
        {
            return context.BookCopies;
        }
    }
}
