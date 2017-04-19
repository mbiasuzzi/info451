using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Group8MasterPage
{
    public partial class Login_SignUp : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lgnbtn_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (var cmd = new SqlCommand("Select count(*) from UserInformation where UserID = @username and PassWord = @password", con))
                {
                    cmd.Parameters.AddWithValue("@username", UsernameTxt.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTxt.Text);

                    con.Open();
                    var result = (int)cmd.ExecuteScalar();

                    if (result > 0)
                    {
                        using (var cmd2 = new SqlCommand("Select Email From UserInformation Where UserID = @username", con))
                        {
                            cmd2.Parameters.AddWithValue("@username", UsernameTxt.Text);
                            

                            var email = (string)cmd2.ExecuteScalar();

                            Session["Email"] = email;
                        }

                        Session["Username"] = UsernameTxt.Text;
                        Response.Redirect("HomePage-LoggedIn.aspx");
                    }

                }
            }
        }

        protected void sgnupbtn_Click(object sender, EventArgs e)
        {
            Session["Username"] = UsernameTxt.Text;
            Session["Password"] = PasswordTxt.Text;

            Response.Redirect("SignUp-Page.aspx");
        }
    }
}