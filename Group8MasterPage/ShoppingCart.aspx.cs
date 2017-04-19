using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Text;
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
        private static string buyerEmail3;  
        string UserEmail;
        ArrayList CartItems;
        private string _connectionString = string.Empty;

        public string BuyerEmail3 {
            get {
                return buyerEmail3;
                }
            set {
                buyerEmail3 = value; 
                }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            UserEmail = (string)Session["Email"];
            if (String.IsNullOrEmpty(UserEmail))
            {
                btnPurchase.Visible = false;
                lblNewEmail.Visible = true;
                txtNewEmail.Visible = true;
                btnNewEmail.Visible = true;
                
            }
            else
            {
                BuyerEmail3 = (string)Session["Email"];
                btnPurchase.Enabled = true;
                lblNewEmail.Visible = false;
                txtNewEmail.Visible = false;
                btnNewEmail.Visible = false;

            }
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
                cmd2.Parameters.AddWithValue("@sellerEmail", sellerEmail3 );
                cmd2.Parameters.AddWithValue("@title", title3);
                cmd2.Parameters.AddWithValue("@isbn", isbn3);
                cmd2.Parameters.AddWithValue("@price", price3);
                cmd2.Parameters.AddWithValue("@bookid", bookID3);
                cmd2.Parameters.AddWithValue("@buyerEmail", BuyerEmail3);

                cmd2.CommandText = "INSERT INTO Orders ( Seller_Email, Title_of_Book, ISBN, Price, BookID, Buyer_Email) VALUES ( @sellerEmail, @title, @isbn, @price, @bookid, @buyerEmail)";

                using (con2)
                {
                    con2.Open();
                    cmd2.ExecuteNonQuery();
                }
               // SendEmail();
                
    }
        }
        public void SendEmail()
        {
            MailMessage mailMessage = new MailMessage();
            MailAddress fromAddress = new MailAddress("mbiasuzzi@gmail.com");
            mailMessage.From = fromAddress;
            mailMessage.To.Add("mbiasuzzi@gmail.com");
            mailMessage.Body = "This is Testing Email Without Configured SMTP Server";
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = " Testing Email";
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "localhost";
            smtpClient.Send(mailMessage);
        }

        protected void btnNewEmail_Click(object sender, EventArgs e)
        {
            BuyerEmail3 = txtNewEmail.Text;
            if (!string.IsNullOrEmpty(buyerEmail3))
            {
                btnPurchase.Visible = true;
            }
        }

    }
}