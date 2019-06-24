using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MobileShopManagementSystem.Model;

namespace MobileShopManagementSystem.Controller
{
    public class BillControl
    {
        public void Combocustomer(ComboBox cb)
        {
            try
            {
                string query = "select * from [CustomerTbl] order by customer_id desc";
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                cb.DataSource = dt;
                cb.ValueMember = "customer_id";
                cb.DisplayMember = "customer_name";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Comboproduct(ComboBox cbo)
        {
            try
            {
                string command = "select * from [ProductTbl]";
                DBConnect dbc = new DBConnect();
                DataTable dta = dbc.GetData(command);
                cbo.DataSource = dta;
                cbo.ValueMember = "product_id";
                cbo.DisplayMember = "model";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void CustprodData(DataGridView dg)
        {
            try
            {
                string sql = "Select c.customer_name,p.model,p.brand,p.price,p.product_name from " +
                    "[ProductTbl] as p inner join [CustomerTbl] as c on c.customer_id = p.customer_id";
                DBConnect dbco = new DBConnect();
                DataTable dtb = dbco.GetData(sql);
                dg.DataSource = dtb;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void adbill(DateTime dt,int id,float totamt,float disc,float grandtot,string payment)
        {
            try
            {
                string query = "Insert into [BillTbl] (date,customer_id,totalamount,discount,grandtotal,paymenttype) values('" + dt + "','"
                    + id + "','" + totamt + "','" + disc + "','" + grandtot + "','" + payment + "')";
                DBConnect db = new DBConnect();
                db.Executequery(query);
                MessageBox.Show("Bill details added successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        public void DispBill(DataGridView dv)
        {
            try
            {
                string query = "Select * from [BillTbl]";
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                dv.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteBill(string id)
        { 
            try
            { 
            string deletequery = "Delete from [BillTbl] where bill_id=" + id;
            DBConnect db = new DBConnect();
            db.Executequery(deletequery);
            MessageBox.Show("Customers Bill Deleted Successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Dispcreatedbill(DataGridView dg)
        {
            try
            { 
            string query = "Select c.customer_name,b.* from BillTbl as b inner join CustomerTbl as c on c.customer_id = b.customer_id order by bill_id desc";
            DBConnect db = new DBConnect();
            DataTable dt=db.GetData(query);
            dg.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
