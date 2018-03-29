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
    public partial class Form2Login : Form
    {
        //bool check = true; // to handle the exception situation 
        static RemoteBankDataContext udc = new RemoteBankDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\C#\Remote Banking System\Remote Banking System\MainServer.mdf;Integrated Security=True;Connect Timeout=30");
       
        public Form2Login()
        {
            InitializeComponent();
            textBox2Pass.PasswordChar = '*';
        }

        private void button1Login_Click(object sender, EventArgs e)
        {

            string identifyId = textBoxId.Text;

            if (identifyId.StartsWith("22")) //user
            {
                labelManager.Hide();
                labelBlocked.Hide();
                bool checkID = false;
                bool checkStatus = false;
                int accId = int.Parse(textBoxId.Text);


                var xValidIdCheck = from a in udc.Users
                                    select a;

                foreach (User a in xValidIdCheck.ToList()) //to avoid exception
                {
                    if (a.Id == accId)
                    {
                        checkID = true;
                        var xAccStatus = from s in udc.Accounts
                                         where s.AccountId==accId
                                         select s;
                        
                        if (xAccStatus.FirstOrDefault().Status.Equals("Unblocked"))
                            checkStatus = true;

                    }

                } //foreach end scope

                //var xAccStatus=from a in udc.Accounts



                if (checkStatus)
                {

                    if (checkID) //to check the ID
                    {
                        var x = from a in udc.Users
                                where a.Id == int.Parse(textBoxId.Text)
                                select a;


                        User u1 = x.FirstOrDefault();

                        if (u1.password == textBox2Pass.Text) //for password checking
                        {

                            Form3Menu fm1 = new Form3Menu(u1);
                            this.Hide();
                            fm1.Show();

                        }

                        else
                        {
                            labelPassword.Show();
                            labelManager.Hide();
                            labelBlocked.Hide();
                            labelErrorID.Hide();
                        }


                    }
                    else
                       labelErrorID.Show();
                 }  //end scope of if (checkStatus)
                   
                else
                    {
                        if (checkID)
                        {
                            labelBlocked.Show();
                            labelManager.Show();
                            labelPassword.Hide();
                            labelErrorID.Hide();
                        }
                        else
                            labelErrorID.Show();

                        
                    }

                } //if (identifyId.StartsWith("22"))'s end scope


                else if (identifyId.StartsWith("33"))  //admin
                {

                    bool check = false;
                    int accId = int.Parse(textBoxId.Text);


                    var xValidIdCheck = from a in udc.Admins
                                        select a;

                    foreach (Admin a in xValidIdCheck.ToList()) //to avoid exception
                    {
                        if (a.AdminId == int.Parse(textBoxId.Text))
                            check = true;



                    }

                    if (check)
                    {
                        var x = from a in udc.Admins
                                where a.AdminId == int.Parse(textBoxId.Text)
                                select a;

                        labelErrorID.Hide();

                        Admin adminRef = x.FirstOrDefault();

                        if (adminRef.Password == textBox2Pass.Text)
                        {

                            FormAdmin fa = new FormAdmin();
                            this.Hide();
                            fa.Show();

                        }

                        else
                        {
                            labelPassword.Show();
                            labelErrorID.Hide();
                        }

                    }  //end scope of if(check)
                  else
                        labelErrorID.Show();


                }
               else
                    labelErrorID.Show();
          
  
          
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1Welcome fw1 = new Form1Welcome();
            this.Hide();
            fw1.Show();
        }

       
        private void Form2Login_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
