namespace SQLConnection
{
    partial class CustomersForm1
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
            dataGridViewCustomers = new DataGridView();
            labelCustomerID = new Label();
            labelCustomerName = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            buttonShowProducts = new Button();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelPassword = new Label();
            labelEmail = new Label();
            buttonShowCustomers = new Button();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(12, 12);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.RowTemplate.Height = 31;
            dataGridViewCustomers.Size = new Size(957, 298);
            dataGridViewCustomers.TabIndex = 0;
            dataGridViewCustomers.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(12, 367);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(97, 21);
            labelCustomerID.TabIndex = 1;
            labelCustomerID.Text = "Customer ID";
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(12, 426);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(124, 21);
            labelCustomerName.TabIndex = 2;
            labelCustomerName.Text = "Customer Name";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(155, 364);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(291, 29);
            textBoxID.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(155, 423);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 4;
            // 
            // buttonShowProducts
            // 
            buttonShowProducts.Location = new Point(12, 502);
            buttonShowProducts.Name = "buttonShowProducts";
            buttonShowProducts.Size = new Size(141, 29);
            buttonShowProducts.TabIndex = 9;
            buttonShowProducts.Text = "Show Products";
            buttonShowProducts.UseVisualStyleBackColor = true;
            buttonShowProducts.Click += buttonShow_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(407, 502);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(531, 502);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 11;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(655, 502);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(678, 423);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(291, 29);
            textBoxPassword.TabIndex = 16;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(678, 364);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 29);
            textBoxEmail.TabIndex = 15;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(577, 426);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(76, 21);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(577, 367);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 21);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Email";
            // 
            // buttonShowCustomers
            // 
            buttonShowCustomers.Location = new Point(194, 502);
            buttonShowCustomers.Name = "buttonShowCustomers";
            buttonShowCustomers.Size = new Size(141, 29);
            buttonShowCustomers.TabIndex = 17;
            buttonShowCustomers.Text = "Show Customers";
            buttonShowCustomers.UseVisualStyleBackColor = true;
            buttonShowCustomers.Click += buttonShowCustomers_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(875, 502);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 18;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // CustomersForm1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 562);
            Controls.Add(buttonClose);
            Controls.Add(buttonShowCustomers);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(labelEmail);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(buttonShowProducts);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(labelCustomerName);
            Controls.Add(labelCustomerID);
            Controls.Add(dataGridViewCustomers);
            Name = "CustomersForm1";
            Text = "CustomersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCustomers;
        private Label labelCustomerID;
        private Label labelCustomerName;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private Button buttonShowProducts;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private Label labelPassword;
        private Label labelEmail;
        private Button buttonShowCustomers;
        private Button buttonClose;
    }
}