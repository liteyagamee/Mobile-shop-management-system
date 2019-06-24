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
    public class EmployeeControl
    {
        public void EmpControl(string name,string address,string gender,string phn,string email,float salary,int uid,Employee emp)
        {
            try
            { 
                if(emp != null)
                {
                    string query = "Update [EmployeeTbl] set name='" + name + "',address='" + address +
                        "',gender ='" + gender + "',phone='" + phn + "',email='" + email + "',salary='" 
                        + salary + "',user_id='" + uid + "' where employee_id='" + emp.EmpId + "' ";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("Employee details updated successfully");
                }
                else
                {
                    string query = "Insert into [EmployeeTbl] values('" + name + "','" + address + "','" + 
                        gender + "','" + phn + "','" + email + "','" + salary + "','" + uid + "')";
                    DBConnect db = new DBConnect();
                    db.Executequery(query);
                    MessageBox.Show("Employee added successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DispEmp(DataGridView dv)
        {
            try
            { 
            string query = "Select * from [EmployeeTbl]";
            DBConnect db = new DBConnect();
            DataTable dt = db.GetData(query);
            dv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DelEmp(string id)
        {
            try
            { 
            string deletequery = "Delete from [EmployeeTbl] where employee_id=" + id;
            DBConnect db = new DBConnect();
            db.Executequery(deletequery);
            MessageBox.Show("Employee details Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
