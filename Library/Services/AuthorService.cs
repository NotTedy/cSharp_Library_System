using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    /// <summary>
    ///  The AuthorService class executes the queries requested by the GUI. 
    ///  A service does its job by interacting with the corresponding repository.
    ///  When a service manipulates the data using a repository, 
    ///  it lets the GUI know by raising the Updated event.
    ///  The service objects never deals with the LibraryContext directly. 
    /// </summary>
    class AuthorService : IService
    {
        /// <summary>
        /// Event to be raised whenever the contents of the database are altered.
        /// </summary>
        public event EventHandler Updated;
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        AuthorRepository authorRepository;

        /// <summary>
        /// A repository factory, so the service can create its own repository.
        /// </summary>
        /// <param name="rFactory"> Services create its own repository. </param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        /// <summary>
        /// Gets all the authors in the library.
        /// </summary>
        /// <returns> books </returns>
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        /// <summary>
        /// Gets the Id of the last author.
        /// </summary>
        /// <returns> author id </returns>
        public int GetLastId()
        {
            return authorRepository.All().Max(x => x.Id);
        }

        /// <summary>
        /// Adds a new author to the catalogue.
        /// </summary>
        /// <param name="a"> Author to be added. </param>
        public void Add(Author a)
        {
            authorRepository.Add(a);
        }

        /// <summary>
        /// Removes an author from the catalogue.
        /// </summary>
        /// <param name="a"> Author to be removed. </param>
        public void Remove(Author a)
        {
            authorRepository.Remove(a);
        }

        /// <summary>
        /// Makes sure that the given author object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="a"> Author to be edited. </param>
        public void Edit(Author a)
        {
            authorRepository.Edit(a);
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
