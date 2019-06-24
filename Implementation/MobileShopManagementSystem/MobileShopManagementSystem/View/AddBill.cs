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
    public partial class AddBill : Form
    {
        public AddBill()
        {
            InitializeComponent();
        }
        private void AddBill_Load(object sender, EventArgs e)
        {
                BillControl bc = new BillControl();
                bc.Combocustomer(cmbcustname);
                bc.Comboproduct(cmbprodname);
                bc.CustprodData(dataGridView1);
                bc.Dispcreatedbill(dataGridView2);
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            /*
            Graphics g = panel1.CreateGraphics();
            Size s = panel1.Size;
            bmp = new Bitmap(s.Width,s.Height, g);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(panel1.Location.X, panel1.Location.Y,0,0,s);
           */
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.panel1.Width, this.panel1.Height);
            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, this.panel1.Width, this.panel1.Height));
            e.Graphics.DrawImage(bmp,0,0);
        }

        private void txtquantity_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtdiscount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtdiscount.Text = txtdiscount.Text.Remove(txtdiscount.Text.Length - 1);
            }
            else if (txtquantity.Text.Length > 0)
            {
                txtamount.Text = (Convert.ToInt32(txtquantity.Text) * Convert.ToInt32(txtprice.Text)).ToString();
            }
        }

        private void txtdiscount_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtdiscount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtdiscount.Text = txtdiscount.Text.Remove(txtdiscount.Text.Length - 1);
            }
            else if (txtdiscount.Text.Length > 0)
            {
                txtgrandtot.Text = (Convert.ToInt32(txttotal.Text) - Convert.ToInt32(txtdiscount.Text)).ToString();
            }
        }

        private void txtpaidamt_TextChanged_1(object sender, EventArgs e)
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(txtdiscount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtdiscount.Text = txtdiscount.Text.Remove(txtdiscount.Text.Length - 1);
            }
            else if (txtpaidamt.Text.Length > 0)
            {
                txtbalance.Text = (Convert.ToInt32(txtpaidamt.Text) - Convert.ToInt32(txtgrandtot.Text)).ToString();
            }
        }

        private void btnadditem_Click_1(object sender, EventArgs e)
        {
            try
            {
                string id = cmbprodname.SelectedValue.ToString();
                string query = "select model from [ProductTbl] where product_id =" + id;
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                string model = Convert.ToString(dt.Rows[0]["model"]);
                string[] arr = new string[4];
                arr[0] = model;
                arr[1] = txtprice.Text;
                arr[2] = txtquantity.Text;
                arr[3] = txtamount.Text;

                ListViewItem lvi = new ListViewItem(arr);
                listView1.Items.Add(lvi);
                txttotal.Text = (Convert.ToInt32(txttotal.Text) + Convert.ToInt32(txtamount.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnremove_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected)
                    {
                        txttotal.Text = (Convert.ToInt32(txttotal.Text) - Convert.ToInt32(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                        txtgrandtot.Text = "0";
                        txtpaidamt.Text = "";
                        txtbalance.Text = "";
                    }
                }
            }
        }

        private void cmbprodname_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            try
            {
                string id = cmbprodname.SelectedValue.ToString();
                string query = "select price from [ProductTbl] where product_id =" + id;
                DBConnect db = new DBConnect();
                DataTable dt = db.GetData(query);
                txtprice.Text = Convert.ToString(dt.Rows[0]["price"]);

                txtquantity.Text = "";
                txtamount.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            if (txtprice.Text == "")
            {
                MessageBox.Show("Select the product for price");
            }
            else if (txtquantity.Text == "")
            {
                MessageBox.Show("Enter the product quantity");
            }
            else if (txtamount.Text == "")
            {
                MessageBox.Show("Enter the quantity for products amount");
            }
            else if (txttotal.Text == "")
            {
                MessageBox.Show("Add items for products total amount");
            }
            else if (txtdiscount.Text == "")
            {
                MessageBox.Show("Enter the discount amount ");
            }
            else if (txtgrandtot.Text == "")
            {
                MessageBox.Show("Enter the discount for grandtotal");
            }
            else if (radbtnvalue == "")
            {
                MessageBox.Show("Choose the payment Type");
            }
            else if (txtpaidamt.Text == "")
            {
                MessageBox.Show("Enter the paid amount for balancing");
            }
            else
            {
                Bill Bll = new Bill();
                Bll.Date = dateTimePicker1.Value.Date;
                Bll.CustId = Convert.ToInt32(cmbcustname.SelectedValue);
                Bll.TotalAmt = float.Parse(txttotal.Text);
                Bll.Discount = float.Parse(txtdiscount.Text);
                Bll.GrandTotal = float.Parse(txtgrandtot.Text);
                Bll.Payment = radbtnvalue;
                BillControl bc = new BillControl();
                bc.adbill(Bll.Date, Bll.CustId, Bll.TotalAmt, Bll.Discount, Bll.GrandTotal, Bll.Payment);
                bc.Dispcreatedbill(dataGridView2);
            }
        }
        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtprice.Text = "";
            txtquantity.Text = "";
            txtamount.Text = "";
            txttotal.Text = "0";
            txtdiscount.Text = "";
            txtgrandtot.Text = "0";
            txtpaidamt.Text = "";
            txtbalance.Text = "";
            listView1.Items.Clear();
        }
        string radbtnvalue = "";
        private void rbcash_CheckedChanged(object sender, EventArgs e)
        {
            radbtnvalue = "Cash";
        }
        private void rbcheque_CheckedChanged(object sender, EventArgs e)
        {
            radbtnvalue = "Cheque";
        }
        private void rbothers_CheckedChanged(object sender, EventArgs e)
        {
            radbtnvalue = "Others";
        }
    }
}