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
    public partial class DesignationUI : Form
    {
        public DesignationUI()
        {
            InitializeComponent();
        }

       private  Designation aDesignation = new Designation();



       DesignationManager designationManager=new DesignationManager();

       //public Designation GetLastAddedDesignation()
       //{
       //    return aDesignation;
       //}
        private void saveDesignationButton_Click(object sender, EventArgs e)
        {
            

            aDesignation.Code = codeTextBox.Text;
            aDesignation.Title = titleTextBox.Text;

            string message = designationManager.Save(aDesignation);

            MessageBox.Show(message);

            
        }

       private void GetTextBoxesClear() 
       {
           codeTextBox.Text = "";
           titleTextBox.Text = "";
       }




       internal Designation GetLastAddedDesignationThisUI()
       {
           return aDesignation;
       }
    }
}
