using Library.Models;
using Library.Services;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for adding a new loan.
    /// </summary>
    partial class LoanForm : Form
    {
        /// <summary>
        /// The date on which the loan was made.
        /// </summary>
        public DateTime TimeOfLoan;

        /// <summary>
        /// The last date on which the loan is to be returned.
        /// </summary>
        public DateTime DueDate;

        /// <summary>
        /// The associated book copy of the loan (foreign key).
        /// </summary>
        public BookCopy BookCopy;

        /// <summary>
        /// LoanForm constructor that sets up the subform.
        /// </summary>
        /// <param name="i"> The Id of the loan. </param>
        /// <param name="s"> ToString()-value of the member who made the loan. </param>
        /// <param name="bCS"> The service responsible for retreiving book copy data from the
        /// library via the book copy repository. </param>
        public LoanForm(int i, string s, BookCopyService bCS)
        {
            InitializeComponent();
            label2.Text = i.ToString();
            label3.Text = s;

            EventArgs e = new EventArgs();
            dateTimePicker1_ValueChanged(this, e);

            foreach (BookCopy bC in bCS.GetAllAvailable())
            {
                listBox1.Items.Add(bC);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeOfLoan = dateTimePicker1.Value;
            DueDate = dateTimePicker1.Value.AddDays(15);
            label8.Text = DueDate.ToString("dd-MM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a book copy.");
            }
            else
            {
                BookCopy = listBox1.SelectedItem as BookCopy;

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
