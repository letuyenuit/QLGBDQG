using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGiaiBongDa.Utils
{
    public class Helpers
    {
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.
                    ConnectionStrings["QLGiaiBongDa"].ConnectionString;
        }

        public static bool IsValidRow(DataGridViewRow r)
        {
            if (r == null || r.IsNewRow)
                return false;

            return true;
        }

    }
}
