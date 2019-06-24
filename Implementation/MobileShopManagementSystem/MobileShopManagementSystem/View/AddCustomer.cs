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
    public partial class AddCustomer : Form
    {
        public int UserId = 0;
        Customer oldcust = new Customer();
        public AddCustomer(Customer c)
        {
            oldcust = c;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer
            {
                Name = txtcustname.Text,
                Address = txtaddress.Text,
                Email = txtemail.Text,
                Phone = txtphone.Text
            };
            CustomerControl cst = new CustomerControl();
            cst.CustControl(cust.Name, cust.Address, cust.Email, cust.Phone, UserId, oldcust);
            cst.DispCustomer(custdatagrid);
            cst.combocust(cmbcustid);
            if (oldcust != null)
            {
                this.Close();
                DisplayCustomer dc = new DisplayCustomer();
                dc.UserID = this.UserId;
                dc.Show();
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtcustname.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtemail.Text = string.Empty;
        }
        private void AddCustomer_Load(object sender, EventArgs e)
        {
            if (oldcust != null)
            {

                txtcustname.Text = oldcust.Name;
                txtaddress.Text = oldcust.Address;
                txtphone.Text = oldcust.Phone;
                txtemail.Text = oldcust.Email;
                CustomerControl ccs = new CustomerControl();
                ccs.DispCustomer(custdatagrid);
            }
            else
            {
                CustomerControl cc = new CustomerControl();
                cc.combocust(cmbcustid);
                cc.comboprod(cmbprodid);
                cc.DispCustomer(custdatagrid);
            }
        }
        private void btnassignpro_Click(object sender, EventArgs e)
        {
            Product p = new Product
            {
                ProId = Convert.ToInt32(cmbprodid.SelectedValue),
                CustId = Convert.ToInt32(cmbcustid.SelectedValue)
            };
            CustomerControl CC = new CustomerControl();
            CC.SaleProduct(p.CustId, p.ProId);
            CC.DispProduct(proddatagrid);
        }

        private void proddatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = proddatagrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = proddatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the assign product from customer?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        CustomerControl cc = new CustomerControl();
                        cc.updateassginprod(id);
                        cc.DispProduct(proddatagrid);
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
        }
    }
}
