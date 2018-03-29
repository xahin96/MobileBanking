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
    public partial class Form1Welcome : Form
    {
        public Form1Welcome()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Form2Register fr1 = new Form2Register();
            this.Hide();
            fr1.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Form2Login fl2 = new Form2Login();
            
            this.Hide();
            fl2.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
