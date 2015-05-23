using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoDatabaseGroupStudy.Model;

namespace EmployeeInfoDatabaseGroupStudy.DAL
{
    
    class EmployeeGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;

        public int Save(Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO tbl_EmployeeInfo Values('"+employee.Name+"','"+employee.Email+"','"+employee.Address+"','"+employee.ADesignation.Id+"')";
       
            SqlCommand command=new SqlCommand(query,connection);

            int rowsEffected=command.ExecuteNonQuery();

            return rowsEffected;
        }

        public List<Employee> GetAllEmloyee()
        {
            SqlConnection connection=new SqlConnection(connectionString);

            string query = "SELECT * FROM tbl_EmployeeInfo ";
            SqlCommand command=new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Employee>employeeList=new List<Employee>();
            while (reader.Read())
            {
                Employee employee=new Employee();
                employee.Name = reader["Name"].ToString();
                employee.Email = reader["Email"].ToString();
                employee.Address = reader["Address"].ToString();
               // employee.ADesignation.Id =int.Parse( reader["DesignationId"].ToString());
                employeeList.Add(employee);
            }
            reader.Close();
            connection.Close();
            return employeeList;
        }

        public bool IsEmailExist(string email)
        {
            bool isEmailExist = false;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Email FROM tbl_EmployeeInfo WHERE Email='"+email+"'";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                isEmailExist = true;
                break;

            }
            reader.Close();
            connection.Close();
        }
    }
    
}
