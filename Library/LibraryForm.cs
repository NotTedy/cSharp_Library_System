// -----------------------------------------------------
// Anders Köhler & Tedy Mduma
// Information Systems C: Object-Oriented Programming II
// Uppsala University
// Fall semester 2019
// -----------------------------------------------------

using Library.Forms;
using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    /// <summary>
    /// Main GUI form for the Library program.
    /// </summary>
    public partial class LibraryForm : Form
    {
        #region Properties
        /// <summary>
        /// The service responsible for retreiving book data
        /// from the library via the book repository.
        /// </summary>
        BookService bookService;
        /// <summary>
        /// The service responsible for retreiving author data
        /// from the library via the author repository.
        /// </summary>
        AuthorService authorService;
        /// <summary>
        /// The service responsible for retreiving book copy data
        /// from the library via the book copy repository.
        /// </summary>
        BookCopyService bookCopyService;
        /// <summary>
        /// The service responsible for retreiving member data
        /// from the library via the member repository.
        /// </summary>
        MemberService memberService;
        /// <summary>
        /// The service responsible for retreiving loan data
        /// from the library via the loan repository.
        /// </summary>
        LoanService loanService;
        #endregion

        #region Constructor
        /// <summary>
        /// LibraryForm constructor that sets up the database, necessary repositories and services,
        /// subscribes to events, and sets up the book, author and member lists.
        /// </summary>
        public LibraryForm()
        {
            InitializeComponent();

            // we create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();

            // we use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            bookService = new BookService(repFactory);
            authorService = new AuthorService(repFactory);
            bookCopyService = new BookCopyService(repFactory);
            memberService = new MemberService(repFactory);
            loanService = new LoanService(repFactory);

            bookService.Updated += updateBookList;
            bookCopyService.Updated += updateBookCopyList;
            authorService.Updated += updateAuthorList;
            memberService.Updated += updateMemberList;
            loanService.Updated += updateLoanList;

            EventArgs e = new EventArgs();
            updateBookList(this, e);
            updateAuthorList(this, e);
            updateMemberList(this, e);

            int[] conditions = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (int item in conditions)
            {
                comboBox1.Items.Add(item);
            }
        }
        #endregion

        #region Selected Index Changed methods
        /// <summary>
        /// Triggers when the user selects an index in the listbox lbBooks.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBookCopyList(this, e);
        }

        /// <summary>
        /// Triggers when the user selects an index in the listbox lbAuthors.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateBooksByAuthorList(this, e);
        }

        /// <summary>
        /// Triggers when the user selects an index in the listbox lbMembers.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLoanList(this, e);
        }
        #endregion

        #region Update List methods
        /// <summary>
        /// Refreshes the contents of the listbox lbBooks and clears the listbox lbBookCopies.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void updateBookList(object sender, EventArgs e)
        {
            lbBooks.Items.Clear();
            lbBookCopies.Items.Clear();

            foreach (Book book in bookService.All())
            {
                lbBooks.Items.Add(book);
            }
        }

        /// <summary>
        /// Refreshes the contents of the listbox lbBookCopies.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void updateBookCopyList(object sender, EventArgs e)
        {
            lbBookCopies.Items.Clear();

            foreach (BookCopy bookCopy in bookCopyService.GetAllFromBook(lbBooks.SelectedItem as Book))
            {
                lbBookCopies.Items.Add(bookCopy);
            }
        }

        /// <summary>
        /// Refreshes the contents of the listbox lbAuthors and clears the listbox lbBooksByAuthors.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void updateAuthorList(object sender, EventArgs e)
        {
            lbAuthors.Items.Clear();
            lbBooksByAuthors.Items.Clear();

            foreach (Author author in authorService.All())
            {
                lbAuthors.Items.Add(author);
            }
        }

        /// <summary>
        /// Refreshes the contents of the listbox lbBooksByAuthors.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void updateBooksByAuthorList(object sender, EventArgs e)
        {
            lbBooksByAuthors.Items.Clear();

            foreach (Book bookByAuthor in bookService.GetAllByAuthor(lbAuthors.SelectedItem as Author))
            {
                lbBooksByAuthors.Items.Add(bookByAuthor);
            }
        }

        /// <summary>
        /// Refreshes the contents of the listbox lbMembers and clears the listbox lbLoansByMember.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void updateMemberList(object sender, EventArgs e)
        {
            lbMembers.Items.Clear();
            lbLoansByMember.Items.Clear();

            foreach (Member member in memberService.All())
            {
                lbMembers.Items.Add(member);
            }
        }

        /// <summary>
        /// Refreshes the contents of the listbox lbLoansByMember.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void updateLoanList(object sender, EventArgs e)
        {
            lbLoansByMember.Items.Clear();

            foreach (Loan loan in loanService.GetAllFromMember((lbMembers.SelectedItem as Member).Id))
            {
                lbLoansByMember.Items.Add(loan);
            }
        }
        #endregion

        #region Double Click methods
        /// <summary>
        /// Shows the subform BookInfoForm when the user double clicks on an index in the listbox lbBooks.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbBooks_DoubleClick(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null)
            {
                BookInfoForm bookInfoForm = new BookInfoForm(lbBooks.SelectedItem as Book);
                bookInfoForm.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the subform AuthorInfoForm when the user double clicks on an index in the listbox lbAuthors.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbAuthors_DoubleClick(object sender, EventArgs e)
        {
            if (lbAuthors.SelectedItem != null)
            {
                AuthorInfoForm authorInfoForm = new AuthorInfoForm(lbAuthors.SelectedItem as Author);
                authorInfoForm.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the subform MemberInfoForm when the user double clicks on an index in the listbox lbMembers.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbMembers_DoubleClick(object sender, EventArgs e)
        {
            if (lbMembers.SelectedItem != null)
            {
                MemberInfoForm memberInfoForm = new MemberInfoForm(lbMembers.SelectedItem as Member);
                memberInfoForm.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the subform BookCopyInfoForm when the user double clicks on an index in the listbox lbBookCopies.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbBookCopies_DoubleClick(object sender, EventArgs e)
        {
            if (lbBookCopies.SelectedItem != null)
            {
                BookCopyInfoForm bookCopyInfoForm = new BookCopyInfoForm(lbBookCopies.SelectedItem as BookCopy);
                bookCopyInfoForm.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the subform BookInfoForm when the user double clicks on an index in the listbox lbBooksByAuthors.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbBooksByAuthors_DoubleClick(object sender, EventArgs e)
        {
            if (lbBooksByAuthors.SelectedItem != null)
            {
                BookInfoForm bookInfoForm = new BookInfoForm(lbBooksByAuthors.SelectedItem as Book);
                bookInfoForm.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the subform LoanInfoForm when the user double clicks on an index in the listbox lbLoansByMember.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void lbLoansByMember_DoubleClick(object sender, EventArgs e)
        {
            if (lbLoansByMember.SelectedItem != null)
            {
                LoanInfoForm loanInfoForm = new LoanInfoForm(lbLoansByMember.SelectedItem as Loan);
                loanInfoForm.ShowDialog();
            }
        }
        #endregion

        #region Change & Add Button methods

        /// <summary>
        /// Triggers when the user clicks on the button btnChange.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            var item = this.comboBox1.SelectedItem;

            if (item != null)
            {
                if (lbBookCopies.SelectedItem != null)
                {
                    int c = Int32.Parse(item.ToString());
                    BookCopy bc = (lbBookCopies.SelectedItem as BookCopy);

                    bc.Condition = c;
                    bookCopyService.Edit(bc);
                }
                else
                {
                    MessageBox.Show("Select a book copy to change.");
                }
            }
            else
            {
                MessageBox.Show("Select a value in the drop-down list.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnAddBook.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm(bookService.GetLastId() + 1, authorService);
            bookForm.ShowDialog();

            if (bookForm.DialogResult == DialogResult.OK)
            {
                Book b = new Book();
                b.ISBN = bookForm.ISBN;
                b.Title = bookForm.Title;
                b.Description = bookForm.Description;
                b.BookAuthor = bookForm.BookAuthor;

                if (lbAuthors.SelectedItem != null)
                {
                    if (b.BookAuthor == lbAuthors.SelectedItem as Author)
                    {
                        updateAuthorList(this, e);
                    }
                }

                bookService.Add(b);
                bookService.Edit(b);
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnAddAuthor.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm(authorService.GetLastId() + 1);
            authorForm.ShowDialog();

            if (authorForm.DialogResult == DialogResult.OK)
            {
                Author a = new Author();
                a.Name = authorForm.Name;

                authorService.Add(a);
                authorService.Edit(a);
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnAddMember.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm(memberService.GetLastId() + 1);
            memberForm.ShowDialog();

            if (memberForm.DialogResult == DialogResult.OK)
            {
                Member m = new Member();
                m.Name = memberForm.Name;
                m.PersonalID = memberForm.PersonalID;
                m.MembershipDate = memberForm.MembershipDate;

                memberService.Add(m);
                memberService.Edit(m);
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnAddLoan.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            if (lbMembers.SelectedItem != null)
            {
                LoanForm loanForm = new LoanForm(memberService.GetLastId() + 1, (lbMembers.SelectedItem as Member).ToString(), bookCopyService);
                loanForm.ShowDialog();

                if (loanForm.DialogResult == DialogResult.OK)
                {
                    Loan l = new Loan();
                    l.TimeOfLoan = loanForm.TimeOfLoan;
                    l.DueDate = loanForm.DueDate;
                    l.BookCopy = loanForm.BookCopy;
                    l.Member = lbMembers.SelectedItem as Member;
                    l.BookCopy.Available = false;

                    foreach (BookCopy bc in lbBookCopies.Items)
                    {
                        if (bc == l.BookCopy)
                        {
                            updateBookList(this, e);
                            break;
                        }
                    }
                    loanService.Add(l);
                    loanService.Edit(l);
                }
            }
            else
            {
                MessageBox.Show("Select a member to add a loan to.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnAddBookCopy.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnAddBookCopy_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null)
            {
                BookCopy bc = new BookCopy();
                bc.Book = lbBooks.SelectedItem as Book;

                bookCopyService.Add(bc);
                bookCopyService.Edit(bc);
            }
            else
            {
                MessageBox.Show("Select a book to add a book copy to.");
            }
        }
        #endregion

        #region Remove & Return Button methods
        /// <summary>
        /// Triggers when the user clicks on the button btnRemoveBook.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (lbBooks.SelectedItem != null)
            {
                DialogResult result;
                Book b = lbBooks.SelectedItem as Book;

                if (b.BookCopies.Count != 0)
                {
                    result = MessageBox.Show("The selected book has copies registered to it.\n\n" +
                            "Removing it will remove all copies and all loans\n" +
                            "associated with those copies.\n\n" +
                            "Do you want to proceed?", "", MessageBoxButtons.OKCancel);
                }
                else
                {
                    result = MessageBox.Show("Are you sure you want to remove the book?", "", MessageBoxButtons.OKCancel);
                }

                if (result == DialogResult.OK)
                {
                    if (lbAuthors.SelectedItem != null)
                    {
                        if (b.BookAuthor == lbAuthors.SelectedItem as Author)
                        {
                            updateAuthorList(this, e);
                        }
                    }

                    foreach (Loan l in lbLoansByMember.Items)
                    {
                        if (b == l.BookCopy.Book)
                        {
                            updateMemberList(this, e);
                            break;
                        }
                    }

                    foreach (BookCopy bc in b.BookCopies.ToList())
                    {
                        foreach (Loan l in bc.Loans.ToList())
                        {
                            loanService.Remove(l);
                        }
                        bookCopyService.Remove(bc);
                    }
                    bookService.Remove(b);
                    bookService.Edit(b);
                }
            }
            else
            {
                MessageBox.Show("Select a book to remove.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnRemoveBookCopy.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnRemoveBookCopy_Click(object sender, EventArgs e)
        {
            if (lbBookCopies.SelectedItem != null)
            {
                DialogResult result;
                BookCopy bc = lbBookCopies.SelectedItem as BookCopy;

                if (bc.Loans.Count != 0)
                {
                    result = MessageBox.Show("The selected book copy has loans registered to it.\n\n" +
                            "Removing it will remove all loans.\n\n" +
                            "Do you want to proceed?", "", MessageBoxButtons.OKCancel);
                }
                else
                {
                    result = MessageBox.Show("Are you sure you want to remove the book copy?", "", MessageBoxButtons.OKCancel);
                }

                if (result == DialogResult.OK)
                {
                    foreach (Loan l in lbLoansByMember.Items)
                    {
                        if (bc == l.BookCopy)
                        {
                            updateMemberList(this, e);
                            break;
                        }
                    }

                    foreach (Loan l in bc.Loans.ToList())
                    {
                        loanService.Remove(l);
                    }
                    bookCopyService.Remove(bc);
                    bookCopyService.Edit(bc);
                }
            }
            else
            {
                MessageBox.Show("Select a book copy to remove.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnRemoveAuthor.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnRemoveAuthor_Click(object sender, EventArgs e)
        {
            if (lbAuthors.SelectedItem != null)
            {
                DialogResult result;
                Author a = lbAuthors.SelectedItem as Author;

                if (a.Books.Count != 0)
                {
                    result = MessageBox.Show("The selected author has books registered to them.\n\n" +
                            "Removing them will remove all books and all copies\n" +
                            "associated with those books, as well as all loans\n" +
                            "associated with those copies.\n\n" +
                            "Do you want to proceed?", "", MessageBoxButtons.OKCancel);
                }
                else
                {
                    result = MessageBox.Show("Are you sure you want to remove the author?", "", MessageBoxButtons.OKCancel);
                }

                if (result == DialogResult.OK)
                {
                    foreach (Loan l in lbLoansByMember.Items)
                    {
                        if (a == l.BookCopy.Book.BookAuthor)
                        {
                            updateMemberList(this, e);
                            break;
                        }
                    }

                    foreach (Book b in a.Books.ToList())
                    {
                        foreach (BookCopy bc in b.BookCopies.ToList())
                        {
                            foreach (Loan l in bc.Loans.ToList())
                            {
                                loanService.Remove(l);
                            }
                            bookCopyService.Remove(bc);
                        }
                        bookService.Remove(b);
                    }
                    authorService.Remove(a);
                    authorService.Edit(a);
                    updateBookList(this, e);
                }
            }
            else
            {
                MessageBox.Show("Select an author to remove.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnRemoveMember.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (lbMembers.SelectedItem != null)
            {
                DialogResult result;
                Member m = lbMembers.SelectedItem as Member;

                if (m.Loans.Count != 0)
                {
                    result = MessageBox.Show("The selected member has loans registered to them.\n\n" +
                            "Removing them will remove all loans.\n\n" +
                            "Do you want to proceed?", "", MessageBoxButtons.OKCancel);
                }
                else
                {
                    result = MessageBox.Show("Are you sure you want to remove the member?", "", MessageBoxButtons.OKCancel);
                }

                if (result == DialogResult.OK)
                {
                    foreach (Loan l in m.Loans.ToList())
                    {
                        loanService.Remove(l);
                    }
                    memberService.Remove(m);
                    memberService.Edit(m);
                }
            }
            else
            {
                MessageBox.Show("Select a member to remove.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnRemoveLoan.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnRemoveLoan_Click(object sender, EventArgs e)
        {
            if (lbLoansByMember.SelectedItem != null)
            {
                DialogResult result;
                Loan l = lbLoansByMember.SelectedItem as Loan;

                result = MessageBox.Show("Are you sure you want to remove the loan?", "", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    if (l.TimeOfReturn == new DateTime(1753, 1, 1))
                    {
                        l.BookCopy.Available = true;
                    }

                    foreach (BookCopy bc in lbBookCopies.Items)
                    {
                        if (bc == l.BookCopy)
                        {
                            updateBookList(this, e);
                            break;
                        }
                    }

                    loanService.Remove(l);
                    loanService.Edit(l);
                }
            }
            else
            {
                MessageBox.Show("Select a loan to remove.");
            }
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnReturnLoan.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnReturnLoan_Click(object sender, EventArgs e)
        {
            if (lbLoansByMember.SelectedItem != null)
            {
                Loan l = lbLoansByMember.SelectedItem as Loan;

                if (l.TimeOfReturn == new DateTime(1753, 1, 1))
                {
                    ReturnForm returnForm = new ReturnForm(l.Id, l.TimeOfLoan, l.DueDate);
                    returnForm.ShowDialog();

                    if (returnForm.DialogResult == DialogResult.OK)
                    {
                        l.TimeOfReturn = returnForm.TimeOfReturn;
                        l.BookCopy.Available = true;

                        foreach (BookCopy bc in lbBookCopies.Items)
                        {
                            if (bc == l.BookCopy)
                            {
                                updateBookList(this, e);
                                break;
                            }
                        }

                        int i = (l.TimeOfReturn - l.DueDate).Days;

                        if (i > 0)
                        {
                            l.Fine = i * 10;
                            MessageBox.Show("Overdue return – fine is " + l.Fine + " kr.");
                        }
                        loanService.Edit(l);
                    }
                }
                else
                {
                    MessageBox.Show("The selected loan has already been returned.");
                }
            }
            else
            {
                MessageBox.Show("Select a loan to return.");
            }
        }
        #endregion

        #region Show Button methods
        /// <summary>
        /// Triggers when the user clicks on the button btnShowAviBookCopies.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnShowAviBookCopies_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm("Available book copies", bookCopyService);
            statusForm.ShowDialog();
        }

        /// <summary>
        /// Triggers when the user clicks on the button btnShowLoanHistory.
        /// </summary>
        /// <param name="sender"> The object raising the event. </param>
        /// <param name="e"> The event argument. </param>
        private void btnShowLoanHistory_Click(object sender, EventArgs e)
        {
            StatusForm statusForm = new StatusForm("Loan history", loanService);
            statusForm.ShowDialog();
        }
        #endregion
    }
}
