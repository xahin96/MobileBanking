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
    public partial class Form3Menu : Form
    {
        User mu1; //user reference
        public Form3Menu(User mu1)
        {
            this.mu1 = mu1;
            InitializeComponent();
            labelWelcomeMessage.Text ="Welcome "+mu1.name; //to welcome the user
        }

        private void button1Balance_Click(object sender, EventArgs e)
        {
            FormBalance fb1 = new FormBalance(mu1);
            this.Hide();
            fb1.ShowDetails();

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form2Login fl1 = new Form2Login();
            this.Hide();
            fl1.Show();
        }

        private void button4Deposit_Click(object sender, EventArgs e)
        {
            
            Form2Deposit fd1=new Form2Deposit(mu1);
            this.Hide();
            fd1.Show();
        }

        private void button3withdraw_Click(object sender, EventArgs e)
        {
            FormWithdraw fw = new FormWithdraw(mu1);
            this.Hide();
            fw.Show();

        }

        private void button5Transfer_Click(object sender, EventArgs e)
        {
            FormTransfer ft = new FormTransfer(mu1);
            this.Hide();
            ft.Show();
        }

        private void Form3Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6RequestLoan_Click(object sender, EventArgs e)
        {
            FormLoan fl = new FormLoan(mu1);
            this.Hide();
            fl.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FormupdateNamePassword fu = new FormupdateNamePassword(mu1);
            this.Hide();
            fu.Show();
        }
    }
}
