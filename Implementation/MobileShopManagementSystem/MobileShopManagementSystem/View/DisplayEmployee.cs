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
    public partial class DisplayEmployee : Form
    {
        public int UserId = 0;
        public DisplayEmployee()
        {
            InitializeComponent();
        }
        private void DisplayEmployee_Load(object sender, EventArgs e)
        {
            EmployeeControl EC = new EmployeeControl();
            EC.DispEmp(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the employee details?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        EmployeeControl EC = new EmployeeControl();
                        EC.DelEmp(id);
                        EC.DispEmp(dataGridView1);
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
                string query = "Select * from [EmployeeTbl] where employee_id=" + id;
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    Employee E = new Employee();
                    E.EmpId = (int)dt.Rows[0]["employee_id"];
                    E.Name = (string)dt.Rows[0]["name"];
                    E.Address =(string) dt.Rows[0]["address"];
                    E.Gender = (string)dt.Rows[0]["gender"];
                    E.Phone = (string)dt.Rows[0]["phone"];
                    E.Email = (string)dt.Rows[0]["email"];
                    E.Salary = float.Parse((Convert.ToString(dt.Rows[0]["salary"])));
                    E.Uid = (int)dt.Rows[0]["user_id"];
                    AddEmpolyee AE = new AddEmpolyee(E);
                    AE.UserId = this.UserId;
                    AE.Show();
                    this.Close();
                }
            }
        }
    }
}
