using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace ASP.NET_MVC_WebApp_SimpleLibraryManagement.DAL.Gateway
{
    public class Gateway
    {
        public SqlConnection Connection { get; set; }
        public SqlCommand Command { get; set; }

        public Gateway(string conn)
        {
            Connection = new SqlConnection(WebConfigurationManager.ConnectionStrings[conn].ConnectionString);
            Command=new SqlCommand();
            Command.Connection = Connection;
        }
    }
}