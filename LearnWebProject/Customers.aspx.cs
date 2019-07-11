using System;
using System.Web.UI.WebControls;
using System.Data;
using LearnWebProject.DBOperations;

namespace LearnWebProject
{
    public partial class Index : System.Web.UI.Page
    {
        #region         "enums"

        //Ref: https://stackoverflow.com/questions/309333/enum-string-name-from-value
        private enum StatusMessage {
            
            pp_info = 1,
            pp_success,
            pp_warning = 3,
            pp_error = 4
        }

        #endregion

        #region         "Event Handlers"

        //During load of page (Customers.aspx)
        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack)
                this.loadDataGrid();
        }

        //Click of Create Button
        protected void Insert(object sender, EventArgs e) {

            this.onRowCreate();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e) {

            gridViewCustomers.EditIndex = e.NewEditIndex;
            this.loadDataGrid();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e) {

            this.cancelRowEdit();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e) {

            this.onPagingClick(e);
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e) {

            int deleteLinkButtonCellIndex = 2;
            int deleteLinkButtonControlIndex = 2;

            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowIndex != gridViewCustomers.EditIndex)) {
                (e.Row.Cells[deleteLinkButtonCellIndex].Controls[deleteLinkButtonControlIndex] as LinkButton).Attributes["onclick"] 
                    = "return confirm('Do you want to delete this row ?');";
            }
        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e) {

            this.onRowDelete(e.RowIndex);
        }

        protected void OnSelectedIndexChanged(object sender, EventArgs e) {

            this.onSelectedIndex();            
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e) {

            this.onRowUpdate(e.RowIndex);
        }

        #endregion

        #region         "Private Methods"

        private void message(string message, string cssClass) {

            labelMessage.Text = message;
            divMessage.Visible = true;

            //Ref: https://stackoverflow.com/questions/3742010/add-css-class-to-a-div-in-code-behind
            divMessage.Attributes.Add("class", cssClass);

            //update the message updatePanel so that display message will be shown in UI
            //Ref: https://stackoverflow.com/questions/2864692/how-to-update-a-control-outside-of-an-updatepanel
            updatePanelMessage.Update();
        }

        private void onRowCreate() {

            string name = textBoxInputName.Text.Trim();
            string country = textBoxInputCountry.Text.Trim();

            //clear the input controls
            this.clearControls();

            try {
                if (this.putDataCustomer(name, country)) message(Common.MSG_CUSTOMER_INSERT_SUCCESSFUL, nameof(StatusMessage.pp_success));
            }
            catch (Exception e) {
                message(e.ToString(), nameof(StatusMessage.pp_error));                
            }
        }

        private void onRowUpdate(int rowIndex) {

            //Declaration of data
            GridViewRow gridViewRow = gridViewCustomers.Rows[rowIndex];
            int indexCustomerId = 0;
            Model.Customer customer = new Model.Customer();

            //gather information from the updated grid values
            customer.CustomerId = Convert.ToInt32(gridViewCustomers.DataKeys[rowIndex].Values[indexCustomerId]);
            customer.Name = (gridViewRow.FindControl(Common.TEXTBOX_NAME) as TextBox).Text;
            customer.Country = (gridViewRow.FindControl(Common.TEXTBOX_COUNTRY) as TextBox).Text;

            //pass the customer object to databaselayer for dataupdate
            PostDataCustomer postDataCustomer = new PostDataCustomer();
            try {
                if (postDataCustomer.POST(customer)) message(Common.MSG_CUSTOMER_UPDATE_SUCCESSFUL, nameof(StatusMessage.pp_success));
            }
            catch (Exception e) {
                message(e.ToString(), nameof(StatusMessage.pp_error));
            }
            finally {
                //set the gridView back to read form
                gridViewCustomers.EditIndex = -1;

                //reload the datagridCustomers with updated value from the database
                this.loadDataGrid();
            }
        }

        private void onRowDelete(int rowIndex) {

            //get the name of the customer based on the selected row
            //Ref: https://www.codeproject.com/Questions/153020/Gridview-how-to-get-the-selected-row-cell-value
            string name = ((Label)gridViewCustomers.Rows[rowIndex].FindControl(Common.LABEL_NAME)).Text;
            int customerId = Convert.ToInt32(gridViewCustomers.DataKeys[rowIndex].Values[0]);

            DBOperations.DeleteDataCustomer deleteDataCustomer = null;

            try {
                deleteDataCustomer = new DBOperations.DeleteDataCustomer();
                //return null, where there are no errors
                if (deleteDataCustomer.Delete(customerId) == null) message(string.Format(Common.MSG_CUSTOMER_DELETE_SUCCESSFUL, name), nameof(StatusMessage.pp_success));
            }
            catch (Exception e) {
                message(e.ToString(), nameof(StatusMessage.pp_error));
            }
            finally {
                deleteDataCustomer = null;               

                //reload the datagridCustomers with updated value from the database
                this.loadDataGrid();
            }
        }

        private void onSelectedIndex() {

            //Ref: https://www.aspsnippets.com/Articles/How-to-get-Selected-Row-cell-value-from-GridView-in-ASPNet.aspx
            //Accessing BoundField Column
            //string name = gridViewCustomers.SelectedRow.Cells[0].Text;

            //Accessing TemplateField Column controls
            string name = (gridViewCustomers.SelectedRow.FindControl(Common.LABEL_NAME) as Label).Text;
            string country = (gridViewCustomers.SelectedRow.FindControl(Common.LABEL_COUNTRY) as Label).Text;
        }

        private void onPagingClick(GridViewPageEventArgs e) {

            gridViewCustomers.PageIndex = e.NewPageIndex;
            this.loadDataGrid();
        }

        private void cancelRowEdit() {

            gridViewCustomers.EditIndex = -1;
            this.loadDataGrid();
        }

        private bool putDataCustomer(string name, string country) {

            try {

                PutDataCustomer putDataCustomers = new PutDataCustomer();
                putDataCustomers.Put(name, country);

                //reload the grid with data from database to reflect recent updates
                this.loadDataGrid();

                return true;
            }
            catch (Exception e) {
                throw e;
            }
        }

        private void clearControls() {
            textBoxInputName.Text = "";
            textBoxInputCountry.Text = "";
        }

        private void loadDataGrid() {

            DataSet dataSet = null;
            DBOperations.GetDataCustomer getDataCustomers = new DBOperations.GetDataCustomer();

            try {
                dataSet = getDataCustomers.Get();

                gridViewCustomers.DataSource = dataSet.Tables[Common.DATA_TABLE_CUSTOMERS];
                gridViewCustomers.DataBind();
            }
            catch (Exception e) {
                message(e.ToString(), nameof(StatusMessage.pp_error));
            }            
        }

        #endregion
    }
}