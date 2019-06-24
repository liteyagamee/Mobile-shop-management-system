namespace MobileShopManagementSystem.View
{
    partial class AddCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.custdatagrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.cmbprodid = new System.Windows.Forms.ComboBox();
            this.btnassignpro = new System.Windows.Forms.Button();
            this.proddatagrid = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.custdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proddatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone";
            // 
            // txtcustname
            // 
            this.txtcustname.BackColor = System.Drawing.Color.White;
            this.txtcustname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(105, 29);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.Size = new System.Drawing.Size(193, 23);
            this.txtcustname.TabIndex = 4;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.White;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(105, 58);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(193, 23);
            this.txtaddress.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(105, 87);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(193, 23);
            this.txtemail.TabIndex = 6;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.White;
            this.txtphone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(105, 116);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(193, 23);
            this.txtphone.TabIndex = 7;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(104, 156);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 42);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.IndianRed;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(206, 156);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(92, 42);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // custdatagrid
            // 
            this.custdatagrid.AllowUserToAddRows = false;
            this.custdatagrid.AllowUserToDeleteRows = false;
            this.custdatagrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.custdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custdatagrid.Location = new System.Drawing.Point(319, 26);
            this.custdatagrid.Name = "custdatagrid";
            this.custdatagrid.ReadOnly = true;
            this.custdatagrid.Size = new System.Drawing.Size(495, 171);
            this.custdatagrid.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(5, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Customer Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(6, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Buying Product ";
            // 
            // cmbcustid
            // 
            this.cmbcustid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcustid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(105, 229);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(193, 23);
            this.cmbcustid.TabIndex = 13;
            // 
            // cmbprodid
            // 
            this.cmbprodid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprodid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbprodid.FormattingEnabled = true;
            this.cmbprodid.Location = new System.Drawing.Point(105, 288);
            this.cmbprodid.Name = "cmbprodid";
            this.cmbprodid.Size = new System.Drawing.Size(193, 23);
            this.cmbprodid.TabIndex = 14;
            // 
            // btnassignpro
            // 
            this.btnassignpro.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnassignpro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassignpro.Location = new System.Drawing.Point(149, 356);
            this.btnassignpro.Name = "btnassignpro";
            this.btnassignpro.Size = new System.Drawing.Size(98, 45);
            this.btnassignpro.TabIndex = 15;
            this.btnassignpro.Text = "Assign Product";
            this.btnassignpro.UseVisualStyleBackColor = false;
            this.btnassignpro.Click += new System.EventHandler(this.btnassignpro_Click);
            // 
            // proddatagrid
            // 
            this.proddatagrid.BackgroundColor = System.Drawing.Color.LightBlue;
            this.proddatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proddatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.proddatagrid.Location = new System.Drawing.Point(319, 219);
            this.proddatagrid.Name = "proddatagrid";
            this.proddatagrid.Size = new System.Drawing.Size(495, 181);
            this.proddatagrid.TabIndex = 16;
            this.proddatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proddatagrid_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForLinkValue = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(316, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Customer Information";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(316, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Product Infromation";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(820, 407);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.proddatagrid);
            this.Controls.Add(this.btnassignpro);
            this.Controls.Add(this.cmbprodid);
            this.Controls.Add(this.cmbcustid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.custdatagrid);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtcustname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCustomer";
            this.Text = "Add Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.custdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proddatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.DataGridView custdatagrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcustid;
        private System.Windows.Forms.ComboBox cmbprodid;
        private System.Windows.Forms.Button btnassignpro;
        private System.Windows.Forms.DataGridView proddatagrid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}