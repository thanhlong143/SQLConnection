namespace SQLConnection
{
    partial class CustomersForm2
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
            panelTop = new Panel();
            labelTitle = new Label();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelFill = new Panel();
            labelPassword = new Label();
            labelEmail = new Label();
            labelFullName = new Label();
            labelCustomerID = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxFullName = new TextBox();
            textBoxCustomerID = new TextBox();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(719, 87);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(298, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(126, 21);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Customers Form";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 425);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(719, 74);
            panelBottom.TabIndex = 1;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(417, 33);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(215, 33);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(labelPassword);
            panelFill.Controls.Add(labelEmail);
            panelFill.Controls.Add(labelFullName);
            panelFill.Controls.Add(labelCustomerID);
            panelFill.Controls.Add(textBoxPassword);
            panelFill.Controls.Add(textBoxEmail);
            panelFill.Controls.Add(textBoxFullName);
            panelFill.Controls.Add(textBoxCustomerID);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 87);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(719, 338);
            panelFill.TabIndex = 2;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(55, 208);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(79, 21);
            labelPassword.TabIndex = 7;
            labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(55, 150);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "Email:";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(55, 92);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(80, 21);
            labelFullName.TabIndex = 5;
            labelFullName.Text = "FullName:";
            // 
            // labelCustomerID
            // 
            labelCustomerID.AutoSize = true;
            labelCustomerID.Location = new Point(55, 32);
            labelCustomerID.Name = "labelCustomerID";
            labelCustomerID.Size = new Size(96, 21);
            labelCustomerID.TabIndex = 4;
            labelCustomerID.Text = "CustomerID:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(158, 205);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(549, 29);
            textBoxPassword.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(158, 147);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(549, 29);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(158, 89);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(549, 29);
            textBoxFullName.TabIndex = 1;
            // 
            // textBoxCustomerID
            // 
            textBoxCustomerID.Location = new Point(158, 29);
            textBoxCustomerID.Name = "textBoxCustomerID";
            textBoxCustomerID.Size = new Size(549, 29);
            textBoxCustomerID.TabIndex = 0;
            // 
            // CustomersForm2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 499);
            Controls.Add(panelFill);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            Name = "CustomersForm2";
            Text = "CustomersForm2";
            Load += CustomerForm2_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBottom.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Panel panelBottom;
        private Panel panelFill;
        private Button buttonCancel;
        private Button buttonSave;
        private Label labelTitle;
        private Label labelPassword;
        private Label labelEmail;
        private Label labelFullName;
        private Label labelCustomerID;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxFullName;
        private TextBox textBoxCustomerID;
    }
}