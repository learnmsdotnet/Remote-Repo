using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetDatabaseInformation_Click(object sender, EventArgs e)
    {
        string studentInformation = string.Empty;

        //retrieving the student information database and assigning to the variable
        DatabaseLayer.RetrieveRecord retrieveRecord = new DatabaseLayer.RetrieveRecord();
        //txtStudentInformation.Text = retrieveRecord.RetrieveRecordSelect();
        studentInformation = retrieveRecord.RetrieveRecordSelect();

        txtStudentInformation.Text = studentInformation;
    }
}