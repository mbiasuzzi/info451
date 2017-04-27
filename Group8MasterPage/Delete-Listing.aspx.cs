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
    public partial class Delete_Listing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (var cmd = new SqlCommand("Select * from Inventory where UserID = @UserId", con))
                {
                    cmd.Parameters.AddWithValue("@Userid", (string)Session["Username"]);
                    con.Open();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    UserListings.DataSource = dt;
                    UserListings.DataBind();
                    
                }
            }
        }

        protected void UserListings_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
            string ConString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (var cmd = new SqlCommand("Delete from Inventory where Title_of_Book = @Title", con))
                {
                    string title = UserListings.Rows[e.RowIndex].Cells[2].Text;
                    cmd.Parameters.AddWithValue("@Title", title);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    
                    Response.Redirect("MyProfile.aspx");
                }
            }
        }
    }
}