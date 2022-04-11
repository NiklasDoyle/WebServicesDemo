using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string[] GetWeather(string location)
	{
		string[] forecast = new string[7];

        double lat = 33.44;
        double lon = -94.04;

        //make sure that there is no spaces in url
        string newLocation = "";
        char[] locChar = location.ToCharArray();
        for (int i = 0; i < locChar.Length; i++)
        {
            if (locChar[i] != ' ')
                newLocation += locChar[i];
        }

        
        string locationURL = @"http://api.positionstack.com/v1/forward?query="+newLocation+"&country=US&access_key=56068d8de5550f1589c9390d1557d757";

        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationURL);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader sreader = new StreamReader(dataStream);
        string responsereader = sreader.ReadToEnd();
        response.Close();

        GeoRootObject geo = JsonConvert.DeserializeObject<GeoRootObject>(responsereader);

        lat = geo.data[0].latitude;
        lon = geo.data[0].longitude;

        string url = @"https://api.openweathermap.org/data/2.5/onecall?lat="+lat+"&lon="+lon+ "&exclude=current,minutely,hourly,alerts&units=imperial&appid=bf367b024931bd5aa85978e08697708c";

         request = (HttpWebRequest)WebRequest.Create(url);
         response = request.GetResponse();
         dataStream = response.GetResponseStream();
         sreader = new StreamReader(dataStream);
         responsereader = sreader.ReadToEnd();
        response.Close();

        RootObject weatherObject = JsonConvert.DeserializeObject<RootObject>(responsereader);

        Daily day;
        for(int i = 0; i < forecast.Length; i++)
        {
            day = weatherObject.daily[i];
            forecast[i] = "During the day it will be " + day.temp.day.ToString() + " degrees Fahrenheit with " + day.weather[0].main;
        }

        return forecast;
	}

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class FeelsLike
    {
        public double morn { get; set; }
        public double day { get; set; }
        public double eve { get; set; }
        public double night { get; set; }
    }

    public class Temp
    {
        public double morn { get; set; }
        public double day { get; set; }
        public double eve { get; set; }
        public double night { get; set; }
        public double min { get; set; }
        public double max { get; set; }

    }

    public class Daily
    {
        public long dt { get; set; }
        public long sunrise { get; set; }
        public long sunset { get; set; }
        public long moonrise { get; set; }
        public long moonset { get; set; }
        public double moon_phase { get; set; }
        public Temp temp { get; set; }
        public FeelsLike feels_like { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public double dew_point { get; set; }
        public double wind_speed { get; set; }
        public string wind_gust { get; set; }
        public string wind_deg { get; set; }
        public string clouds { get; set; }
        public string uvi { get; set; }
        public string pop { get; set; }
        public string rain { get; set; }
        public string snow { get; set; }
        public List<Weather> weather { get; set; }

    }

    public class RootObject
    {
        public double lat { get; set; }
        public double lon { get; set; }
        public string timezone { get; set; }
        public long timezone_offset { get; set; }
        public List<Daily> daily { get; set; }

    }

    public class Data
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string label { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string number { get; set; }
        public string street { get; set; }
        public string postal_code { get; set; }
        public double confidence { get; set; }
        public string region { get; set; }
        public string region_code { get; set; }
        public string administrative_area { get; set; }
        public string neighbourhood { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
        public string map_url { get; set; }

    }

    public class GeoRootObject
    {
        public List<Data> data { get; set; }

    }

}