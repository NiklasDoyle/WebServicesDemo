﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceDirectory
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //NewsFocus
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewsFocus.aspx");
        }

        //Weather
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Weather.aspx");

        }

        //Flights
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("FlightPrices.aspx");
        }
    }
}