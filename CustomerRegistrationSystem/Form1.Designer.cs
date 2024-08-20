namespace CustomerRegistrationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgrwCustomers = new DataGridView();
            tbxCustomerId = new TextBox();
            tbxCustomerFirstName = new TextBox();
            tbxCustomerLastName = new TextBox();
            tbxCustomerEmail = new TextBox();
            tbxCustomerCity = new TextBox();
            lblCustomerId = new Label();
            lblCustomerFirstName = new Label();
            lblCustomerLastName = new Label();
            lblCustomerEmail = new Label();
            lblCustomerCity = new Label();
            gbxAdd = new GroupBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).BeginInit();
            gbxAdd.SuspendLayout();
            SuspendLayout();
            // 
            // dgrwCustomers
            // 
            dgrwCustomers.BackgroundColor = SystemColors.Desktop;
            dgrwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgrwCustomers.Dock = DockStyle.Top;
            dgrwCustomers.Location = new Point(0, 0);
            dgrwCustomers.Name = "dgrwCustomers";
            dgrwCustomers.RowHeadersWidth = 62;
            dgrwCustomers.Size = new Size(1187, 267);
            dgrwCustomers.TabIndex = 0;
            // 
            // tbxCustomerId
            // 
            tbxCustomerId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxCustomerId.ForeColor = Color.Black;
            tbxCustomerId.Location = new Point(252, 70);
            tbxCustomerId.Name = "tbxCustomerId";
            tbxCustomerId.Size = new Size(319, 39);
            tbxCustomerId.TabIndex = 1;
            // 
            // tbxCustomerFirstName
            // 
            tbxCustomerFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxCustomerFirstName.ForeColor = Color.Black;
            tbxCustomerFirstName.Location = new Point(252, 128);
            tbxCustomerFirstName.Name = "tbxCustomerFirstName";
            tbxCustomerFirstName.Size = new Size(319, 39);
            tbxCustomerFirstName.TabIndex = 2;
            // 
            // tbxCustomerLastName
            // 
            tbxCustomerLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxCustomerLastName.ForeColor = Color.Black;
            tbxCustomerLastName.Location = new Point(252, 186);
            tbxCustomerLastName.Name = "tbxCustomerLastName";
            tbxCustomerLastName.Size = new Size(319, 39);
            tbxCustomerLastName.TabIndex = 3;
            // 
            // tbxCustomerEmail
            // 
            tbxCustomerEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxCustomerEmail.ForeColor = Color.Black;
            tbxCustomerEmail.Location = new Point(252, 248);
            tbxCustomerEmail.Name = "tbxCustomerEmail";
            tbxCustomerEmail.Size = new Size(319, 39);
            tbxCustomerEmail.TabIndex = 4;
            // 
            // tbxCustomerCity
            // 
            tbxCustomerCity.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            tbxCustomerCity.ForeColor = Color.Black;
            tbxCustomerCity.Location = new Point(252, 309);
            tbxCustomerCity.Name = "tbxCustomerCity";
            tbxCustomerCity.Size = new Size(319, 39);
            tbxCustomerCity.TabIndex = 5;
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerId.ForeColor = Color.White;
            lblCustomerId.Location = new Point(59, 73);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(157, 32);
            lblCustomerId.TabIndex = 6;
            lblCustomerId.Text = "Customer ID";
            // 
            // lblCustomerFirstName
            // 
            lblCustomerFirstName.AutoSize = true;
            lblCustomerFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerFirstName.ForeColor = Color.White;
            lblCustomerFirstName.Location = new Point(59, 134);
            lblCustomerFirstName.Name = "lblCustomerFirstName";
            lblCustomerFirstName.Size = new Size(81, 32);
            lblCustomerFirstName.TabIndex = 7;
            lblCustomerFirstName.Text = "Name";
            // 
            // lblCustomerLastName
            // 
            lblCustomerLastName.AutoSize = true;
            lblCustomerLastName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerLastName.ForeColor = Color.White;
            lblCustomerLastName.Location = new Point(59, 189);
            lblCustomerLastName.Name = "lblCustomerLastName";
            lblCustomerLastName.Size = new Size(115, 32);
            lblCustomerLastName.TabIndex = 8;
            lblCustomerLastName.Text = "Surname";
            // 
            // lblCustomerEmail
            // 
            lblCustomerEmail.AutoSize = true;
            lblCustomerEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerEmail.ForeColor = Color.White;
            lblCustomerEmail.Location = new Point(59, 251);
            lblCustomerEmail.Name = "lblCustomerEmail";
            lblCustomerEmail.Size = new Size(175, 32);
            lblCustomerEmail.TabIndex = 9;
            lblCustomerEmail.Text = "Email Address";
            // 
            // lblCustomerCity
            // 
            lblCustomerCity.AutoSize = true;
            lblCustomerCity.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCustomerCity.ForeColor = Color.White;
            lblCustomerCity.Location = new Point(59, 309);
            lblCustomerCity.Name = "lblCustomerCity";
            lblCustomerCity.Size = new Size(58, 32);
            lblCustomerCity.TabIndex = 10;
            lblCustomerCity.Text = "City";
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(tbxCustomerId);
            gbxAdd.Controls.Add(lblCustomerCity);
            gbxAdd.Controls.Add(tbxCustomerFirstName);
            gbxAdd.Controls.Add(lblCustomerEmail);
            gbxAdd.Controls.Add(tbxCustomerLastName);
            gbxAdd.Controls.Add(lblCustomerLastName);
            gbxAdd.Controls.Add(tbxCustomerEmail);
            gbxAdd.Controls.Add(lblCustomerFirstName);
            gbxAdd.Controls.Add(tbxCustomerCity);
            gbxAdd.Controls.Add(lblCustomerId);
            gbxAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gbxAdd.ForeColor = Color.Cyan;
            gbxAdd.Location = new Point(233, 293);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(687, 473);
            gbxAdd.TabIndex = 11;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add Customer";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.FromArgb(128, 255, 255);
            btnAdd.Location = new Point(433, 372);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 45);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1187, 798);
            Controls.Add(gbxAdd);
            Controls.Add(dgrwCustomers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgrwCustomers).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgrwCustomers;
        private TextBox tbxCustomerId;
        private TextBox tbxCustomerFirstName;
        private TextBox tbxCustomerLastName;
        private TextBox tbxCustomerEmail;
        private TextBox tbxCustomerCity;
        private Label lblCustomerId;
        private Label lblCustomerFirstName;
        private Label lblCustomerLastName;
        private Label lblCustomerEmail;
        private Label lblCustomerCity;
        private GroupBox gbxAdd;
        private Button btnAdd;
    }
}
