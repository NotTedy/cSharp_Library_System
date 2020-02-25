using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for returning a loan.
    /// </summary>
    partial class ReturnForm : Form
    {
        /// <summary>
        /// The date on which a loan was made.
        /// </summary>
        public DateTime TimeOfLoan;

        /// <summary>
        /// The last date on which a loan is to be returned.
        /// </summary>
        public DateTime DueDate;

        /// <summary>
        /// The date on which a loan was returned.
        /// </summary>
        public DateTime TimeOfReturn;

        /// <summary>
        /// ReturnForm constructor that sets up the subform.
        /// </summary>
        /// <param name="i"> The Id of the loan. </param>
        /// <param name="d1"> The date on which a loan was made. </param>
        /// <param name="d2"> The last date on which a loan is to be returned. </param>
        public ReturnForm(int i, DateTime d1, DateTime d2)
        {
            InitializeComponent();
            TimeOfLoan = d1;
            DueDate = d2;
            label2.Text = i.ToString();
            label3.Text = TimeOfLoan.ToString("dd-MM-yyyy");
            label6.Text = DueDate.ToString("dd-MM-yyyy");

            EventArgs e = new EventArgs();
            dateTimePicker1_ValueChanged(this, e);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            TimeOfReturn = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(TimeOfLoan, TimeOfReturn) > 0)
            {
                MessageBox.Show("Return date cannot be earlier than loan date.");
            }
            else
            {
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
