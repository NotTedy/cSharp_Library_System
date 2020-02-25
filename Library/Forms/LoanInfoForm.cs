using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for displaying information about a loan.
    /// </summary>
    public partial class LoanInfoForm : Form
    {
        /// <summary>
        /// LoanInfoForm constructor that sets up the subform.
        /// </summary>
        /// <param name="l"> The loan to be displayed. </param>
        public LoanInfoForm(Loan l)
        {
            InitializeComponent();
            label2.Text = l.Id.ToString();
            label3.Text = l.TimeOfLoan.ToString("dd-MM-yyyy");
            label7.Text = l.DueDate.ToString("dd-MM-yyyy");

            if (l.TimeOfReturn != new DateTime(1753, 1, 1))
            {
                label5.Text = l.TimeOfReturn.ToString("dd-MM-yyyy");

                if ((l.TimeOfReturn - l.DueDate).Days <= 0)
                {
                    label15.Text = "No";
                }
                else
                {
                    label15.Text = "Yes";
                }
            }
            else
            {
                label5.Text = "N/A";

                if ((DateTime.Now - l.DueDate).Days <= 0)
                {
                    label15.Text = "No";
                }
                else
                {
                    label15.Text = "Yes";
                }
            }
            label9.Text = l.BookCopy.Id.ToString();
            label13.Text = l.BookCopy.Book.Title;
            label11.Text = l.Member.PersonalID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
