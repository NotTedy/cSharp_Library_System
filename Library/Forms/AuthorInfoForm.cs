using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for displaying information about an author.
    /// </summary>
    partial class AuthorInfoForm : Form
    {
        /// <summary>
        /// AuthorInfoForm constructor that sets up the subform.
        /// </summary>
        /// <param name="a"> The author to be displayed. </param>
        public AuthorInfoForm(Author a)
        {
            InitializeComponent();
            label13.Text = a.Id.ToString();
            label11.Text = a.Name;
            label1.Text = a.Books.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
