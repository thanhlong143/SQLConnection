using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLConnection
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpAge { get; set; }
        public string EmpContact { get; set; }
        public string EmpGender { get; set; }
        int rows;

        private static string conn = ConfigurationManager.AppSettings["EmployeeConnectString"].ToString();
        private const string InsertQuery = "Insert into Employee_Details(EmpId, EmpName, EmpAge, EmpContact, EmpGender) " +
            "values (@EmpId, @EmpName, @EmpAge, @EmpContact, @EmpGender)";
        private const string SelectQuery = "Select * from Employee_Details";
        private const string DeleteQuery = "Delete from Employee_Details where EmpId=@EmpId";
        private const string UpdateQuery = "Update Employee_Details set EmpName=@EmpName, EmpAge=@EmpAge, EmpContact=@EmpContact, EmpGender=@EmpGender where EmpId=@EmpId";
    
        public bool Insert(Employee employee)
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(InsertQuery, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@EmpId", employee.EmpId);
                    cmd.Parameters.AddWithValue("@EmpName", employee.EmpName);
                    cmd.Parameters.AddWithValue("@EmpAge", employee.EmpAge);
                    cmd.Parameters.AddWithValue("@EmpContact", employee.EmpContact);
                    cmd.Parameters.AddWithValue("@EmpGender", employee.EmpGender);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool Update(Employee employee)
        {
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(UpdateQuery, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@EmpId", employee.EmpId);
                    cmd.Parameters.AddWithValue("@EmpName", employee.EmpName);
                    cmd.Parameters.AddWithValue("@EmpAge", employee.EmpAge);
                    cmd.Parameters.AddWithValue("@EmpContact", employee.EmpContact);
                    cmd.Parameters.AddWithValue("@EmpGender", employee.EmpGender);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public bool DeleteEmployee(Employee employee)
        {
            int rows;
            using (SqlConnection sqlCon = new SqlConnection(conn))
            {
                sqlCon.Open();
                using (SqlCommand cmd = new SqlCommand(DeleteQuery, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@EmpId", employee.EmpId);
                    rows = cmd.ExecuteNonQuery();
                }
            }
            return (rows > 0) ? true : false;
        }

        public DataTable GetEmployee()
        {
            var datatable = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(conn))
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
    }
}
