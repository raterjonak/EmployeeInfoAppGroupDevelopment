using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoDatabaseGroupStudy.DAL;
using EmployeeInfoDatabaseGroupStudy.Model;

namespace EmployeeInfoDatabaseGroupStudy.BLL
{
    class EmployeeManager
    {
        EmployeeGateway gateway=new EmployeeGateway();

        public List<Employee> GetAllEmployees()
        {
            return gateway.GetAllEmloyee();
        }


    }
}
