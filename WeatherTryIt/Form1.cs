using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherTryIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WeatherWS.ServiceClient weather = new WeatherWS.ServiceClient();

            string loaction = textBox1.Text + "," + textBox2.Text;

            string[] forecast = weather.GetWeather(loaction);

            string strForecast = "";

            for(int i = 0; i < forecast.Length; i++)
            {
                strForecast = strForecast + forecast[i].ToString();
                strForecast = strForecast + "\n";
            }

            richTextBox1.Text = strForecast;

        }
    }
}
