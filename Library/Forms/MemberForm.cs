using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for adding a new member.
    /// </summary>
    partial class MemberForm : Form
    {
        /// <summary>
        /// The personal Id of the member.
        /// </summary>
        public string PersonalID;

        /// <summary>
        /// The name of the member.
        /// </summary>
        public string Name;

        /// <summary>
        /// The date on which the member was registered.
        /// </summary>
        public DateTime MembershipDate;

        /// <summary>
        /// MemberForm constructor that sets up the subform.
        /// </summary>
        /// <param name="i"> The Id of the member. </param>
        public MemberForm(int i)
        {
            InitializeComponent();
            label2.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please type in a personal ID.");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please type in a name.");
            }
            else
            {
                PersonalID = textBox1.Text;
                Name = textBox2.Text;
                MembershipDate = dateTimePicker1.Value;

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
