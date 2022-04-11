using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{

	[OperationContract]
	[WebGet(UriTemplate = "/getPrices/{locA}/{locB}/{date}", ResponseFormat = WebMessageFormat.Json)]
	Prices getPrices(string locA, string locB, string date);

	// TODO: Add your service operations here
}

[DataContract]
public class Prices
{
	

	double highest;
	double lowest;
	double average;
	string locationA;
	string locationB;
	double[] allPrices;

	[DataMember]
	public double Highest
	{
		get { return highest; }
		set { highest = value; }
	}	

	[DataMember]
	public double Lowest
	{
		get { return lowest; }
		set { lowest = value; }
	}
	
	[DataMember]
	public double Average
	{
		get { return average; }
		set { average = value; }
	}
	
	[DataMember]
	public string LocationA
	{
		get { return locationA; }
		set { locationA = value; }
	}
	
	[DataMember]
	public string LocationB
	{
		get { return locationB; }
		set { locationB = value; }
	}
	
	[DataMember]
	public double[] AllPrices
	{
		get { return allPrices; }
		set { allPrices = value; }
	}


}