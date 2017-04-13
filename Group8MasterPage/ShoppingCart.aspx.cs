using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group8MasterPage
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        ArrayList CartItems; 

        protected void Page_Load(object sender, EventArgs e)
        {    
            CartItems = (ArrayList)Session["CartSession"];
            ShoppingCartGrid.DataSource = CartItems;
            ShoppingCartGrid.DataBind();
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

    }
}