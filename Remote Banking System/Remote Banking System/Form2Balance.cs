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
    public partial class FormBalance : Form
    {
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
        User br1;
        public FormBalance(User br1)
        {
            this.br1 = br1;
            InitializeComponent();

        }

        private void FormBalance_Load(object sender, EventArgs e)
        {

            //var x = from a in udc.Balances
            //        where a.BalanceId == br1.Id
            //        select a;
            RemoteBankDataContext udc1 = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");

            var x = from b in udc1.Balances
                    join u in udc1.Users
                    on b.BalanceId equals u.Id
                    where b.BalanceId == br1.Id
                    select new { u.Id,u.name,u.password,u.phoneno,u.address,b.Accno,b.Account_Balance,b.Loan};

            //User userReferenceForBalance = x.FirstOrDefault();
            ////MessageBox.Show(x.First().Account_Balance.ToString());

            //labelBalance.Text = x.First().Account_Balance.ToString();
            dataGridUserDetails.DataSource = x.ToList();




        }

        private void buttonBalanceBack_Click(object sender, EventArgs e)
        {
            Form3Menu fm1 = new Form3Menu(br1);
            this.Hide();
            fm1.Show();
        }

        //private void FormBalance_Load_1(object sender, EventArgs e)
        //{
            
        //    var x = from a in udc.Balances
        //            where a.BalanceId == br1.Id
        //            select a;
        //     Balance refBalance = x.FirstOrDefault();

        //     this.labelBalance.Text = refBalance.Account_Balance.ToString();
        //     this.labelId.Text = refBalance.BalanceId.ToString();
             
        //}
        public void ShowDetails()
        {

            //var x = from a in udc.Balances
            //        where a.BalanceId == br1.Id
            //        select a;

            var x = from b in udc.Balances
                    join u in udc.Users
                    on b.BalanceId equals u.Id
                    where b.BalanceId == br1.Id


                    select b;

            Balance refBalance = x.FirstOrDefault();

            // this.labelBalance.Text = refBalance.Account_Balance.ToString();
            //this.labelBalance.Text = x.First().Account_Balance.ToString();
            //this.labelId.Text = refBalance.BalanceId.ToString();

            

            this.Show();

        }

        private void FormBalance_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
