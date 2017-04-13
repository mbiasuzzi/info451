using System;
using System.Collections;
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
        public string title2;
        public string isbn2;
        public string price2;
        public static ArrayList cartList = new ArrayList();
        private string _connectionString = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            QueryBookDetails();
            if (IsPostBack)
            {
                Session["CartSession"] = cartList;
            }


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
                    title2 = TitleBook.Text;
                    DescBook.Text = (string)reader["Description"];
                    Image1.ImageUrl = (string)reader["Picture"];
                    Isbn.Text = Convert.ToString(reader["ISBN"]);
                    isbn2 = Isbn.Text;
                    Author.Text = (string)reader["Author"];
                    BookVersion.Text = (string)reader["Version"];
                    Condition.Text = (string)reader["Condition"];
                    Price.Text = Convert.ToString(reader["Price"]);
                    price2 = Price.Text;

                }
            }

        }

        protected void BuyBtn_Click(object sender, EventArgs e)
        {          
            cartList.Add(new CartItem(title2, isbn2, price2));
            Session["CartSession"] = cartList;           
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}