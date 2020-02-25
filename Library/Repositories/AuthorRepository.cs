using System.Collections.Generic;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    ///  The AuthorRepository class is a representative of the authors.
    ///  The AuthorRepository class Fetches/writes objects from the database through the LibraryContext class.
    ///  It responds to requests from the service layer and either fetches and returns data, or calls
    ///  SaveChanges() on the LibraryContext to save the current changes.
    /// </summary>
    class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        /// <summary>
        /// The constructor of AuthorRepository takes in object c.
        /// from the LibraryContext class.
        /// </summary>
        /// <param name="c"> A LibraryContext that will be shared among repositories </param>
        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds/creates an Author object.
        /// </summary>
        /// <param name="a"> Author object to be added. </param>
        public void Add(Author a) 
        {
            context.Authors.Add(a);
        }

        /// <summary>
        /// Removes/deletes an Author object. 
        /// </summary>
        /// <param name="a"> Author object to be removed. </param>
        public void Remove(Author a)
        {
            context.Authors.Remove(a);
        }

        /// <summary>
        /// Retrieves an Author object with specified Id.
        /// </summary>
        /// <param name="id"> Id of Author object. </param>
        /// <returns> An Author object from the database. </returns>
        public Author Find(int id)
        {
            return context.Authors.Find(id);
        }

        /// <summary>
        /// Updates Author objects.
        /// </summary>
        /// <param name="a"> Author object to be updated. </param>
        public void Edit(Author a)
        {
            // Because the object a was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Author object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        /// <summary>
        /// Retrieves all Author objects from the database.
        /// </summary>
        /// <returns> All Author objects in the database. </returns>
        public IEnumerable<Author> All() 
        {
            return context.Authors;
        }
    }
}
