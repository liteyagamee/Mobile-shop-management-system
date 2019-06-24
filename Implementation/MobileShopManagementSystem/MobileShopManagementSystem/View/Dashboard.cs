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

namespace MobileShopManagementSystem.View
{
    public partial class Dashboard : Form
    {
        public int UserId = 0;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
                SearchDashControl sd = new SearchDashControl();
                sd.Dispprod(dataGridView1);
                sd.Dispsale(dataGridView2);
           
        }
        private void addInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmpolyee AE = new AddEmpolyee(null)
            {
                UserId = this.UserId
            };
            AE.Show();
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer AC = new AddCustomer(null)
            {
                UserId = this.UserId
            };
            AC.Show();
        }
        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayUser DU = new DisplayUser
            {
                UserId = this.UserId
            };
            DU.Show();
        }
        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct AP = new AddProduct(null);
            AP.Show();
        }
        private void displayInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayEmployee DE = new DisplayEmployee
            {
                UserId = this.UserId
            };
            DE.Show();
        }
        private void displayCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayCustomer DC = new DisplayCustomer
            {
                UserID =this.UserId
            };
            DC.Show();
        }

        private void displayProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayProduct DP = new DisplayProduct();
            DP.Show();
        }

        private void createBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBill Ab = new AddBill();
            Ab.Show();
        }
        private void displayInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DisplayBill db = new DisplayBill();
            db.Show();
        }
        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void searchReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search s = new Search();
            s.Show();
        }
    }
}
