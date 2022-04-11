using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherTryItWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Weather.ServiceClient weather = new Weather.ServiceClient();

            string loaction = TextBox1.Text + "," + TextBox2.Text;

            string[] forecast = weather.GetWeather(loaction);

            Label1.Text = forecast[0];
            Label2.Text = forecast[1];
            Label3.Text = forecast[2];
            Label4.Text = forecast[3];
            Label5.Text = forecast[4];
            Label6.Text = forecast[5];
            Label7.Text = forecast[6];
        }
    }
}