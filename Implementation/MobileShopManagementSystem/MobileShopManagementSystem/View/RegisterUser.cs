using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Model;
using MobileShopManagementSystem.Controller;

namespace MobileShopManagementSystem.View
{
    public partial class RegisterUser : Form
    {
        public int UserId = 0;
        User usr = new User();
        public RegisterUser(User u)
        {
            usr = u;
            InitializeComponent();
        }
        public void btncreateusr_Click(object sender, EventArgs e)
        {
            if (txtfrstname.Text == "")
            {
                MessageBox.Show("Enter the firstname");
            }
            else if (txtlstname.Text == "")
            {
                MessageBox.Show("Enter the Lastname");
            }
            else if (txtphone.Text == "")
            {
                MessageBox.Show("Enter phone number");
            }
            else if (!FormValidator.CheckEmail(txtemail.Text))
            {
                MessageBox.Show("Enter valid email such as: tr@gmail.com");
            }
            else if (cmbgender.Text == "")
            {
                MessageBox.Show("Select Gender");
            }
            else if (txtusername.Text == "")
            {
                MessageBox.Show("Enter Username");
            }
            else if (FormValidator.CheckDuplicateUser(txtusername.Text) && usr==null )
            {
                MessageBox.Show("Username already exists");
            }
            else if (!FormValidator.CheckPasswordLength(txtpassword.Text))
            {
                MessageBox.Show("Enter 6 digit Password");
            }
            else if (!FormValidator.CheckTwoPassword(txtpassword.Text,txtrepassword.Text))
            {
                MessageBox.Show("Password don't match");
            }
            else
            {
                User us = new User
                {
                    Firstname = txtfrstname.Text,
                    Lastname = txtlstname.Text,
                    Phone = txtphone.Text,
                    Email = txtemail.Text,
                    Gender = cmbgender.Text,
                    Username = txtusername.Text,
                    Password = txtpassword.Text
                };
                string repas = txtrepassword.Text;
                Controller.UserControl UC = new Controller.UserControl();
                UC.UsrControl(us.Firstname, us.Lastname, us.Phone, us.Email, us.Gender, us.Username, us.Password, repas, usr);
                if (usr != null)
                {
                    this.Close();
                    DisplayUser du = new DisplayUser();
                    du.UserId = this.UserId;
                    du.Show();
                }
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfrstname.Text=string.Empty;
            txtlstname.Text=string.Empty;
            txtphone.Text=string.Empty;
            txtemail.Text=string.Empty;
            cmbgender.Text=string.Empty;
            txtusername.Text=string.Empty;
            txtpassword.Text=string.Empty;
            txtrepassword.Text=string.Empty;
        }
        private void RegisterUser_Load(object sender, EventArgs e)
        {
           if(usr != null)
           {
                txtfrstname.Text = usr.Firstname;
                txtlstname.Text = usr.Lastname;
                txtphone.Text = usr.Phone;
                cmbgender.Text = usr.Gender;
                txtemail.Text = usr.Email;
                txtusername.Text = usr.Username;
                txtpassword.Text = usr.Password;
           }
        }
    }
}
