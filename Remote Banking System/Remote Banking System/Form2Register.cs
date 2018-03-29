using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Remote_Banking_System
{

    public partial class Form2Register : Form
    {
        public static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
        public Form2Register()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar='*';
            textBoxConfirmPass.PasswordChar = '*';
        }
        
        void GridViewUpdate()
        {
            RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
            
        }

        public void Regexp(string re, TextBox tb, PictureBox pc, Label lbl, string s) //valid invalid
        {
            Regex regex = new Regex(re);

            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.valid;
                lbl.ForeColor = Color.Green;
                lbl.Text = s + " Valid";
            }
            else
            {
                pc.Image = Properties.Resources.invalid;
                lbl.ForeColor = Color.Red;
                lbl.Text = s + " InValid";
            }
        }
        private void button1_ConfirmClick(object sender, EventArgs e)
        {

            Regexp(@"^.+$", textBox1Name, pictureBox1, labelname, "Name");
            Regexp(@"^.+$", textBoxPassword, pictureBox2, labelPasswod, "Password");
            Regexp(@textBoxPassword.Text, textBoxConfirmPass, pictureBox3, labelConfirm, "Confirmation");
            Regexp(@"^.+$", textBoxAddress, pictureBox4, labelAddress, "Address");
            Regexp(@"^(01)(([0-9]{3}){3})$", textBoxPhoneNo, pictureBox5, labelPhoneNo, "Phone");

           // MessageBox.Show(comboBoxGender.Text.Length.ToString());
           // MessageBox.Show(comboBox1AccType.Text.Length.ToString());
            //If else start=================================
            if ((textBoxPassword.Text == textBoxConfirmPass.Text) && (textBox1Name.Text != "") && (textBox1Name.Text.Length >4) && (textBoxAddress.Text.Length>4) && (textBoxAddress.Text != "") && (textBoxPassword.Text != "") && (textBoxPassword.Text.Length > 3) && ((textBoxPhoneNo.Text.StartsWith("01")) && (textBoxPhoneNo.Text.Length == 11)&&(comboBox1AccType.Text.Length>0)&&(comboBoxGender.Text.Length>0)))
            {
                //MessageBox.Show("S");
                    
                //for user table
                User u = new User
                {
                    name=textBox1Name.Text,
                    address=textBoxAddress.Text,
                    phoneno=textBoxPhoneNo.Text,
                    password=textBoxPassword.Text,
                    gender=comboBoxGender.Text,
                    accounttype=comboBox1AccType.Text

                    

                };
                udc.Users.InsertOnSubmit(u);  //add u object in temporary table in data contex
                udc.SubmitChanges();  //send the changes in database table
              
                                  


                //for account table
                Account a= new Account
                {
                   AccountId=u.Id,
                   Status="Unblocked"

                };
                udc.Accounts.InsertOnSubmit(a);  //add a object in temporary table in data contex
                udc.SubmitChanges();  //send the changes in database table
                
                //for balance table

                Balance b = new Balance 
                {
                   BalanceId=u.Id,
                   Accno=a.accountno,
                   Account_Balance=1000
                   
                
                };

                udc.Balances.InsertOnSubmit(b);  //add b object in temporary table in data contex
                udc.SubmitChanges();  //send the changes in database table
                string s = "Congratulations!!! Your Id:" + u.Id + "\n Account No:" + a.accountno;
                MessageBox.Show(s);
                button1.Hide();
              
            }
            else if(textBoxPassword.Text!=textBoxConfirmPass.Text)
                MessageBox.Show("Password Mismatch!!!!!!!!!!");
            else if (textBoxPassword.Text.Length<4)
                MessageBox.Show("Password too small!!!!!!!!!!");
            else if (textBox1Name.Text.Length<5)
                MessageBox.Show("Name too small!!!!!!!!!!");
            else if (textBoxAddress.Text.Length <5)
                MessageBox.Show("Address too small!!!!!!!!!!");
            else
            {
                labelError.Show();
            
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1Welcome fw1 = new Form1Welcome();
            this.Hide();
            fw1.Show();
        }

        private void Form2Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
