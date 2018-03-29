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
    public partial class FormWithdraw : Form
    {
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
      

        User userRef;
        public FormWithdraw(User u)
        {
            this.userRef = u;
            InitializeComponent();
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
            if (amount < 0)
                labelError.Show();

            else
                labelError.Hide();
                
           
            var x=from a in udc.Users
                  join b in udc.Balances
                  on a.Id equals b.BalanceId
                  where a.Id==userRef.Id
                  select b;

            Balance balanceTableref=x.FirstOrDefault();
            labelShowPreBalance.Text = balanceTableref.Account_Balance.ToString();
            
            //labelCheck.Text=balanceTableref.Account_Balance.ToString(); //for checking perpose

            if ((amount > 0) && (balanceTableref.Account_Balance > amount))
            {

                balanceTableref.Account_Balance -= amount;

                //for showing pre post details 
                var x1 = from a in udc.Users
                         join b in udc.Balances
                         on a.Id equals b.BalanceId
                         where a.Id == userRef.Id
                         select b;

                balanceTableref = x.FirstOrDefault();

                labelAmount.Hide();
                textBoxAmount.Hide();
                buttonConfirm.Hide();
                labelPreBalance.Show();
                labelCurrentBalance.Show();

                labelShowPostBalance.Text = balanceTableref.Account_Balance.ToString();
                labelShowPostBalance.Show();
                labelShowPreBalance.Show();
                labelMessage.Show();


                //labelPost.Text = balanceTableref.Account_Balance.ToString();
                udc.SubmitChanges();


            }
            else
                labelError.Show();

         

        }

        private void c(object sender, EventArgs e)
        {

        }

        private void FormWithdraw_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
