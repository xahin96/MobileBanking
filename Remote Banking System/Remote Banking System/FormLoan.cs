using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remote_Banking_System
{
    public partial class FormLoan : Form
    {
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
        User userReference;
        public FormLoan(User lu)
        {
            this.userReference = lu;
            InitializeComponent();
        }

        private void textBoxAmount_Click(object sender, EventArgs e)
        {
            if (textBoxAmount.Text.Equals("Enter Amount"))
            {
                textBoxAmount.Text = string.Empty;
            }
        }

        private void buttonReq_Click(object sender, EventArgs e)
        {
            var x = from b in udc.Balances
                    where b.BalanceId == userReference.Id
                    select b;
            Balance balanceRef = x.FirstOrDefault();

            if ((balanceRef.Account_Balance < 5000) && (float.Parse(textBoxAmount.Text) < 50000) && (balanceRef.Loan==null))
            {

                balanceRef.Loan = float.Parse(textBoxAmount.Text);
                MessageBox.Show("Loan Has Been Accepted");
                udc.SubmitChanges();
                buttonReq.Hide();
                label5000.Hide();
                label50000.Hide();
                labelZero.Hide();

            }

            else
            {
                MessageBox.Show("Sorry Loan Can Not Be Accepted!!!");
                label5000.Show();
                label50000.Show();
                labelZero.Show();
            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3Menu fm = new Form3Menu(userReference);
            this.Hide();
            fm.Show();
        }

        private void FormLoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
