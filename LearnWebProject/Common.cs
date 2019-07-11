using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace LearnWebProject
{
    static class Common
    {
        #region         "Connection String"

        public static string ConnectionString {

            get {
                return ConfigurationManager.ConnectionStrings["ConnectionLearnDBWinAuth"].ConnectionString;
            }
        }

        #endregion

        #region         "Stored Procedures"

        private const string SCHEMA = "dbo.";

        public static readonly string SPROC_SELECT_CUSTOMER = string.Concat(SCHEMA, "SProc_Select_Customer");
        public static readonly string SPROC_INSERT_CUSTOMER = string.Concat(SCHEMA, "SProc_Insert_Customer");
        public static readonly string SPROC_DELETE_CUSTOMER = string.Concat(SCHEMA, "SProc_Delete_Customer");
        public static readonly string SPROC_UPDATE_CUSTOMER = string.Concat(SCHEMA, "SProc_Update_Customer");

        #endregion

        #region         "Constants/Read-Only variables"

        //Name of the database table (dataTable)
        public static string DATA_TABLE_CUSTOMERS = "Customers";

        //Databound Control Name
        public static string LABEL_NAME = "labelName";
        public static string LABEL_COUNTRY = "labelCountry";
        public static string TEXTBOX_NAME = "textBoxName";
        public static string TEXTBOX_COUNTRY = "textBoxCountry";

        #endregion

        #region         "Application Display Messages"

        public static readonly string MSG_CUSTOMER_DELETE_SUCCESSFUL = "Customer: {0}, is deleted successfully";
        public static readonly string MSG_CUSTOMER_UPDATE_SUCCESSFUL = "Customer information successfully updated";
        public static readonly string MSG_CUSTOMER_INSERT_SUCCESSFUL = "New Customer added successfully";

        #endregion
    }
}