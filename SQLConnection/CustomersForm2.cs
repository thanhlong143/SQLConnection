using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQLConnection
{
    public partial class CustomersForm2 : Form
    {
        public bool isAddNew = true;
        public Customers currentCustomer;

        public CustomersForm2()
        {
            InitializeComponent();
        }

        public CustomersForm2(bool isAddNew)
        {
            this.isAddNew = isAddNew;
            InitializeComponent();
        }

        private void CustomerForm2_Load(object sender, EventArgs e)
        {
            textBoxCustomerID.Enabled = false;
            if (isAddNew)
            {
                textBoxCustomerID.Enabled = true;
                labelTitle.Text = "Add new customer";
            }
            else
            {
                labelTitle.Text = "Edit Customer";
                if (currentCustomer != null)
                {
                    textBoxCustomerID.Text = currentCustomer.CustomerID.ToString();
                    textBoxFullName.Text = currentCustomer.FullName.ToString();
                    textBoxEmail.Text = currentCustomer.Email.ToString();
                    textBoxPassword.Text = currentCustomer.Password.ToString();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string strConnect = ConfigurationManager.AppSettings["CustomersConnectString"].ToString();

            /*if (isAddNew)
            {*/
            string strInsert = "SET IDENTITY_INSERT Customers ON insert into Customers " + "(CustomerID, FullName, EmailAddress, Password) " +
                "values( " +
                        "'" + textBoxCustomerID.Text + "', " +
                        "N'" + textBoxFullName.Text + "', " +
                        "'" + textBoxEmail.Text + "', " +
                        "'" + textBoxPassword.Text + "')";

            SqlConnection con = new SqlConnection(strConnect);
            con.Open();
            SqlCommand sqlCommand = new SqlCommand(strInsert, con);
            sqlCommand.ExecuteNonQuery();
            con.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đóng form không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
