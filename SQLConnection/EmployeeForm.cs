using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLConnection
{
    public partial class EmployeeForm : Form
    {
        Employee employee = new Employee();

        public EmployeeForm()
        {
            InitializeComponent();
            dataGridView.DataSource = employee.GetEmployee();
            comboBoxGender.Items.Add("Nam");
            comboBoxGender.Items.Add("Nữ");
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void ClearControls()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxAge.Text = "";
            textBoxContact.Text = "";
            comboBoxGender.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddValues();
            var sucess = employee.Insert(employee);
            dataGridView.DataSource = employee.GetEmployee();

            if (sucess)
            {
                ClearControls();
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại. Kiểm tra lại!");
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AddValues();
            var sucess = employee.Update(employee);
            dataGridView.DataSource = employee.GetEmployee();

            if (sucess)
            {
                ClearControls();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại. Kiểm tra lại!");
            }
        }

        private void AddValues()
        {
            employee.EmpId = textBoxID.Text;
            employee.EmpName = textBoxName.Text;
            employee.EmpAge = int.Parse(textBoxAge.Text);
            employee.EmpContact = textBoxContact.Text;
            employee.EmpGender = comboBoxGender.Text;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            employee.EmpId = textBoxID.Text;
            var sucess = employee.DeleteEmployee(employee);
            dataGridView.DataSource = employee.GetEmployee();

            if (sucess)
            {
                ClearControls();
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Xóa thất bại. Kiểm tra lại!");
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            textBoxName.Text = dataGridView.Rows[index].Cells[1].Value.ToString();
            textBoxID.Text = dataGridView.Rows[index].Cells[0].Value.ToString();
            textBoxAge.Text = dataGridView.Rows[index].Cells[2].Value.ToString();
            textBoxContact.Text = dataGridView.Rows[index].Cells[3].Value.ToString();
            comboBoxGender.Text = dataGridView.Rows[index].Cells[4].Value.ToString();
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
