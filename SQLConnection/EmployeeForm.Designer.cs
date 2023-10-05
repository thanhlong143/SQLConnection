namespace SQLConnection
{
    partial class EmployeeForm
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
            labelID = new Label();
            labelName = new Label();
            labelAge = new Label();
            labelContact = new Label();
            labelGender = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            textBoxAge = new TextBox();
            textBoxContact = new TextBox();
            comboBoxGender = new ComboBox();
            dataGridView = new DataGridView();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            buttonClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(12, 33);
            labelID.Name = "labelID";
            labelID.Size = new Size(25, 21);
            labelID.TabIndex = 0;
            labelID.Text = "ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(12, 93);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Name";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Location = new Point(12, 153);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(37, 21);
            labelAge.TabIndex = 2;
            labelAge.Text = "Age";
            // 
            // labelContact
            // 
            labelContact.AutoSize = true;
            labelContact.Location = new Point(12, 213);
            labelContact.Name = "labelContact";
            labelContact.Size = new Size(63, 21);
            labelContact.TabIndex = 3;
            labelContact.Text = "Contact";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Location = new Point(12, 273);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(61, 21);
            labelGender.TabIndex = 4;
            labelGender.Text = "Gender";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(95, 30);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(287, 29);
            textBoxID.TabIndex = 5;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(95, 90);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(287, 29);
            textBoxName.TabIndex = 6;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(95, 150);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(287, 29);
            textBoxAge.TabIndex = 7;
            // 
            // textBoxContact
            // 
            textBoxContact.Location = new Point(95, 210);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.Size = new Size(287, 29);
            textBoxContact.TabIndex = 8;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(95, 270);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(287, 29);
            comboBoxGender.TabIndex = 9;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(423, 33);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 31;
            dataGridView.Size = new Size(652, 266);
            dataGridView.TabIndex = 10;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(95, 345);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(227, 345);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(94, 29);
            buttonEdit.TabIndex = 12;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(362, 345);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(494, 345);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 14;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(981, 345);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 15;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 424);
            Controls.Add(buttonClose);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEdit);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
            Controls.Add(comboBoxGender);
            Controls.Add(textBoxContact);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(labelGender);
            Controls.Add(labelContact);
            Controls.Add(labelAge);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelID;
        private Label labelName;
        private Label labelAge;
        private Label labelContact;
        private Label labelGender;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private TextBox textBoxAge;
        private TextBox textBoxContact;
        private ComboBox comboBoxGender;
        private DataGridView dataGridView;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonClear;
        private Button buttonClose;
    }
}