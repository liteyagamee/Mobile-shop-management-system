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
    public partial class DisplayBill : Form
    {
        public DisplayBill()
        {
            InitializeComponent();
        }
        private void DisplayBill_Load(object sender, EventArgs e)
        {
            BillControl bc = new BillControl();
            bc.DispBill(dataGridView1);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string command = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            if (command.ToLower() == "delete")
            {
                try
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the customers bill?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        BillControl bc = new BillControl();
                        bc.DeleteBill(id);
                        bc.DispBill(dataGridView1);
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
        }
    }
}
