using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group8MasterPage
{
    public partial class BookDetails : System.Web.UI.Page
    {
        private string _connectionString = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            QueryBookDetails();
        }
        public void QueryBookDetails()
        {
            string bookID = Request.QueryString["id"];
            _connectionString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@id",bookID);
            cmd.CommandText = "SELECT * FROM dbo.Inventory where BookID = @id";

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TitleBook.Text = (string)reader["Title_of_Book"];
                    DescBook.Text = (string)reader["Description"];
                    Image1.ImageUrl = (string)reader["Picture"];
                    Isbn.Text = Convert.ToString(reader["ISBN"]);
                    Author.Text = (string)reader["Author"];
                    BookVersion.Text = (string)reader["Version"];
                    Condition.Text = (string)reader["Condition"];
                    Price.Text = Convert.ToString(reader["Price"]);

                }
            }

        }
    }
}