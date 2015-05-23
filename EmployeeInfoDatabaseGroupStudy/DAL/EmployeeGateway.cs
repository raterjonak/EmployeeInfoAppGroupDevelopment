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

    }
    
}
