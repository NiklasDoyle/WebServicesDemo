using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
//using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace FlightPricesTryIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string locationURL = @"http://webstrar22.fulton.asu.edu/page7/Service.svc/getPrices/" + textBox1.Text+ "/" + textBox2.Text + "/" + textBox3.Text;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationURL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();


            Console.WriteLine(responsereader);
            RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(responsereader);

            label8.Text = "Highest Price: $" + rootObj.highest;
            label9.Text = "Lowest Price: $" + rootObj.lowest;
            label10.Text = "Average Price: $" + rootObj.average;
            string allPriceList = "";
            for(int i = 0; i < rootObj.allPrices.Count(); i++)
            {
                allPriceList += "$" + rootObj.allPrices[i] + ", ";
                if ((i + 1) % 10 == 0)
                    allPriceList += "\n";
            }

            label11.Text = "All Prices: " + allPriceList;

        }
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
}
