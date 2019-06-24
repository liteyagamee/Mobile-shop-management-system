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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        private void btncustsearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                SearchDashControl sd = new SearchDashControl();
                sd.Custsearch(textBox1.Text, dataGridView1);
            } 
            else
            {
                MessageBox.Show("Please enter ID or Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtprodsearch.Text != "")
            {
                SearchDashControl sdc = new SearchDashControl();
                sdc.Prodsearch(txtprodsearch.Text, dataGridView1);
            }
            else
            {
                MessageBox.Show("Please enter model,brand or product name");
            }
        }
    }
}
