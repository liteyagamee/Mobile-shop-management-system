namespace MobileShopManagementSystem.View
{
    partial class AddBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBill));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.rbothers = new System.Windows.Forms.RadioButton();
            this.rbcheque = new System.Windows.Forms.RadioButton();
            this.rbcash = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnremove = new System.Windows.Forms.Button();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtpaidamt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgrandtot = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnadditem = new System.Windows.Forms.Button();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbprodname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcustname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnclear = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(511, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 220);
            this.dataGridView1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(511, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 15);
            this.label12.TabIndex = 29;
            this.label12.Text = "Customers Product Information";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(511, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(438, 210);
            this.dataGridView2.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(511, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Created Bill  ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.rbothers);
            this.panel1.Controls.Add(this.rbcheque);
            this.panel1.Controls.Add(this.rbcash);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnremove);
            this.panel1.Controls.Add(this.txtamount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtbalance);
            this.panel1.Controls.Add(this.txtpaidamt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtgrandtot);
            this.panel1.Controls.Add(this.txtdiscount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txttotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnadditem);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbprodname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbcustname);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 471);
            this.panel1.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(4, 161);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 15);
            this.label16.TabIndex = 61;
            this.label16.Text = "Type of Payment";
            // 
            // rbothers
            // 
            this.rbothers.AutoSize = true;
            this.rbothers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbothers.Location = new System.Drawing.Point(232, 161);
            this.rbothers.Name = "rbothers";
            this.rbothers.Size = new System.Drawing.Size(63, 19);
            this.rbothers.TabIndex = 60;
            this.rbothers.TabStop = true;
            this.rbothers.Text = "Others";
            this.rbothers.UseVisualStyleBackColor = true;
            this.rbothers.CheckedChanged += new System.EventHandler(this.rbothers_CheckedChanged);
            // 
            // rbcheque
            // 
            this.rbcheque.AutoSize = true;
            this.rbcheque.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcheque.Location = new System.Drawing.Point(163, 161);
            this.rbcheque.Name = "rbcheque";
            this.rbcheque.Size = new System.Drawing.Size(67, 19);
            this.rbcheque.TabIndex = 59;
            this.rbcheque.TabStop = true;
            this.rbcheque.Text = "Cheque";
            this.rbcheque.UseVisualStyleBackColor = true;
            this.rbcheque.CheckedChanged += new System.EventHandler(this.rbcheque_CheckedChanged);
            // 
            // rbcash
            // 
            this.rbcash.AutoSize = true;
            this.rbcash.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcash.Location = new System.Drawing.Point(111, 161);
            this.rbcash.Name = "rbcash";
            this.rbcash.Size = new System.Drawing.Size(50, 19);
            this.rbcash.TabIndex = 58;
            this.rbcash.TabStop = true;
            this.rbcash.Text = "Cash";
            this.rbcash.UseVisualStyleBackColor = true;
            this.rbcash.CheckedChanged += new System.EventHandler(this.rbcash_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(218, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 57;
            this.label15.Text = "Invoice";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(172, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 20);
            this.label14.TabIndex = 56;
            this.label14.Text = "Xcuse Mobile Shop";
            // 
            // btnremove
            // 
            this.btnremove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(416, 154);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(83, 26);
            this.btnremove.TabIndex = 55;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = true;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click_1);
            // 
            // txtamount
            // 
            this.txtamount.Enabled = false;
            this.txtamount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(322, 124);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(92, 23);
            this.txtamount.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(273, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 53;
            this.label11.Text = "Amount";
            // 
            // txtquantity
            // 
            this.txtquantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantity.Location = new System.Drawing.Point(203, 125);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(64, 23);
            this.txtquantity.TabIndex = 52;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(142, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 51;
            this.label10.Text = "Quantity";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(223, 23);
            this.dateTimePicker1.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(236, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(310, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Balance";
            // 
            // txtbalance
            // 
            this.txtbalance.Enabled = false;
            this.txtbalance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(390, 438);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(109, 23);
            this.txtbalance.TabIndex = 45;
            // 
            // txtpaidamt
            // 
            this.txtpaidamt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidamt.Location = new System.Drawing.Point(390, 411);
            this.txtpaidamt.Name = "txtpaidamt";
            this.txtpaidamt.Size = new System.Drawing.Size(109, 23);
            this.txtpaidamt.TabIndex = 44;
            this.txtpaidamt.TextChanged += new System.EventHandler(this.txtpaidamt_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Paid";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "Grand Total";
            // 
            // txtgrandtot
            // 
            this.txtgrandtot.Enabled = false;
            this.txtgrandtot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrandtot.Location = new System.Drawing.Point(390, 385);
            this.txtgrandtot.Name = "txtgrandtot";
            this.txtgrandtot.Size = new System.Drawing.Size(109, 23);
            this.txtgrandtot.TabIndex = 41;
            this.txtgrandtot.Text = "0";
            // 
            // txtdiscount
            // 
            this.txtdiscount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscount.Location = new System.Drawing.Point(203, 386);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(100, 23);
            this.txtdiscount.TabIndex = 40;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 389);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Discount";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(39, 386);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 23);
            this.txttotal.TabIndex = 38;
            this.txttotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 389);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Total";
            // 
            // btnadditem
            // 
            this.btnadditem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadditem.Location = new System.Drawing.Point(416, 124);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(83, 29);
            this.btnadditem.TabIndex = 35;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.UseVisualStyleBackColor = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click_1);
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(45, 124);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(94, 23);
            this.txtprice.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Price";
            // 
            // cmbprodname
            // 
            this.cmbprodname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprodname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbprodname.FormattingEnabled = true;
            this.cmbprodname.Location = new System.Drawing.Point(104, 95);
            this.cmbprodname.Name = "cmbprodname";
            this.cmbprodname.Size = new System.Drawing.Size(126, 23);
            this.cmbprodname.TabIndex = 32;
            this.cmbprodname.SelectionChangeCommitted += new System.EventHandler(this.cmbprodname_SelectionChangeCommitted_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Product";
            // 
            // cmbcustname
            // 
            this.cmbcustname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcustname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustname.FormattingEnabled = true;
            this.cmbcustname.Location = new System.Drawing.Point(104, 56);
            this.cmbcustname.Name = "cmbcustname";
            this.cmbcustname.Size = new System.Drawing.Size(126, 23);
            this.cmbcustname.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Customer Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(5, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 180);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item Name";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Rate";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Quantity";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Amount";
            this.columnHeader4.Width = 95;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.IndianRed;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(318, 474);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 38);
            this.btnclear.TabIndex = 50;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnprint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Location = new System.Drawing.Point(225, 474);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(75, 38);
            this.btnprint.TabIndex = 49;
            this.btnprint.Text = "Print";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(131, 474);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 38);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // AddBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(954, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnprint);
            this.Name = "AddBill";
            this.Text = "Create Bill";
            this.Load += new System.EventHandler(this.AddBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtpaidamt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgrandtot;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnadditem;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbprodname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcustname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbothers;
        private System.Windows.Forms.RadioButton rbcheque;
        private System.Windows.Forms.RadioButton rbcash;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}