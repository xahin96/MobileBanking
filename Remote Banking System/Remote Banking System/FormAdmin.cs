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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Form2Login fl = new Form2Login();
            this.Hide();
            fl.Show();
        }

        private void buttonViewDetails_Click(object sender, EventArgs e)
        {
            FormViewDetails fv = new FormViewDetails();
            this.Hide();
            fv.Show();
        }

        private void buttonAccBlock_Click(object sender, EventArgs e)
        {
            FormBlockUnblock fbu = new FormBlockUnblock();
            this.Hide();
            fbu.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            FormDelete fd = new FormDelete();
            this.Hide();
            fd.Show();
        }
    }
}
