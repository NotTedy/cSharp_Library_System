using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models {
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext> {
        protected override void Seed(LibraryContext context) {
            base.Seed(context);

            Book monteCristo = new Book() {
                Title = "The Count of Monte Cristo"
            };

            Book twilight = new Book()
            {
                Title = "Twilight"
            };

            Book newMoon = new Book()
            {
                Title = "New moon"
            };

            Book harryPotter = new Book()
            {
                Title = "Harry Potter and the goblet of fire"
            };


            BookCopy monteCristo1 = new BookCopy()
            {
                Book = monteCristo, Condition = 5
            };

            BookCopy twilight1 = new BookCopy()
            {
                Book = twilight,
                Condition = 2,
                Available = false
            };

            BookCopy newMoon1 = new BookCopy()
            {
                Book = newMoon,
                Condition = 3,
                Available = false
            };

            BookCopy harryPotter1 = new BookCopy()
            {
                Book = harryPotter,
                Condition = 5,
            };


            Author stephenieMeyer = new Author()
            {
                Name = "Stephenie Meyer"
            };

            newMoon.BookAuthor = stephenieMeyer;
            twilight.BookAuthor = stephenieMeyer;

            Author rowling = new Author()
            {
                Name = "J.K Rowling"
            };

            harryPotter.BookAuthor = rowling;

            Author charles = new Author()
            {
                Name = "Charles Manson"
            };

            monteCristo.BookAuthor = charles;

            Member thomas = new Member()
            {
               PersonalID = "20001021-5510", Name = "Thomas", MembershipDate = new DateTime(2019, 10, 25)
            };

            Member orvar = new Member()
            {
                PersonalID = "19951021-8610",
                Name = "Orvar",
                MembershipDate = new DateTime(2019, 10, 29)
            };

            Member lisa = new Member()
            {
                PersonalID = "20100621-7711",
                Name = "Lisa",
                MembershipDate = new DateTime(2019, 11, 05)
            };


            Loan lan = new Loan()
            {
                Member = orvar, BookCopy = twilight1,
                TimeOfLoan = new DateTime(2019,10,20),
                DueDate = new DateTime(2019, 10, 30)
            };

            Loan lan1 = new Loan()
            {
                Member = thomas,
                BookCopy = newMoon1,
                TimeOfLoan = new DateTime(2019, 09, 30),
                DueDate = new DateTime(2019, 10, 08)
            };

            Loan lan2 = new Loan()
            {
                Member = lisa,
                BookCopy = monteCristo1,
                TimeOfLoan = new DateTime(2019, 05, 08),
                DueDate = new DateTime(2019, 06, 09),
                TimeOfReturn = new DateTime(2019, 06, 08)
            };

            // <summary>
            /// Adds the Book to the DbSet of books.
            /// </summary>
            context.Books.Add(monteCristo);
            context.Books.Add(twilight);
            context.Books.Add(newMoon);
            context.Books.Add(harryPotter);

            // <summary>
            /// Adds the Bookcopy to the DbSet of bookcopies.
            /// </summary>
            context.BookCopies.Add(twilight1);
            context.BookCopies.Add(monteCristo1);
            context.BookCopies.Add(newMoon1);
            context.BookCopies.Add(harryPotter1);

            // <summary>
            /// Adds the Author to the DbSet of authors.
            /// </summary>
            context.Authors.Add(stephenieMeyer);
            context.Authors.Add(rowling);
            context.Authors.Add(charles);

            // <summary>
            /// Adds the Member to the DbSet of members.
            /// </summary>
            context.Members.Add(thomas);
            context.Members.Add(orvar);
            context.Members.Add(lisa);

            // <summary>
            /// Adds the Loan to the DbSet of loans.
            /// </summary>
            context.Loans.Add(lan);
            context.Loans.Add(lan1);
            context.Loans.Add(lan2);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
