using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Group8MasterPage
{
    public partial class SignUp_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Username.Text = (string)Session["Username"];
            Password.Text = (string)Session["Password"];
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (var cmd = new SqlCommand("Insert Into UserInformation Values (@username, @password, @email, @phone)", con))
                {
                    cmd.Parameters.AddWithValue("@username", Username.Text);
                    cmd.Parameters.AddWithValue("@password", Password.Text);
                    cmd.Parameters.AddWithValue("@email", Email.Text);
                    cmd.Parameters.AddWithValue("@phone", Phone.Text);

                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();
                }
            }
        }
    }
}