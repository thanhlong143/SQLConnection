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

namespace SQLConnection
{
    public partial class CustomersForm1 : Form
    {

        private static string store = ConfigurationManager.AppSettings["CustomersConnectString"].ToString();
        private const string SelectQuery = "Select * from Customers";

        public CustomersForm1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string strCmd = "GetCategories";
            SqlConnection con = new SqlConnection(store);
            con.Open();

            SqlCommand cmd = new SqlCommand(strCmd, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet dsCategory = new DataSet();

            da.Fill(dsCategory, "Categories");

            dataGridViewCustomers.DataSource = dsCategory;
            dataGridViewCustomers.DataMember = "Categories";
        }

        private void buttonShowCustomers_Click(object sender, EventArgs e)
        {
            dataGridViewCustomers.DataSource = GetCustomers();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string strInsert = "SET IDENTITY_INSERT Customers On insert into Customers " + "(CustomerID, FullName, EmailAddress, Password) " +
                "values( " +
                        "'" + textBoxID.Text + "', " +
                        "N'" + textBoxName.Text + "', " +
                        "'" + textBoxEmail.Text + "', " +
                        "'" + textBoxPassword.Text + "')";
            SqlCommands(strInsert);

            dataGridViewCustomers.DataSource = GetCustomers();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string strUpdate = "Update Customers " +
                "set FullName = N'" + textBoxName.Text + "'," +
                "EmailAddress = '" + textBoxEmail.Text + "'," +
                "Password = '" + textBoxPassword.Text + "' " +
                "where CustomerID = '" + textBoxID.Text + "'";

            SqlCommands(strUpdate);

            dataGridViewCustomers.DataSource = GetCustomers();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string strDelete = "Delete from Customers " +
                "Where CustomerID='" + textBoxID.Text + "'";

            SqlCommands(strDelete);

            dataGridViewCustomers.DataSource = GetCustomers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            textBoxID.Text = dataGridViewCustomers.Rows[index].Cells[0].Value.ToString();
            textBoxName.Text = dataGridViewCustomers.Rows[index].Cells[1].Value.ToString();
            textBoxEmail.Text = dataGridViewCustomers.Rows[index].Cells[2].Value.ToString();
            textBoxPassword.Text = dataGridViewCustomers.Rows[index].Cells[3].Value.ToString();
        }

        public DataTable GetCustomers()
        {
            var datatable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(store))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(SelectQuery, sqlCon))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(datatable);
                    }
                }
            }
            return datatable;
        }

        private static void SqlCommands(string str)
        {
            SqlCommand cmd;
            SqlConnection con = new SqlConnection(store);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Đóng chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
