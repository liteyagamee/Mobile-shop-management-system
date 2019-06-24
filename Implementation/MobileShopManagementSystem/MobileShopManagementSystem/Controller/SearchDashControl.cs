using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MobileShopManagementSystem.Model;


namespace MobileShopManagementSystem.Controller
{
    public class SearchDashControl
    {
        public void Dispprod(DataGridView dg)
        {
            try
            { 
               string query = "Select * from [ProductTbl] where customer_id IS NULL";
               DBConnect db = new DBConnect();
               DataTable dt = db.GetData(query);
               dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        public void Dispsale(DataGridView dv)
        {
            try
            {
               string querys = "Select * from [ProductTbl] where customer_id > 0";
               DBConnect dbc = new DBConnect();
               DataTable dta = dbc.GetData(querys);
               dv.DataSource = dta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Custsearch(string txt, DataGridView dg)
        {
            try
            { 
              string query = "Select c.customer_id,c.customer_name,c.customer_address,c.phone,c.email," +
                   "p.product_name,p.model,p.brand,p.product_description,p.color,p.IMEI,b.date,b.grandtotal,b.paymenttype" +
                   " from [CustomerTbl] as c inner join [ProductTbl] as p on p.customer_id = c.customer_id " +
                   "inner join [BillTbl] as b on c.customer_id = b.customer_id " +
                   "where c.customer_id like'" + txt + "%' or c.customer_name like '" + txt + "%'";
              DBConnect db = new DBConnect();
              DataTable dt = db.GetData(query);
              dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Prodsearch(string text, DataGridView dv)
        {
            try
            {
                string querys = "Select * from [ProductTbl] where product_name like '" + text + "%' or model like '" +
                    text + "%' or brand like '" + text + "%'";
                DBConnect db = new DBConnect();
                DataTable dta = db.GetData(querys);
                dv.DataSource = dta;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
