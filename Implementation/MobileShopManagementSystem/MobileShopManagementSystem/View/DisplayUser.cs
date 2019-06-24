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
    public partial class DisplayUser : Form
    {
        public int UserId =0;
        public DisplayUser()
        {
            InitializeComponent();
        }
        private void DisplayUser_Load(object sender, EventArgs e)
        {
             Controller.UserControl uc = new Controller.UserControl();
            uc.DisplayUs(UserId,dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the User Account?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {     
                        Controller.UserControl uc = new Controller.UserControl();
                        uc.DeleteUser(id);
                        uc.DisplayUs(UserId, dataGridView1);
                    }
                    else if (result == DialogResult.No)
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (command.ToLower() == "edit")
            {
                string query = "Select * from [UserTbl] where user_id=" + id;
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    User U = new User();
                    U.UserId = (int)dt.Rows[0]["user_id"];
                    U.Username = (string)dt.Rows[0]["username"];
                    U.Password = (string)dt.Rows[0]["password"];
                    U.Email = (string)dt.Rows[0]["email"];
                    U.Phone = (string)dt.Rows[0]["phone"];
                    U.Gender = (string)dt.Rows[0]["gender"];
                    U.Firstname = (string)dt.Rows[0]["first_name"];
                    U.Lastname = (string)dt.Rows[0]["last_name"];
                    RegisterUser RU = new RegisterUser(U);
                    RU.UserId = this.UserId;
                    RU.Show();
                    this.Close();
                }
            }
        }
    }
}
