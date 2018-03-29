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
    public partial class Form2Deposit : Form
    {
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
      
        User userReference;
        public Form2Deposit(User du)
        {
            this.userReference = du;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3Menu fm1 = new Form3Menu(userReference);
            this.Hide();
            
            //Application.Restart();
            //Environment.Exit(0);
            fm1.Show();
            
            
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {   

            var x = from a in udc.Balances
                    where a.BalanceId ==userReference.Id
                    select a;
              
            Balance b1 = x.FirstOrDefault();
            if ((int.Parse(textBoxAmount.Text) > 0))
            {
                labelError.Hide();
                double preBalance = x.FirstOrDefault().Account_Balance; // += float.Parse(textBoxAmount.Text);
                double newBalance = x.FirstOrDefault().Account_Balance += float.Parse(textBoxAmount.Text);


                //udc.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, udc.Balances);
                // MessageBox.Show("Deposited Successfully!!!");
                //for showing pre and post balances
                buttonConfirm.Hide();
                labelAmount.Hide();
                textBoxAmount.Hide();
                labelMessage.Show();
                labelPreBalance.Show();
                labelCurrentBalance.Show();
                labelShowPreBalance.Text = preBalance.ToString();
                labelShowPreBalance.Show();



                var x1 = from a in udc.Balances
                         where a.BalanceId == userReference.Id
                         select a;

                b1 = x1.FirstOrDefault();
                labelShowPostBalance.Text = b1.Account_Balance.ToString();
                labelShowPostBalance.Show();


                udc.SubmitChanges();


                //Form2PostDeposit fpd = new Form2PostDeposit(preBalance.ToString(),newBalance.ToString(),userReference);

            }
            else
                labelError.Show();


        }

        private void Form2Deposit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
