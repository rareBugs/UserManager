using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UserManager
{
    // This is a manager to keep track of open windows
    // Everytime a new window opens, this manager adds it to a list
    // This list makes it possible to close all windows with the click of a button
    // which is "Exit program" button added on all windows except the login window.

    public class OpenWindowsManager
    {
        private static List<Form> openForms = new List<Form>();

        public static void AddForm(Form form)
        {
            openForms.Add(form);
        }

        public static void CloseAllForms()
        {
            foreach (var form in openForms)
            {
                form.Close();
            }
        }
    }
}
