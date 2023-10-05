using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SQLConnection
{
    public partial class CustomerSearch : Form
    {
        Customers currentCustomer;

        private string strConnect = ConfigurationManager.AppSettings["CustomersConnectString"].ToString();

        public CustomerSearch()
        {
            InitializeComponent();
        }

        public void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strSearch = "'%" + textBoxSearch.Text + "%'";
                string strCommand = "Select * From Customers where FullName like " + strSearch;

                SqlConnection myConnection = new SqlConnection(strConnect);
                myConnection.Open();
                MessageBox.Show("Kết nối cơ sở dữ liệu thành công!");

                SqlCommand myCommand = new SqlCommand(strCommand, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataSet ds = new DataSet();
                da.Fill(ds, "MyCustomers");
                dataGridViewCustomers.DataSource = ds;
                dataGridViewCustomers.DataMember = "MyCustomers";

                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có lỗi");
            }
        }

        private void dataGridViewCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            DataGridViewRow dr = dataGridViewCustomers.Rows[index];
            if (dr != null)
            {
                currentCustomer = new Customers();
                currentCustomer.CustomerID = dr.Cells["CustomerID"].Value.ToString();
                currentCustomer.FullName = dr.Cells["FullName"].Value.ToString();
                currentCustomer.Email = dr.Cells["EmailAddress"].Value.ToString();
                currentCustomer.Password = dr.Cells["Password"].Value.ToString();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CustomersForm2 customers = new CustomersForm2(true);
            customers.ShowDialog();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CustomersForm2 formCustomers = new CustomersForm2(false);
            formCustomers.currentCustomer = new Customers();
            formCustomers.currentCustomer = currentCustomer;
            formCustomers.ShowDialog();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentCustomer != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa khách hàng?" + currentCustomer.FullName, "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        string strDelete = "Delete from Customers Where CustomerID = '" + currentCustomer.CustomerID.ToString() + "'";
                        SqlConnection myConnection = new SqlConnection(strConnect);
                        myConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(strDelete, myConnection);
                        sqlCommand.ExecuteNonQuery();
                        myConnection.Close();
                        buttonSearch_Click(sender, e);
                    }
                    else if (dr == DialogResult.No)
                    {
                        buttonSearch_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi " + ex.Message.ToString(), "Có Lỗi");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn đóng form không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
