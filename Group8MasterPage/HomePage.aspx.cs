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
    public partial class HomePage : System.Web.UI.Page
    {
        string bookTitle;
        string bookDesc;
        string bookPicPath;
        string book1ID;
        string book2ID;
        string book3ID;
        private string _connectionString = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            QueryTopFeatured();
            QuerySecondFeatured();
            QueryThirdFeatured();
        }

        public void QueryTopFeatured()
        {

           _connectionString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT TOP 1 * FROM dbo.Inventory order by Quantity desc";

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookTitle = (string)reader["Title_of_Book"];
                    bookDesc = (string)reader["Description"];
                    bookPicPath = (string)reader["Picture"];
                    book1ID = Convert.ToString(reader["BookID"]);
                }
            }

            TitleBook1.Text = bookTitle;
            DescBook1.Text = bookDesc;
            Image1.ImageUrl = bookPicPath;

        }

        public void QuerySecondFeatured()
        {

            _connectionString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT *FROM dbo.Inventory Inv1 WHERE(2 - 1) = (SELECT COUNT(DISTINCT(Inv2.Quantity)) FROM dbo.Inventory Inv2 WHERE Inv2.Quantity > Inv1.Quantity)";

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookTitle = (string)reader["Title_of_Book"];
                    bookDesc = (string)reader["Description"];
                    bookPicPath = (string)reader["Picture"];
                    book2ID = Convert.ToString(reader["BookID"]);
                }
            }

            TitleBook2.Text = bookTitle;
            DescBook2.Text = bookDesc;
            Image2.ImageUrl = bookPicPath;

        }

        public void QueryThirdFeatured()
        {

            _connectionString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
            SqlConnection con = new SqlConnection(_connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT *FROM dbo.Inventory Inv1 WHERE(3 - 1) = (SELECT COUNT(DISTINCT(Inv2.Quantity))FROM dbo.Inventory Inv2 WHERE Inv2.Quantity > Inv1.Quantity)";

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookTitle = (string)reader["Title_of_Book"];
                    bookDesc = (string)reader["Description"];
                    bookPicPath = (string)reader["Picture"];
                    book3ID = Convert.ToString(reader["BookID"]);
                }
            }

            TitleBook3.Text = bookTitle;
            DescBook3.Text = bookDesc;
            Image3.ImageUrl = bookPicPath;

        }

        protected void MoreInfo1_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookDetails.aspx?id=" + book1ID, true);
        }
    }
}