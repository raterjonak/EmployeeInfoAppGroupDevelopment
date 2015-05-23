using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EmployeeInfoDatabaseGroupStudy.DAL;
using EmployeeInfoDatabaseGroupStudy.Model;

namespace EmployeeInfoDatabaseGroupStudy.BLL
{
    class DesignationManager
    {
        DesignationGateway gateway = new DesignationGateway();
        public string Save(Designation aDesignation)
        {
            if (gateway.Save(aDesignation) >= 0)
            {
                return "Saved successfully";
            }
            else
            {
                return "Saved Failed.";
            }


        }

        public List<Designation> GetAllDesignations()
        {

            return gateway.GetDesignation();
        } 
    }
}
