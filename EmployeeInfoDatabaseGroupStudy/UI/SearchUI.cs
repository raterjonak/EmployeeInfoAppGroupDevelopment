using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInfoDatabaseGroupStudy.BLL;
using EmployeeInfoDatabaseGroupStudy.Model;

namespace EmployeeInfoDatabaseGroupStudy
{
    public partial class SearchUI : Form
    {
        public SearchUI()
        {
            InitializeComponent();
        }
        EmployeeManager anEmployeeManager = new EmployeeManager();
        private List<Employee> employees; 
        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text;
            employees=anEmployeeManager.Search(searchText);
        }
    }
}
