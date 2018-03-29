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
    public partial class FormDelete : Form
    {
        static RemoteBankDataContext adc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
      
        public FormDelete()
        {
            InitializeComponent();
        }

        private void textBoxUserID_Click(object sender, EventArgs e)
        {
            if (textBoxUserID.Text == "Enter User ID")
                textBoxUserID.Text = string.Empty;
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            var x = from u in adc.Users
                    join b in adc.Balances
                    on u.Id equals b.BalanceId
                    select new { u.Id, u.name, u.phoneno, u.gender, u.address, u.accounttype, b.Accno, b.Account_Balance, b.Loan };

      
            dataGridView1.DataSource = x.ToList();
        }
        private void FormDelete_Load()
        {
            var x = from u in adc.Users
                    join b in adc.Balances
                    on u.Id equals b.BalanceId
                    select new { u.Id, u.name, u.phoneno, u.gender, u.address, u.accounttype, b.Accno, b.Account_Balance, b.Loan };


            dataGridView1.DataSource = x.ToList();
        }

        private void FormDelete_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            this.Hide();
            fa.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool check=false;
            var x = from u in adc.Users
                    select u;


            if (textBoxUserID.Text.StartsWith("22"))
            {
                foreach (User a in x.ToList())
                {
                    if (a.Id == int.Parse(textBoxUserID.Text))
                        check = true;


                }
            }
            else
                labelErrorID.Show();

          

            if (check)
            {
               

                Balance b = adc.Balances.Single(x1 => x1.BalanceId == int.Parse(textBoxUserID.Text)); //lemda function
                adc.Balances.DeleteOnSubmit(b);
                adc.SubmitChanges();

                Account a1 = adc.Accounts.Single(x2 => x2.AccountId == int.Parse(textBoxUserID.Text));
                adc.Accounts.DeleteOnSubmit(a1);

                var p = from u in adc.Users
                        where u.Id == int.Parse(textBoxUserID.Text)
                        select u;
                foreach (User a in p.ToList())
                {
                    adc.Users.DeleteOnSubmit(a);
                }

                adc.SubmitChanges();
                this.FormDelete_Load();

                MessageBox.Show("SuccessFully deleted!!!");
                textBoxUserID.Text = "Enter User ID";
               


            }
            else
                labelErrorID.Show();

        }
    }
}
