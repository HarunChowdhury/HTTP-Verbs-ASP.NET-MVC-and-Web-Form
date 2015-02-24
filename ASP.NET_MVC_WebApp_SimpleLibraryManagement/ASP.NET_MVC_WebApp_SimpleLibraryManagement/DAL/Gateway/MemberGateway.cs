using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace ASP.NET_MVC_WebApp_SimpleLibraryManagement.DAL.Gateway
{
    public class MemberGateway:Gateway
    {
        public MemberGateway()
            : base("ConnecString")
        { }
        public bool IsExistsNumber(string number)
        {
            Connection.Close();
            var query="SELECT * FROM WHERE Number='"+number+"'";
            Command.CommandText = query;
            SqlDataReader aReader = Command.ExecuteReader();

            bool hasrows = aReader.HasRows;

            return hasrows;
        }
    }
}