using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group8MasterPage
{
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Addbtn_Click(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Error-Page.aspx");
            }
            else
            {
                Response.Redirect("Add-Listing.aspx");
            }
        }

        protected void Delbtn_Click(object sender, EventArgs e)
        {
            if (Session["Username"] == null)
            {
                Response.Redirect("Error-Page.aspx");
            }
            else
            {
                Response.Redirect("Delete-Listing.aspx");
            }
        }

    }
}