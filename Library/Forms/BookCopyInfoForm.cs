using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for displaying information about a book copy.
    /// </summary>
    partial class BookCopyInfoForm : Form
    {
        /// <summary>
        /// BookCopyInfoForm constructor that sets up the subform.
        /// </summary>
        /// <param name="bc"> The book copy to be displayed. </param>
        public BookCopyInfoForm(BookCopy bc)
        {
            InitializeComponent();
            label5.Text = bc.Id.ToString();
            label9.Text = bc.Book.Title;
            label13.Text = bc.Condition.ToString();

            if (bc.Available)
            {
                label11.Text = "Yes";
            }
            else
            {
                label11.Text = "No";
            }
            label1.Text = bc.Loans.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
