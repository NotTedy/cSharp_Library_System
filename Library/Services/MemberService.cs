using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Services
{
    /// <summary>
    ///  The MemberService class executes the queries requested by the GUI. 
    ///  A service does its job by interacting with the corresponding repository.
    ///  When a service manipulates the data using a repository, 
    ///  it lets the GUI know by raising the Updated event.
    ///  The service objects never deals with the LibraryContext directly. 
    /// </summary>
    class MemberService : IService
    {
        /// <summary>
        /// Event to be raised whenever the contents of the database are altered.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        private MemberRepository memberRepository;

        /// <summary>
        /// A repository factory, so the service can create its own repository.
        /// </summary>
        /// <param name="rFactory"> Services create its own repository. </param>
        public MemberService(RepositoryFactory rFactory)
        {
            this.memberRepository = rFactory.CreateMemberRepository();
        }

        /// <summary>
        /// Gets all the members in the library.
        /// </summary>
        /// <returns> members </returns>
        public IEnumerable<Member> All()
        {
            return memberRepository.All();
        }

        /// <summary>
        /// Gets the Id of the last member.
        /// </summary>
        /// <returns> member Id </returns>
        public int GetLastId()
        {
            return memberRepository.All().Max(x => x.Id);
        }

        /// <summary>
        /// Adds a new member to the catalogue.
        /// </summary>
        /// <param name="m"> Member to be added. </param>
        public void Add(Member m)
        {
            memberRepository.Add(m);
        }

        /// <summary>
        /// Removes a member from the catalogue.
        /// </summary>
        /// <param name="m"> Member to be removed. </param>
        public void Remove(Member m)
        {
            memberRepository.Remove(m);
        }

        /// <summary>
        /// Makes sure that the given Member object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="m"> Member to be edited. </param>
        public void Edit(Member m)
        {
            memberRepository.Edit(m);
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
