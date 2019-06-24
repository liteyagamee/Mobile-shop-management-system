using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Model;
using System.Data;

namespace MobileShopManagementSystem.Controller
{
    public class CustomerControl
    {
        public void CustControl(string name, string address, string email, string phone, int UserId,Customer cust)
        {
            try
            {
                if (name == "")
                {
                    MessageBox.Show("Enter the name of a customer");
                }
                else if (address == "")
                {
                    MessageBox.Show("Enter the address");
                }
                else if (!FormValidator.CheckEmail(email))
                {
                    MessageBox.Show("Enter the valid email eg:rt@gmail.com");
                }
                else if (phone == "")
                {
                    MessageBox.Show("Enter the phone number");
                }
                else if (cust != null)
                {
                    string command = "Update [CustomerTbl] set customer_name='" + name + "',customer_address='"
                        + address + "',email='" + email + "',phone='" + phone + "',user_id='" + UserId + "' where customer_id='" + cust.CustId + "'";
                    DBConnect db = new DBConnect();
                    db.Executequery(command);
                    MessageBox.Show("Customer Information updated successfully");
                }
                else
                {
                    string query = "Insert into [CustomerTbl] values('" + name + "','" + address + "','" + 
                        email + "','" + phone + "','" + UserId + "')";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("Customer Information added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SaleProduct(int custid, int prodid)
        {
            try
            {
                string command = "select * from [ProductTbl] where product_id='" + prodid + "'";
                DBConnect dbc = new DBConnect();
                DataTable dt = dbc.GetData(command);
                if(DBNull.Value.Equals(dt.Rows[0]["customer_id"]))
                {
                    string query = "Update [ProductTbl] set customer_id='" + custid + "' where product_id='" + prodid + "'";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("Product assigned to customer successfully");
                }
                else
                {
                    MessageBox.Show("Product already sold to customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void combocust(ComboBox cb)
        {
            try
            { 
            string command = "Select * from [CustomerTbl] order by customer_id desc";
            DBConnect db = new DBConnect();
            DataTable dt = db.GetData(command);
            cb.DataSource = dt;
            cb.ValueMember = "customer_id";
            cb.DisplayMember = "customer_name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void comboprod(ComboBox co)
        {
            try
            { 
            string query = "Select * from [ProductTbl] where customer_id IS NULL";
            DBConnect dbc = new DBConnect();
            DataTable dta = dbc.GetData(query);
            co.DataSource = dta;
            co.ValueMember = "product_id";
            co.DisplayMember = "model";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  void DispCustomer(DataGridView dg)
        {
            try
            { 
            string query = "select customer_id,customer_name,customer_address,email,phone from [CustomerTbl] order by customer_id desc";
            DBConnect db = new DBConnect();
            DataTable dt = db.GetData(query);
            dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DispProduct(DataGridView dv)
        {
            try
            { 
            string command = "select customer_id,product_id,product_name,brand,model,product_description,price,color,IMEI from [ProductTbl] order by customer_id desc";
            DBConnect db = new DBConnect();
            DataTable dt = db.GetData(command);
            dv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DispCust(DataGridView dgv)
        {
            try
            { 
            string query = "select * from [CustomerTbl]";
            DBConnect db = new DBConnect();
            DataTable dt = db.GetData(query);
            dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteCust(string id)
        {
            try
            { 
            string query = "Delete from [ProductTbl] where customer_id=" + id;
            DBConnect dbc = new DBConnect();
            dbc.Executequery(query);

            string querys = "Delete from [BillTbl] where customer_id=" + id;
            DBConnect dc = new DBConnect();
            dc.Executequery(querys);

            string deletequery = "Delete from [CustomerTbl] where customer_id=" + id;
            DBConnect db = new DBConnect();
            db.Executequery(deletequery);
            MessageBox.Show("Customer details Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateassginprod(string id)
        {
            try
            { 
            string update = "Update [ProductTbl] set customer_id= NULL where product_id=" + id;
            DBConnect db = new DBConnect();
            db.Executequery(update);
            MessageBox.Show("Product assigned to customer removed successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
