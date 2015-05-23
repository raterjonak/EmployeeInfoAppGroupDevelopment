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
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
            LoadAllDesignation();
        }

        DesignationManager designationManager=new DesignationManager();

        private EmployeeManager employeeManager = new EmployeeManager();

        private Designation aDesignation = new Designation();
      


        private void addDesignatioButton_Click(object sender, EventArgs e)
        {
            DesignationUI designationUi = new DesignationUI();
            designationUi.ShowDialog();
            LoadAllDesignation();
            Designation lastAddedDesignation = designationUi.GetLastAddedDesignationThisUI();

            if (lastAddedDesignation != null) 
            {
                designationComboBox.Text = lastAddedDesignation.Title;
            }

        }

        public void LoadAllDesignation()
        {
            designationComboBox.DataSource = designationManager.GetAllDesignations();
            designationComboBox.DisplayMember = "Title";
            designationComboBox.ValueMember = "Id";
        }

        private void EmployeeInfoUI_Load_1(object sender, EventArgs e)
        {

        }

    }
}
