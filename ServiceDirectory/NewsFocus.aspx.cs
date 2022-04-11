using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServiceDirectory
{
    public partial class NewsFocus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string country = TextBox1.Text;

            NewsFocusWS.ServiceClient news = new NewsFocusWS.ServiceClient();

            string[] urls = news.GetURLs(country);

            Label1.Text = urls[0];
            Label2.Text = urls[1];
            Label3.Text = urls[2];
            Label4.Text = urls[3];
            Label5.Text = urls[4];
            Label6.Text = urls[5];
            Label7.Text = urls[6];
            Label8.Text = urls[7];
            Label9.Text = urls[8];
            Label10.Text = urls[9];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
    }
}