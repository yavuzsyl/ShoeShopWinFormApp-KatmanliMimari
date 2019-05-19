using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public static class FormHelper
    {
        public static Form GenerateForm(Type type)
        {
            Form form = Application.OpenForms[type.Name];
            if (form == null)
                form =(Form)Activator.CreateInstance(type);
            return form;
        }
    }
}
