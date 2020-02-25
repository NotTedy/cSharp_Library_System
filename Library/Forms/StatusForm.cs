using System;
using Library.Models;
using Library.Services;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for displaying available book copies or a full loan history.
    /// </summary>
    partial class StatusForm : Form
    {
        /// <summary>
        /// StatusForm constructor that sets up the subform with BookCopy objects.
        /// </summary>
        /// <param name="s"> The text to be displayed after "Showing: " in label1. </param>
        /// <param name="bCS"> The service responsible for retreiving member data from the
        /// library via the member repository. </param>
        public StatusForm(string s, BookCopyService bCS)
        {
            InitializeComponent();
            label1.Text += s;

            foreach (BookCopy bc in bCS.GetAllAvailable())
            {
                listBox1.Items.Add(bc);
            }
        }

        /// <summary>
        /// StatusForm constructor that sets up the subform with Loan objects.
        /// </summary>
        /// <param name="s"> The text to be displayed after "Showing: " in label1. </param>
        /// <param name="lS"> The service responsible for retreiving loan data from the
        /// library via the loan repository. </param>
        public StatusForm(string s, LoanService lS)
        {
            InitializeComponent();
            label1.Text += s;
            listBox1.Items.Add("Active loans");
            listBox1.Items.Add("");

            foreach (Loan l in lS.GetAllOnLoan())
            {
                listBox1.Items.Add(l);
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Returned loans");
            listBox1.Items.Add("");

            foreach (Loan l in lS.GetAllReturned())
            {
                listBox1.Items.Add(l);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
