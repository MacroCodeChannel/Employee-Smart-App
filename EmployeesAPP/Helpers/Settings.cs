using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.Helpers
{
    public class Settings
    {

        private static Settings settings;

        public static Settings Current 
        {
            get
            {
                return settings ??(settings = new Settings());
            }
        }

        public static bool IsLoggedIn
        {
            get
            {
                return Preferences.Default.Get("IsLoggedIn", false);
            }
            set
            {
                Preferences.Default.Set("IsLoggedIn", value);
            }
        }
    }
}
