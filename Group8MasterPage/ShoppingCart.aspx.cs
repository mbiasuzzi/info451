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
            if (!IsPostBack)
            {
                CartItems = (ArrayList)Session["CartSession"];
                ShoppingCartGrid.DataSource = CartItems;
                ShoppingCartGrid.DataBind();
            }
            else
            {
               
                ShoppingCartGrid.DataSource = CartItems;
                ShoppingCartGrid.DataBind();
            }
                
        }
    }
}