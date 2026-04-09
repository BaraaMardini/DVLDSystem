using System;
using System.Configuration;

namespace ConnectionName
{
    public static class Connection
    {
        public static string ConnectionString
        {
            get
            {
                var cs = ConfigurationManager.ConnectionStrings["DefaultConnection"];
                if (cs == null)
                    throw new Exception("Connection string 'DefaultConnection' not found in App.config");
                return cs.ConnectionString;
            }
        }
    }
}