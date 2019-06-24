using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MobileShopManagementSystem.Model;
using MobileShopManagementSystem.View;

namespace MobileShopManagementSystem.Controller
{
    public class LoginControl
    {
       public void LogControl(string user, string pass)
       {
            try
            {
                string query = "Select * from [UserTbl] where username='" + user + "' and password='" + pass + "'";
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    Dashboard dash = new Dashboard();
                    dash.UserId = Convert.ToInt32(dt.Rows[0]["user_id"]);
                    dash.Show();
                }
                else
                {
                    MessageBox.Show("Username and Password Incorrect");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
       }
    }
}