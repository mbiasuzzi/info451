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
    public partial class Add_Listing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subbtn_Click(object sender, EventArgs e)
        {
            string ConString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConString))
            {
                using (var cmd = new SqlCommand("Insert Into Inventory (UserID, Title_of_Book, Description, ISBN, Author, Version, Condition, Price, Status, Quantity, Date_of_Upload) Values (@Userid, @Title, @Description, @Isbn, @Author, @Version, @Condition, @Price, @Status, @Quantity, @Date)", con))
                {
                    cmd.Parameters.AddWithValue("@Userid", (string)Session["Username"]);
                    cmd.Parameters.AddWithValue("@Title", tittxt.Text);
                    cmd.Parameters.AddWithValue("@Description", desctxt.Text);
                    cmd.Parameters.AddWithValue("@Isbn", isbn.Text);
                    cmd.Parameters.AddWithValue("@Author", authtxt.Text);
                    cmd.Parameters.AddWithValue("@Version", vertxt.Text);
                    cmd.Parameters.AddWithValue("@Condition", contxt.Text);
                    cmd.Parameters.AddWithValue("@Price", prctxt.Text);
                    cmd.Parameters.AddWithValue("@Status", "Available");
                    cmd.Parameters.AddWithValue("@Quantity", qtytxt.Text);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    con.Open();
                    cmd.ExecuteScalar();
                    con.Close();

                    Response.Redirect("MyProfile.aspx");
                }
            }
        }
    }
}