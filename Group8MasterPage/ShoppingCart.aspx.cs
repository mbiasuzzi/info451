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
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public string title3;
        public string isbn3;
        public string price3;
        public string bookID3;
        public string userID3;
        public string sellerEmail3;
        public string buyerEmail3;

        ArrayList CartItems;
        private string _connectionString = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {    
            CartItems = (ArrayList)Session["CartSession"];
            ShoppingCartGrid.DataSource = CartItems;
            ShoppingCartGrid.DataBind();
           // ShoppingCartGrid.Columns[3].Visible = false;
            //ShoppingCartGrid.Columns[5].Visible = false;
            CalculateTotal();         
        }
        public void CalculateTotal()
        {
            double sum = 0;
            for (int i = 0; i<ShoppingCartGrid.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(ShoppingCartGrid.Rows[i].Cells[3].Text);
            }
                numberTotal.Text = sum.ToString();
            
        }

        protected void ShoppingCartGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int selectedR = e.RowIndex;
            CartItems.RemoveAt(selectedR);
            ShoppingCartGrid.DataBind();
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            
            List<int> BookIDs = new List<int>();
            for (int i = 0; i < ShoppingCartGrid.Rows.Count; ++i)
            {
                BookIDs.Add(Convert.ToInt32(ShoppingCartGrid.Rows[i].Cells[4].Text));
            }

            foreach (var bookid in BookIDs)
            {
                
                int bookID = bookid;
                    
                _connectionString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
                SqlConnection con = new SqlConnection(_connectionString);

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@bookid", bookID);
                 
                cmd.CommandText = "SELECT * FROM dbo.Inventory i JOIN dbo.UserInformation u ON i.UserID = u.UserID where i.BookID = @bookid";

                using (con)
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        title3 = (string)reader["Title_of_Book"];
                        isbn3 = Convert.ToString(reader["ISBN"]);
                        price3 = Convert.ToString(reader["Price"]);
                        bookID3 = Convert.ToString(reader["BookID"]);
                        userID3 = Convert.ToString(reader["UserID"]);
                        sellerEmail3 = (string)reader["Email"];
                    }
                }
                _connectionString = ConfigurationManager.ConnectionStrings["info451"].ConnectionString;
                SqlConnection con2 = new SqlConnection(_connectionString);
                SqlCommand cmd2 = new SqlCommand();
                cmd2.Connection = con2;
                cmd2.Parameters.AddWithValue("@email", sellerEmail3 );
                cmd2.Parameters.AddWithValue("@title", title3);
                cmd2.Parameters.AddWithValue("@isbn", isbn3);
                cmd2.Parameters.AddWithValue("@price", price3);
                cmd2.Parameters.AddWithValue("@bookid", bookID3);

                cmd2.CommandText = "INSERT INTO Orders ( Seller_Email, Title_of_Book, ISBN, Price, BookID) VALUES ( @email, @title, @isbn, @price, @bookid)";

                using (con2)
                {
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                }

            }
        }
    }
}