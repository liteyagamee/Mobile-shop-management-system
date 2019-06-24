using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Controller;
using MobileShopManagementSystem.View;

namespace MobileShopManagementSystem
{
    public partial class Login : MetroSet_UI.Forms.MetroSetForm
    {
        public Login()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string usr = txtusername.Text;
            string pass = txtpassword.Text;
            LoginControl Log = new LoginControl();
            Log.LogControl(usr, pass);
            txtusername.Text = "";
            txtpassword.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncreateusr_Click_1(object sender, EventArgs e)
        {
            RegisterUser rgu = new RegisterUser(null);
            rgu.Show();
        }
    }
}
