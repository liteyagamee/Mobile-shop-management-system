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
    public class UserControl
    {
        public void UsrControl(string frst, string lst, string phn, string eml, string gen,
           string usr, string pass, string repas,User user)
        {
            try
            {
                if(user != null )
                {
                    string query = "Update [UserTbl] set first_name='" + frst + "',last_name='" + lst + "',phone='" + phn +
                         "',email='" + eml + "',gender='" + gen + "',username='" + usr + "',password='" + pass +
                         "' where user_id='" + user.UserId + "'";
                    DBConnect dbc = new DBConnect();
                    dbc.Executequery(query);
                    MessageBox.Show("User updated successfully");                 
                }
                else
                {
                    string query = "Insert into [UserTbl] values('" + frst + "','" + lst + "','" + phn + "','" + eml 
                        + "','" + gen + "','" + usr + "','" + pass + "')";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("User registered successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DisplayUs(int UserId,DataGridView dv)
        {
            try
            {
                string query = "Select * from [UserTbl] where user_id='" + UserId + "' ";
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                dv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteUser(string id)
        {
            try
            { 
            string deletequery = "Delete from [UserTbl] where user_id=" + id;
            DBConnect db = new DBConnect();
            db.Executequery(deletequery);
            MessageBox.Show("User account Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
