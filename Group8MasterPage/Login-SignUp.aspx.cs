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
        private string username;
        private string password;

        public string Username 
        {
           get
            {
                return username;
            } 
        }

        public string Password
        {
            get
            {
                return password;
            }
        }

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

                    }

                }
            }
        }

        protected void sgnupbtn_Click(object sender, EventArgs e)
        {
            username = UsernameTxt.Text;
            password = PasswordTxt.Text;

            Response.Redirect("SignUp-Page.aspx");
        }
    }
}