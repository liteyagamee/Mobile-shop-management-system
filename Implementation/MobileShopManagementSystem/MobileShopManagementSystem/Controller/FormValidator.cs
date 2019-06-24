using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MobileShopManagementSystem.Controller
{
    public class FormValidator
    {
        public static bool CheckDuplicateUser(string UserName)
        {
            string query = "Select * from [UserTbl] where username='" + UserName + "'";
            Model.DBConnect db = new Model.DBConnect();
            DataTable dtUser = db.GetData(query);
            if (dtUser.Rows.Count > 0)
                return true;
            else
                return false;
        }
        public static bool CheckPasswordLength(string Password)
        {
            if (Password.Length > 5)
                return true;
            else
                return false;
        }
        public static bool CheckEmail(string email)
        {
            if (email.Contains("@"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckTwoPassword(string password, string ConfirmPassword)
        {
            if (password == ConfirmPassword)
                return true;
            else
                return false;
        }
    }
}
