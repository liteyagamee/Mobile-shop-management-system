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
    public class ProductControl
    {
        public void ProControl(string proname,string descrption,float price,
            string model,string color,string brand,string IMEI,Product prod)
        {
            try
            {
                if(prod != null)
                {
                    string query = "update [ProductTbl] set product_name='" + proname + "',product_description='" + descrption +
                        "',brand='" + brand + "',price='" + price + "',model='" + model + "',color='" + color + "',IMEI='"
                        + IMEI + "'where product_id='" + prod.ProId + "'";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("Product details updated successfully");
                }
                else
                {
                    string query = "Insert into [ProductTbl](product_name,product_description,brand,price,model,color,IMEI) " +
                        "values('" + proname + "','" + descrption + "','" + brand + "','" + price + "','" + model + "','" + 
                        color + "','" + IMEI + "')";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("Product added successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Displayprod(DataGridView dg)
        {
            string query = "Select * from [ProductTbl]";
            DBConnect db = new DBConnect();
            DataTable dt = db.GetData(query);
            dg.DataSource = dt;
        }
        public void deleteprod(string id)
        {
            string command = "select * from [ProductTbl] where product_id="+id;
            DBConnect dbc = new DBConnect();
            DataTable dt = dbc.GetData(command);
            if (DBNull.Value.Equals(dt.Rows[0]["customer_id"]))
            {
                string deletequery = "Delete from [ProductTbl] where product_id="+id;
                DBConnect db = new DBConnect();
                db.Executequery(deletequery);
                MessageBox.Show("Product Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Product already sold to customer delete customer details");
            }
        }
    }
}
