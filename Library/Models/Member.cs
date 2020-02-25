using System;
using System.Collections.Generic;

namespace Library.Models
{
    /// <summary>
    /// The Member class is a representative of the members in the database.
    /// </summary>
    public class Member
    {
        /// <summary>
        /// The Id of a member.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The personal Id of a member.
        /// </summary>
        public string PersonalID { get; set; }

        /// <summary>
        /// The name of a member.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date on which a member was registered.
        /// </summary>
        public virtual DateTime MembershipDate { get; set; }

        /// <summary>
        /// The loans made by a member (foreign key).
        /// </summary>
        public virtual ICollection<Loan> Loans { get; set; }

        /// <summary>
        /// Member constructor that initializes a new instance of the Loans list and
        /// sets MembershipDate to the SQL minimum value.
        /// </summary>
        public Member()
        {
            Loans = new List<Loan>();
            MembershipDate = new DateTime(1753, 1, 1);
        }

        /// <summary>
        /// Useful for adding Member objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} -- {2}", this.Id, this.PersonalID, this.Name);
        }
    }
}
