using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoDatabaseGroupStudy.DAL;
using EmployeeInfoDatabaseGroupStudy.Model;

namespace EmployeeInfoDatabaseGroupStudy.BLL
{
    class EmployeeManager
    {
        EmployeeGateway employeeGateway = new EmployeeGateway();
        public List<Employee> Search(string searchText)
        {
            return employeeGateway.search(searchText);
            
        }
    }
}
