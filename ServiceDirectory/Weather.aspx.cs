using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
//using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace ServiceDirectory
{
    public partial class Weather : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WeatherWS.ServiceClient weather = new WeatherWS.ServiceClient();

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