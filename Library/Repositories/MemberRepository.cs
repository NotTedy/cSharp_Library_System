using System.Collections.Generic;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    ///  The MemberRepository class is a representative of the members.
    ///  The MemberRepository class Fetches/writes objects from the database through the LibraryContext class.
    ///  It responds to requests from the service layer and either fetches and returns data, or calls
    ///  SaveChanges() on the LibraryContext to save the current changes.
    /// </summary>
    class MemberRepository : IRepository<Member, int>
    {
        LibraryContext context;

        /// <summary>
        /// The constructor of memberRepository takes in object c.
        /// from the LibraryContext class.
        /// </summary>
        /// <param name="c"> A LibraryContext that will be shared among repositories </param>
        public MemberRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Adds/creates a Member object.
        /// </summary>
        /// <param name="m"> Member object to be added. </param>
        public void Add(Member m) 
        {
            context.Members.Add(m);
        }

        /// <summary>
        /// Removes/deletes a Member object.
        /// </summary>
        /// <param name="m"> Member object to be removed. </param>
        public void Remove(Member m)
        {
            context.Members.Remove(m);
        }

        /// <summary>
        /// Retrives a Member object with specified Id.
        /// </summary>
        /// <param name="id"> Id of Member object. </param>
        /// <returns> A Member object from the database. </returns>
        public Member Find(int id) 
        {
            return context.Members.Find(id);
        }

        /// <summary>
        /// Updates Member objects.
        /// </summary>
        /// <param name="m"> Member object to be updated. </param>
        public void Edit(Member m) 
        {
            // Because the object m was retrieved through the same context, we don't need to do a lookup. 
            // We can just tell the context to save any changes that happened.
            context.SaveChanges();
            // Then why do we still pass the Member object all the way to the repository? Because the service
            // layer doesn't know we use EF. If in the future we decide to switch EF to something else, 
            // we won't have to change the service layer.
        }

        /// <summary>
        /// Retrieves all Member objects from the database.
        /// </summary>
        /// <returns> All Member objects in the database. </returns>
        public IEnumerable<Member> All() 
        {
            return context.Members;
        }
    }
}
