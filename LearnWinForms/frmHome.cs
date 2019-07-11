using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnWinForms
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When user clicks the button we need to populate the textbox in the form with 
        ///     student details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetDatabaseInformation_Click(object sender, EventArgs e)
        {
            string studentInformation = string.Empty;

            //retrieving the student information database and assigning to the variable
            DatabaseLayer.RetrieveRecord retrieveRecord = new DatabaseLayer.RetrieveRecord();
            //txtStudentInformation.Text = retrieveRecord.RetrieveRecordSelect();
            studentInformation = retrieveRecord.RetrieveRecordSelect();

            txtStudentInformation.Text = studentInformation;
        }
    }
}
