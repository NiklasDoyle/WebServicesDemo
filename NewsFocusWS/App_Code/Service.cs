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
//using System.Net.Http;
using Newtonsoft.Json;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string[] GetURLs(string location)
	{
		string[] urls = new string[10];
        
        //if location is not successfull passed through
        if (location == null || location == "")
        {
            string[] st = {"No Country Reveived"};
            return st;
        }
        //make sure that there is no spaces in url
        string newCountry = "";
        char[] topicChar = location.ToCharArray(); 
        for(int i = 0; i < topicChar.Length; i++)
        {
            if(topicChar[i] != ' ')
                newCountry += topicChar[i];
        }

		string url = @"https://newsapi.org/v2/everything?q=" + newCountry + "&sortBy=relevancy&apiKey=/*INSERT KEY*/";

		HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
		WebResponse response = request.GetResponse();
		Stream dataStream = response.GetResponseStream();
		StreamReader sreader = new StreamReader(dataStream);
		string responsereader = sreader.ReadToEnd();
		response.Close();



          RootObject newsObject = JsonConvert.DeserializeObject<RootObject>(responsereader);

        Console.WriteLine("Today's Articles from: " + newsObject.source);

        Article temp;
        for (int i = 0; i < 10 && i<newsObject.articles.Count; i++)
        {
            temp = newsObject.articles[i];
            urls[i] = temp.url;
        }

        return urls;
	}

    public class Article
    {
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public string publishedAt { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public string source { get; set; }
        public string sortBy { get; set; }
        public List<Article> articles { get; set; }

    }

}
