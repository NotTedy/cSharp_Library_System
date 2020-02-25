using Library.Models;
using Library.Services;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for adding a new book.
    /// </summary>
    partial class BookForm : Form
    {
        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        public string ISBN;

        /// <summary>
        /// The Title of the book.
        /// </summary>
        public string Title;

        /// <summary>
        /// The Description of the book.
        /// </summary>
        public string Description;

        /// <summary>
        /// The author of the book (foreign key).
        /// </summary>
        public Author BookAuthor;

        /// <summary>
        /// LoanForm constructor that sets up the subform.
        /// </summary>
        /// <param name="i"> The Id of the book. </param>
        /// <param name="aS"> The service responsible for retreiving author data from the
        /// library via the author repository. </param>
        public BookForm(int i, AuthorService aS)
        {
            InitializeComponent();
            label2.Text = i.ToString();

            foreach (Author a in aS.All())
            {
                listBox1.Items.Add(a);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please type in an ISBN.");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please type in a title.");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Please type in a description.");
            }
            else if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an author.");
            }
            else
            {
                ISBN = textBox1.Text;
                Title = textBox2.Text;
                Description = textBox3.Text;
                BookAuthor = listBox1.SelectedItem as Author;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
