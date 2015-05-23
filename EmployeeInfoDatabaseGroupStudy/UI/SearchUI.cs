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
        EmployeeManager manager=new EmployeeManager();
        public SearchUI()
        {
            InitializeComponent();
        }

        private void SearchUI_Load(object sender, EventArgs e)
        {
            LoadAllEmployeeListView(manager.GetAllEmployees());
        }

        public void LoadAllEmployeeListView(List<Employee> employees)
        {
            int serial = 1;
            foreach (var employee in employees)
            {
                resultListView.Items.Clear();
                ListViewItem item = new ListViewItem(serial.ToString());
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(employee.Email);
                resultListView.Items.Add(item);
                serial++;

            }
            
        }
    }
}
