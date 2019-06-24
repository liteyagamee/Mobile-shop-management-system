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
    public partial class DisplayProduct : Form
    {
        public DisplayProduct()
        {
            InitializeComponent();
        }
        private void DisplayProduct_Load(object sender, EventArgs e)
        {
            ProductControl pc = new ProductControl();
            pc.Displayprod(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the product details?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                       ProductControl pc = new ProductControl();
                       pc.deleteprod(id);
                       pc.Displayprod(dataGridView1);
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
            else if (command.ToLower() == "edit")
            {
                string query = "Select * from [ProductTbl] where product_id=" + id;
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                if (dt.Rows.Count > 0)
                {
                    Product p = new Product();
                    p.ProId = (int)dt.Rows[0]["product_id"];
                    p.ProductName = (string)dt.Rows[0]["product_name"];
                    p.Description = (string)dt.Rows[0]["product_description"];
                    p.Price = float.Parse(Convert.ToString(dt.Rows[0]["price"]));
                    p.Model = (string)dt.Rows[0]["model"];
                    p.Color = (string)dt.Rows[0]["color"];
                    p.Brand = (string)dt.Rows[0]["brand"];
                    p.IMEI = (string)dt.Rows[0]["IMEI"];
                    AddProduct ap = new AddProduct(p);
                    ap.Show();
                    this.Close();
                }
            }
        }
    }
}
