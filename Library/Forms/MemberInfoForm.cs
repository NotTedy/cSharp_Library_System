using Library.Models;
using System;
using System.Windows.Forms;

namespace Library.Forms
{
    /// <summary>
    /// GUI subform for displaying information about a member.
    /// </summary>
    partial class MemberInfoForm : Form
    {
        /// <summary>
        /// MemberInfoForm constructor that sets up the subform.
        /// </summary>
        /// <param name="m"> The member to be displayed. </param>
        public MemberInfoForm(Member m)
        {
            InitializeComponent();
            label5.Text = m.Id.ToString();
            label9.Text = m.PersonalID;
            label13.Text = m.Name;
            label11.Text = m.MembershipDate.ToString("dd-MM-yyyy");
            label1.Text = m.Loans.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
