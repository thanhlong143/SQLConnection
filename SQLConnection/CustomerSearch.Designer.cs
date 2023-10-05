namespace SQLConnection
{
    partial class CustomerSearch
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
            panelBottom = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            buttonClose = new Button();
            panelTop = new Panel();
            buttonSearch = new Button();
            textBoxSearch = new TextBox();
            labelSearch = new Label();
            dataGridViewCustomers = new DataGridView();
            panelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonDelete);
            panelBottom.Controls.Add(buttonEdit);
            panelBottom.Controls.Add(buttonAdd);
            panelBottom.Controls.Add(buttonClose);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 503);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1061, 80);
            panelBottom.TabIndex = 0;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(271, 29);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(140, 29);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 29);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(926, 29);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 0;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(buttonSearch);
            panelTop.Controls.Add(textBoxSearch);
            panelTop.Controls.Add(labelSearch);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1061, 90);
            panelTop.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(926, 31);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(106, 31);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(805, 29);
            textBoxSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new Point(12, 34);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(60, 21);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search:";
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Dock = DockStyle.Fill;
            dataGridViewCustomers.Location = new Point(0, 90);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.RowTemplate.Height = 31;
            dataGridViewCustomers.Size = new Size(1061, 413);
            dataGridViewCustomers.TabIndex = 2;
            dataGridViewCustomers.CellContentClick += dataGridViewCustomers_CellContentClick;
            // 
            // CustomerSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 583);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            Name = "CustomerSearch";
            Text = "CustomerSearch";
            panelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBottom;
        private Button buttonClose;
        private Panel panelTop;
        private Button buttonSearch;
        private TextBox textBoxSearch;
        private Label labelSearch;
        private DataGridView dataGridViewCustomers;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonAdd;
    }
}