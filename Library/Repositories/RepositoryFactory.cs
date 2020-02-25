using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    ///  The RepositoryFactory class is used to handle the instantiation of our repositories in the application. 
    /// </summary>
    class RepositoryFactory
    {
        private LibraryContext context;

        /// <param name="c"> A Librarycontext that will be shared among repositories </param>
        public RepositoryFactory(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        ///  retrive a book repostirory instance.
        /// </summary>
        /// <returns> book repostirory instance </returns>
        public BookRepository CreateBookRepository()
        {
            return new BookRepository(context);
        }

        /// <summary>
        ///  retrive a author repostirory instance.
        /// </summary>
        /// <returns> author repostirory instance </returns>
        public AuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        /// <summary>
        ///  retrive a loan repostirory instance.
        /// </summary>
        /// <returns> loan repostirory instance </returns>
        public LoanRepository CreateLoanRepository()
        {
            return new LoanRepository(context);
        }

        /// <summary>
        ///  retrive a member repostirory instance.
        /// </summary>
        /// <returns> a member repostirory instance </returns>
        public MemberRepository CreateMemberRepository()
        {
            return new MemberRepository(context);
        }

        /// <summary>
        ///  retrive a bookcopy repostirory instance.
        /// </summary>
        /// <returns> bookcopy repostirory instance </returns>
        public BookCopyRepository CreateBookCopyRepository()
        {
            return new BookCopyRepository(context);
        }
    }
}
