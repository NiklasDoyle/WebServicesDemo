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
    public partial class FlightPrices : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string locationURL = @"http://webstrar22.fulton.asu.edu/page7/Service.svc/getPrices/" + TextBox1.Text + "/" + TextBox2.Text + "/" + TextBox3.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationURL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();


            Console.WriteLine(responsereader);
            RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(responsereader);

            Label1.Text = "$" + rootObj.highest;
            Label2.Text = "$" + rootObj.lowest;
            Label3.Text = "$" + rootObj.average;
            string allPriceList = "";
            for (int i = 0; i < rootObj.allPrices.Count(); i++)
            {
                allPriceList += "$" + rootObj.allPrices[i] + ", ";
                if ((i + 1) % 10 == 0)
                    allPriceList += "\n";
            }

            TextBox4.Text = allPriceList;
        }

        public class RootObject
        {
            public double highest { get; set; }
            public double lowest { get; set; }
            public double average { get; set; }
            public string locationA { get; set; }
            public string locationB { get; set; }
            public double[] allPrices { get; set; }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");

        }
    }
}