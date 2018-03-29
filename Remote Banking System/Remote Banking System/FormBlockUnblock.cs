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
    public partial class FormBlockUnblock : Form
    {
        static RemoteBankDataContext adc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
        
        public FormBlockUnblock()
        {
            InitializeComponent();
        }

        private void FormBlockUnblock_Load(object sender, EventArgs e)
        {
            var x = from u in adc.Users
                    join a in adc.Accounts
                    on u.Id equals a.AccountId
                    select new { u.Id,u.name,u.phoneno,a.accountno,u.accounttype,a.Status};



                    
            //var x = from u in adc.Users
            //        join b in adc.Balances
            //        on u.Id equals b.BalanceId
            //        select new { u.Id, u.name, u.phoneno, u.gender, u.address, u.accounttype, b.Accno, b.Account_Balance };

                  
            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            dataGridViewUserBlockUnblock.DataSource = x.ToList();
            //textBoxSearch.Text = "Enter User ID";
            
        }

        private List<object> FormBlockUnblock_Load() //overloaded for updating the gridview
        {
            var x = from u in adc.Users
                    join a in adc.Accounts
                    on u.Id equals a.AccountId
                    select new { u.Id, u.name, u.phoneno, a.accountno, u.accounttype, a.Status };




            //var x = from u in adc.Users
            //        join b in adc.Balances
            //        on u.Id equals b.BalanceId
            //        select new { u.Id, u.name, u.phoneno, u.gender, u.address, u.accounttype, b.Accno, b.Account_Balance };


            List<object> o = new List<object>();
            o.AddRange(x.ToList());
            dataGridViewUserBlockUnblock.DataSource = x.ToList();
            //textBoxSearch.Text = "Enter User ID";
            return o;
        }

        private void FormBlockUnblock_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewUserBlockUnblock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           labelShowID.Text= (dataGridViewUserBlockUnblock.Rows[(dataGridViewUserBlockUnblock.SelectedCells[0].RowIndex)].Cells[0].Value).ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin fa = new FormAdmin();
            this.Hide();
            fa.Show();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            if (!labelShowID.Text.Equals("0"))
            {

                var x = from a in adc.Accounts
                        where a.AccountId == int.Parse(labelShowID.Text)
                        select a;

                //MessageBox.Show(x.FirstOrDefault().Status);
                Account aRef = x.FirstOrDefault();

                if ((aRef.Status == "") || (aRef.Status == "Unblocked"))
                {
                    
                    aRef.Status = "Blocked";
                    adc.SubmitChanges();
                    MessageBox.Show("Account Hass been "+x.FirstOrDefault().Status);
                    dataGridViewUserBlockUnblock.DataSource=this.FormBlockUnblock_Load();
                    
                    
                
                }
                else
                    MessageBox.Show("Account is already " + x.FirstOrDefault().Status);



            
            }
        }

        private void buttonUnblock_Click(object sender, EventArgs e)
        {
            if (!labelShowID.Text.Equals("0"))
            {

                var x = from a in adc.Accounts
                        where a.AccountId == int.Parse(labelShowID.Text)
                        select a;

                //MessageBox.Show(x.FirstOrDefault().Status);
                Account aRef = x.FirstOrDefault();

                if ((aRef.Status != string.Empty) || (aRef.Status == "blocked"))
                {

                    aRef.Status = "Unblocked";
                    adc.SubmitChanges();
                    MessageBox.Show("Account Hass been " + x.FirstOrDefault().Status);
                    dataGridViewUserBlockUnblock.DataSource = this.FormBlockUnblock_Load();
                    

                }
                else
                    MessageBox.Show("Account is already " + x.FirstOrDefault().Status);
            }
        }
    }
}
