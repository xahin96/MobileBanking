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
    public partial class FormViewDetails : Form
    {
        static RemoteBankDataContext adc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
       
        public FormViewDetails()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text == "Enter User ID")
                textBoxSearch.Text = string.Empty;
        }

        private void FormViewDetails_Load(object sender, EventArgs e)
        {
            var x = from u in adc.Users
                    join b in adc.Balances
                    on u.Id equals b.BalanceId
                    select new {u.Id,u.name,u.phoneno,u.gender,u.address,u.accounttype,b.Accno,b.Account_Balance,b.Loan };

            //List<object> o = new List<object>();
            //o.AddRange(x.ToList());
            dataGridViewAccountDetail.DataSource = x.ToList();
            //textBoxSearch.Text = "Enter User ID";
        }

        private void FormViewDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != string.Empty)
            {
                var x = from u in adc.Users
                        join b in adc.Balances
                        on u.Id equals b.BalanceId
                        where u.Id == int.Parse(textBoxSearch.Text)
                        select new { u.Id, u.name, u.phoneno, u.gender, u.address, u.accounttype, b.Accno, b.Account_Balance,b.Loan };

                dataGridViewAccountDetail.DataSource = x.ToList();
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            this.Hide();
            fa.Show();
        }
    }
}
