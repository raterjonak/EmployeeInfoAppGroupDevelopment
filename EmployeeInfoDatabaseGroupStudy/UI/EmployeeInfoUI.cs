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

namespace EmployeeInfoDatabaseGroupStudy
{
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }

        DesignationManager designationManager=new DesignationManager();
        private void employeeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void addDesignatioButton_Click(object sender, EventArgs e)
        {
            DesignationUI designationUi = new DesignationUI();
            designationUi.Show();
        }

        //private void EmployeeInfoUI_Load(object sender, EventArgs e)
        //{
        //    designationComboBox=(ComboBox)
        //}

        public void LoadAllDesignation()
        {
            designationComboBox.DataSource = designationManager.GetAllDesignations();
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "Id";
        }

    }
}
