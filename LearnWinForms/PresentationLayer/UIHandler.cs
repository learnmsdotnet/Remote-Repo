using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnWinForms.PresentationLayer
{
    static class UIHandler
    {
        public static void ClearControl(TextBox textboxProductName, TextBox textboxCost,
            DateTimePicker datetimepickerMfgDate)
        {
            textboxProductName.Clear();
            textboxCost.Clear();

            datetimepickerMfgDate.Format = DateTimePickerFormat.Custom;
            datetimepickerMfgDate.CustomFormat = " ";
        }

        public static string ValidateControls(TextBox textboxProductName, TextBox textboxCost,
            DateTimePicker datetimepickerMfgDate)
        {
            if (string.IsNullOrEmpty(textboxProductName.Text.Trim()))
                return "Please enter a Product Name";
            else if (string.IsNullOrEmpty(textboxCost.Text.Trim()))
                return "Please enter the Product Cost";
            else if (string.IsNullOrEmpty(datetimepickerMfgDate.Text.Trim()))
                return "Please enter the Product Mfg Date";
            else
                return null;
        }
    }
}
