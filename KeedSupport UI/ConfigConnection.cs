using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace KeedSupport_UI
{
    public static class ConfigConnection
    {
        public static string connectionString =
        ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
    }
}
