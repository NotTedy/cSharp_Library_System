using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for adding a new author.
    /// </summary>
    partial class AuthorForm : Form
    {
        /// <summary>
        /// The name of the author.
        /// </summary>
        public string Name;

        /// <summary>
        /// AuthorForm constructor that sets up the subform.
        /// </summary>
        /// <param name="i"> The Id of the author. </param>
        public AuthorForm(int i)
        {
            InitializeComponent();
            label2.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please type in a name.");
            }
            else
            {
                Name = textBox1.Text;

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
