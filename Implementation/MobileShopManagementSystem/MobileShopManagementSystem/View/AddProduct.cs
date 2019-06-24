using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobileShopManagementSystem.Controller;
using MobileShopManagementSystem.Model;

namespace MobileShopManagementSystem.View
{
    public partial class AddProduct : Form
    {
        Product oldprod = new Product();
        public AddProduct(Product p)
        {
            oldprod = p;
            InitializeComponent();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Enter the product name");
            }
            else if (rtbproductdesc.Text == "")
            {
                MessageBox.Show("Enter the description of product");
            }
            else if (txtprodmodel.Text == "")
            {
                MessageBox.Show("Enter the model name of product");
            }
            else if (txtbrand.Text == "")
            {
                MessageBox.Show("Enter the brand name");
            }
            else if (txtprice.Text == "")
            {
                MessageBox.Show("Enter the price of product");
            }
            else if (txtcolor.Text == "")
            {
                MessageBox.Show("Enter the color of product");
            }
            else
            {
                Product p = new Product
                {
                    ProductName = txtname.Text,
                    Description = rtbproductdesc.Text,
                    Price = float.Parse(txtprice.Text),
                    Model = txtprodmodel.Text,
                    Color = txtcolor.Text,
                    Brand = txtbrand.Text,
                    IMEI = txtimei.Text
                };
                ProductControl PC = new ProductControl();
                PC.ProControl(p.ProductName, p.Description, p.Price, p.Model, p.Color, p.Brand, p.IMEI,oldprod);
                if(oldprod != null)
                {
                    this.Close();
                    DisplayProduct dp = new DisplayProduct();
                    dp.Show();
                }
            }
        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Text = string.Empty;
            rtbproductdesc.Text =string.Empty;
            txtprice.Text = string.Empty;
            txtbrand.Text = string.Empty;
            txtcolor.Text = string.Empty;
            txtprodmodel.Text = string.Empty;
            txtimei.Text = string.Empty;
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            if(oldprod != null)
            {
                txtname.Text = oldprod.ProductName;
                rtbproductdesc.Text = oldprod.Description;
                txtprice.Text = Convert.ToString(oldprod.Price);
                txtbrand.Text = oldprod.Brand;
                txtprodmodel.Text = oldprod.Model;
                txtcolor.Text = oldprod.Color;
                txtimei.Text = oldprod.IMEI;
            }
        }
    }
}
