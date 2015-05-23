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
    class DesignationGateway
    {
       


        private string connectionString = ConfigurationManager.ConnectionStrings["EmployeeConnectionString"].ConnectionString;

        public int Save(Designation designation)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            

            string query = "INSERT INTO tbl_Designation Values('" + designation.Code + "','" + designation.Title + "')";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            int rowsEffected = command.ExecuteNonQuery();
            connection.Close();
            return rowsEffected;
        }


        public List<Designation> GetDesignation()
        {
            List<Designation>designations=new List<Designation>();

            SqlConnection connection = new SqlConnection(connectionString);



            string query = "SELECT * FROM tbl_Designation";

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Designation aDesignation=new Designation();

                aDesignation.Id = int.Parse(reader["Id"].ToString());
                aDesignation.Code = reader["Code"].ToString();
                aDesignation.Title = reader["Title"].ToString();

                designations.Add(aDesignation);

            }
            reader.Close();
            connection.Close();

            return designations;

        }




        
    }

    
}
