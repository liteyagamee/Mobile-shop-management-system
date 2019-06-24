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
    public partial class AddEmpolyee : Form
    {
        public int UserId = 0;
        Employee oldemp = new Employee();
        public AddEmpolyee(Employee E)
        {
            oldemp = E;
            InitializeComponent();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Enter the name of an employee");
            }
            else if (txtaddress.Text == "")
            {
                MessageBox.Show("Enter the address of an employee");
            }
            else if (cmbgender.Text == "")
            {
                MessageBox.Show("Select Gender");
            }
            else if (txtphn.Text == "")
            {
                MessageBox.Show("Enter phone number of an employee");
            }
            else if (!FormValidator.CheckEmail(txtemail.Text))
            {
                MessageBox.Show("Enter the valid email eg:rt@gmail.com");
            }
            else if (txtsalary.Text == "")
            {
                MessageBox.Show("Insert the Salary of an employee");
            }
            else
            {
                    Employee Emp = new Employee();
                    Emp.Name = txtname.Text;
                    Emp.Address = txtaddress.Text;
                    Emp.Gender = cmbgender.Text;
                    Emp.Phone = txtphn.Text;
                    Emp.Email = txtemail.Text;
                    Emp.Salary = float.Parse(txtsalary.Text);
                    EmployeeControl EC = new EmployeeControl();
                    EC.EmpControl(Emp.Name, Emp.Address, Emp.Gender, Emp.Phone, Emp.Email, Emp.Salary, UserId, oldemp);
                if(oldemp!=null)
                {
                    this.Close();
                    DisplayEmployee de = new DisplayEmployee();
                    de.UserId = this.UserId;
                    de.Show();
                }
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = string.Empty;
            txtaddress.Text = string.Empty;
            cmbgender.Text = string.Empty;
            txtphn.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtsalary.Text = string.Empty;
        }
        private void AddEmpolyee_Load(object sender, EventArgs e)
        {
            if(oldemp !=null)
            {
                txtname.Text = oldemp.Name;
                txtphn.Text = oldemp.Phone;
                txtemail.Text = oldemp.Email;
                txtaddress.Text = oldemp.Address;
                txtsalary.Text = Convert.ToString(oldemp.Salary);
                cmbgender.Text = oldemp.Gender;
            }
        }
    }
}
