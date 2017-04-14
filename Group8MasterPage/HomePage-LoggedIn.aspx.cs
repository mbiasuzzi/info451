using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Group8MasterPage
{
    public partial class HomePage_LoggedIn : System.Web.UI.Page
    {
        string bookID;
        private string ConString = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            DataTable table = new DataTable();
            string ConString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                string CmdString = "Select BookID, Title_of_Book, ISBN, Picture, Description FROM Inventory";
                using (SqlCommand cmd = new SqlCommand(CmdString, con))
                {
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        ad.Fill(table);
                    }
                }
            }
            Repeater1.DataSource = table;
            Repeater1.DataBind();
        }

        public void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            bookID = e.CommandArgument.ToString();
            Response.Redirect("BookDetails.aspx?id=" + bookID, true);
        }
    }
}