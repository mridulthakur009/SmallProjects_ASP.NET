﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class DisplayDateTime : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTimeDisplay.Text = DateTime.Now.ToString();
        }
    }
}