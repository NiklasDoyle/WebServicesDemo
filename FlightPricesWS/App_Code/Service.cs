using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Net;
using System.IO;
using System.Xml;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public Prices getPrices(string locA, string locB, string date)
    {
        //Date much be in yyyy-mm-dd
        //locations airport codes

        Prices prices = new Prices();

        string locationURL = @"https://skyscanner44.p.rapidapi.com/search-extended?adults=1&origin="+locA+"&destination="+locB+"&departureDate="+date+"&currency=USD";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationURL);
        request.Headers.Add("X-RapidAPI-Host", "skyscanner44.p.rapidapi.com");
        request.Headers.Add("X-RapidAPI-Key", "/*INSERT KEY*/");

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader sreader = new StreamReader(dataStream);
        string responsereader = sreader.ReadToEnd();
        response.Close();

        Console.WriteLine(responsereader);
        RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(responsereader);
        Console.WriteLine(rootObj.itineraries.results[0].pricing_options[0].price.amount);

        int size = rootObj.itineraries.results.Count;
        double[] allPrices = new double[size];

        for(int i = 0; i < size; i++)
        {
            allPrices[i] = rootObj.itineraries.results[i].pricing_options[0].price.amount;
        }

        prices.LocationA = locA;
        prices.LocationB = locB;

        prices.AllPrices = allPrices;
        prices.Highest = allPrices.Max();
        prices.Lowest = allPrices.Min();
        prices.Average = allPrices.Average();

        return prices;
    }
    public class Price
    {
        public double amount { get; set; }
        public string update_status { get; set; }
        public string last_updated { get; set; }
        public int quote_age { get; set; }

    }

    public class Pricing_options
    {
        public Price price { get; set; }
    }

    public class Results
    {
        public string id { get; set; }
        //public List<Legs> legs { get; set; }
        public List<Pricing_options> pricing_options { get; set; }

    }
    public class Itineraries
    {
        public List<Results> results { get; set; }

    }
    public class Context
    {
        public string status { get; set; }
        public string sessionId { get; set; }

    }

    public class RootObject
    {
        public Itineraries itineraries { get; set; }
        public Context context { get; set; }

    }

}
