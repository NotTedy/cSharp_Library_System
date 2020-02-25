using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for displaying information about a book.
    /// </summary>
    partial class BookInfoForm : Form
    {
        /// <summary>
        /// BookInfoForm constructor that sets up the subform.
        /// </summary>
        /// <param name="b"> The book to be displayed. </param>
        public BookInfoForm(Book b)
        {
            InitializeComponent();
            label2.Text = b.Id.ToString();
            label3.Text = b.ISBN;
            label7.Text = b.Title;
            label5.Text = b.Description;
            label9.Text = b.BookAuthor.Name;
            label11.Text = b.BookCopies.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
