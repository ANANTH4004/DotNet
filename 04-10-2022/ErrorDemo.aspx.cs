using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class ErrorDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Error(object sender, EventArgs e)
        {
            Exception ex = Server.GetLastError();
               Response.Redirect("~/ErrorPage.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            DataSet ds = new DataSet();
            SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginCnStr"].ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("Select * from IssueTable", sql);
          
            da.Fill(ds, "IssueTable");
        }
    }
}