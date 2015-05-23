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

        public List<Employee> search(string name)
        {
            List<Employee> employees = new List<Employee>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT Name,Email FROM tbl_EmployeeInfo WHERE Name LIKE '"+name+"%' ORDER BY Name";

            SqlCommand command = new SqlCommand(query,connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            
            while (reader.Read())
            {
                Employee anEmployee=new Employee();
                
                anEmployee.Name = reader["Name"].ToString();
                anEmployee.Email = reader["Email"].ToString();
               
              
                employees.Add(anEmployee);

            }
            return employees;
        }

      
    }
    
}
