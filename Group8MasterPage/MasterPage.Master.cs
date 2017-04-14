﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Group8MasterPage
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Username"] != null)
            {
                hmbtn.Text = (string)Session["Username"];
            }
        }

        protected void hmbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login-SignUp.aspx");
        }
    }
}