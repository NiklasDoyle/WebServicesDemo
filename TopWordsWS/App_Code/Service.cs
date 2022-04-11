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
using RestSharp;
//using unirest-net;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string[] GetWords(string url)
	{
		string[] words = new string[10];
        /*
        var client = new RestClient("https://lexper.p.rapidapi.com/v1.1/extract?url=https%3A%2F%2Fmedium.com%2Fpersonal-growth%2Fhow-to-be-yourself-2221085391a3&js=auto&js_timeout=5");
        var request = new RestRequest(Method.GET);
        request.AddHeader("X-RapidAPI-Host", "lexper.p.rapidapi.com");
        request.AddHeader("X-RapidAPI-Key", "cae369fc12mshbb0dcf913fa132cp10e978jsn68b4acdbd1dd");
        IRestResponse response = client.Execute(request);
        */

        string locationURL = @"https://lexper.p.rapidapi.com/v1.1/extract?url=" + url + "&js=auto&js_timeout=5";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(locationURL);
        //request.Method = "GET";
        request.Headers.Add("X-RapidAPI-Host", "lexper.p.rapidapi.com");
        request.Headers.Add("X-RapidAPI-Key", "cae369fc12mshbb0dcf913fa132cp10e978jsn68b4acdbd1dd");

        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader sreader = new StreamReader(dataStream);
        string responsereader = sreader.ReadToEnd();
        response.Close();


        Console.WriteLine(responsereader);
        RootObject rootObj = JsonConvert.DeserializeObject<RootObject>(responsereader);


        words[0] = rootObj.article.text;

        return words;
	}

    public class Article
    {
        public string text { get; set; }
        public string html { get; set; }
        public string media { get; set; }
        public List<string> images { get; set; }
        public string author { get; set; }
        public string pub_date { get; set; }
        public string url { get; set; }
        public string canonical_url { get; set; }
        public string title { get; set; }
        public string language { get; set; }
        public string image { get; set; }
        public string summary { get; set; }
        public string modified_date { get; set; }
        public string site_name { get; set; }
        public string favicon { get; set; }
        public string encoding { get; set; }
    }

    public class RootObject
    {
        public Article article { get; set; }
        public long time { get; set; }

    }


}
