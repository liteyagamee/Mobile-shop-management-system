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
    public partial class DisplayCustomer : Form
    {
        public int UserID = 0;
        public DisplayCustomer()
        {
            InitializeComponent();
        }
        private void DisplayCustomer_Load(object sender, EventArgs e)
        {
            CustomerControl cuc = new CustomerControl();
            cuc.DispCust(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the customer details?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {

                        CustomerControl cuc = new CustomerControl();
                        cuc.DeleteCust(id);
                        cuc.DispCust(dataGridView1);
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
                string query = "Select * from [CustomerTbl] where customer_id=" + id;
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    Customer c = new Customer();
                    c.CustId = (int)dt.Rows[0]["customer_id"];
                    c.Name = (string)dt.Rows[0]["customer_name"];
                    c.Phone = (string)dt.Rows[0]["phone"];
                    c.Email = (string)dt.Rows[0]["email"];
                    c.Address = (string)dt.Rows[0]["customer_address"];
                    c.Uid = (int)dt.Rows[0]["user_id"];
                    AddCustomer AC = new AddCustomer(c);
                    AC.UserId = this.UserID;
                    AC.Show();
                    this.Close();
                }
            }
        }
    }
}
