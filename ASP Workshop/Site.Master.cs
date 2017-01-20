﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Workshop
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Customer"] != null)
            {
                CustomerMenu.Visible = true;
                LogoutOption.Visible = true;
            }
            else
            {
                CustomerMenu.Visible = false;
                LogoutOption.Visible = false;
            }
        }

    }
}