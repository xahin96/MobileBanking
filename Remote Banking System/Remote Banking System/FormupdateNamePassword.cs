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
    public partial class FormupdateNamePassword : Form
    {
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
        User userReference;
        public FormupdateNamePassword(User lu)
        {
            this.userReference = lu;
            InitializeComponent();
         
        }

        private void FormupdateNamePassword_Load(object sender, EventArgs e)
        {
            var x = from u in udc.Users
                    where u.Id == userReference.Id
                    select new { u.name,u.password,u.gender,u.phoneno};

            dataGridView1.DataSource = x.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = (dataGridView1.Rows[(dataGridView1.SelectedCells[0].RowIndex)].Cells[0].Value).ToString();
            textBoxPassword.Text = (dataGridView1.Rows[(dataGridView1.SelectedCells[0].RowIndex)].Cells[1].Value).ToString();
        }

        private void FormupdateNamePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GridViewUpdate()
        {
            var x = from u in udc.Users
                    where u.Id == userReference.Id
                    select new { u.name, u.password, u.gender, u.phoneno };

            dataGridView1.DataSource = x.ToList();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var x = from u in udc.Users
                    where u.Id == userReference.Id
                    select u;

            User userRef = x.FirstOrDefault();

            userRef.name = textBoxName.Text;
            userRef.password = textBoxPassword.Text;
            udc.SubmitChanges();
            this.GridViewUpdate();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form3Menu fm = new Form3Menu(userReference);
            this.Hide();
            fm.Show();
        }
    }
}
