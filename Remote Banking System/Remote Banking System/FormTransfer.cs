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
    public partial class FormTransfer : Form
    {
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
      
        private User userRef;

        public FormTransfer()
        {
            InitializeComponent();
        }

        public FormTransfer(User mu1)
        {
            // TODO: Complete member initialization
            this.userRef = mu1;
            InitializeComponent();
        }

        private void v(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3Menu fm = new Form3Menu(userRef);
            this.Hide();
            fm.Show();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            double amount=Double.Parse(textBoxAmount.Text);
            bool check=false;
            int receiverAccNo=int.Parse(textBoxReceiverAccNo.Text);
            if (amount <= 0)
                labelError.Show();
            else
                labelError.Hide();

            var xValidAccNoCheck = from a in udc.Balances
                                   select a;
            foreach(Balance a in xValidAccNoCheck.ToList()) //to avoid exception
            {
                if (a.Accno == receiverAccNo)
                    check = true;
                

            
            }

            if (check)
            {
                var xReceiver = from b in udc.Balances
                                where b.Accno == receiverAccNo
                                select b;

                Balance receiverBalanceRef = xReceiver.FirstOrDefault();



                var xSender = from b in udc.Balances
                              where b.BalanceId == userRef.Id
                              select b;
                Balance senderBalanceRef = xSender.FirstOrDefault();

                labelShowPreBalance.Text = senderBalanceRef.Account_Balance.ToString();

                if ((amount > 0) && (senderBalanceRef.Account_Balance > amount) && (senderBalanceRef.Accno != receiverBalanceRef.Accno))
                {
                    receiverBalanceRef.Account_Balance += amount;
                    senderBalanceRef.Account_Balance -= amount;

                    //for displaying pre post amount
                    buttonConfirm.Hide();
                    labelAmount.Hide();
                    labelReceiverAccNo.Hide();
                    textBoxAmount.Hide();
                    textBoxReceiverAccNo.Hide();

                    var sendPostRef = from s in udc.Balances
                                      where s.BalanceId == userRef.Id
                                      select s;
                    senderBalanceRef = sendPostRef.FirstOrDefault();

                    labelShowPostBalance.Text = senderBalanceRef.Account_Balance.ToString();
                    labelShowPostBalance.Show();
                    labelShowPreBalance.Show();
                    labelPreBalance.Show();
                    labelCurrentBalance.Show();
                    labelErrorAcc.Hide();
                    labelMessage.Show();
                    udc.SubmitChanges();

                }
               else
                    labelErrorAcc.Show();
            }

            else
                labelErrorAcc.Show();




        }

        private void FormTransfer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
