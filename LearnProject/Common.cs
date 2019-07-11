using System.Configuration;

namespace LearnProject
{
    static class Common
    {
        #region         "Connection String"

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionLearnDBWinAuth"].ToString();
            }
        }

        #endregion

        #region         "Stored Procedures"

        public static readonly string SPROC_SELECTPRODUCT = "SProc_SelectProduct";

        #endregion

        #region         "Constants/Read-Only variables"

        //Name of the database table (dataTable)
        public static string DATA_TABLE_PRODUCTS = "Products";

        //Product table columns
        public static string COLUMN_ID = "ID";
        public static string COLUMN_NAME = "Name";
        public static string COLUMN_PRICE = "Price";
        public static string COLUMN_DATE = "Date";

        //Messages for UI display
        public static string APPLICATION_NAME = "ABC Corporation";
        public static string MESSAGE01_PRODUCT_NAME_NOT_EMPTY = "Product name cannot be empty";
        public static string MESSAGE02_PRODUCT_PRICE_NOT_EMPTY = "Product price cannot be empty";
        public static string MESSAGE03_New_ROW_ADDED_SUCCESS = "Data Successfully added to the grid";
        public static string MESSAGE04_DELETE_ROW_CONFIRMATION = "Are you sure you want to delete this row ?";
        public static string MESSAGE05_DATA_SUCCESSFUL_DATABASE = "Data Successfully updated to database. Records updated: {0}";
        public static string MESSAGE06_CONFIRM_FORM_CLOSE = "Are you sure you want to close the form ?";

        #endregion
    }
}
