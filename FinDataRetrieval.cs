using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using RestSharp;

namespace FinDataForm
{
	public class FinDataRetrieval
	{
		private const string URL_ROOT_HISTORICAL = "https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-historical-data?symbol={0}&period1={1}&period2={2}&frequency=1d&filter=history";
		private const string URL_ROOT_PROFILE = "https://yh-finance.p.rapidapi.com/stock/v2/get-profile?symbol={0}";

		private const string URL_KEY = "47d8468cf0msh96b01986208e4b6p17fbf3jsnead6aacd5743";
		private const string URL_HOST = "apidojo-yahoo-finance-v1.p.rapidapi.com";

		private Instrument instrument;
		private string symbol;
		public FinDataRetrieval(string symbol)
		{
			this.symbol = Helper.FitString(symbol);

			var response = ExecuteProfileRequest();
			if (response == null) return;

			ProfileData profileData = null;
			try
			{
				profileData = JsonSerializer.Deserialize<ProfileData>(response.Content);
			}
			catch 
			{
			}

			instrument = new Instrument(symbol, profileData);
		}
		private IRestClient GetHistoricalClient(DateTime startDate, DateTime endDate)
		{
			startDate = startDate.Date;
			endDate = endDate.Date;
			DateTime today = DateTime.Today.Date;

			if (startDate >= today || endDate >= today || startDate > endDate) return null;

			DateTime _endDate = (instrument.Type == InstrumentType.INDEX || instrument.Type == InstrumentType.EQUITY ? endDate.AddDays(1) : endDate);

			string restURL = string.Format(URL_ROOT_HISTORICAL, symbol, Helper.ToEpochTime(startDate), Helper.ToEpochTime(_endDate));
			return new RestClient(restURL);
		}
		private IRestClient GetProfileClient()
		{
			string restURL = string.Format(URL_ROOT_PROFILE, symbol);
			return new RestClient(restURL);
		}
		private IRestRequest GetRequest()
		{
			var request = new RestRequest(Method.GET);
			request.AddHeader("x-rapidapi-key", URL_KEY);
			request.AddHeader("x-rapidapi-host", URL_HOST);
			return request;
		}
		private IRestResponse ExecuteHistoricalRequest(DateTime startDate, DateTime endDate)
		{
			var client = GetHistoricalClient(startDate, endDate);
			if (client == null) return null;

			var request = GetRequest();

			IRestResponse response = client.Execute(request);
			return response;
		}
		private IRestResponse ExecuteProfileRequest()
		{
			var client = GetProfileClient();
			if (client == null) return null;

			var request = GetRequest();

			IRestResponse response = client.Execute(request);
			return response;
		}
		public HistoricalDataSet GetHistoricalData(DateTime startDate, DateTime endDate)
		{
			if (instrument == null) return null;

			var response = ExecuteHistoricalRequest(startDate, endDate);
			if (response == null) return null;

			var deserializedData = JsonSerializer.Deserialize<QuoteList>(response.Content);
			instrument.SetHistoricalData(deserializedData);
			return instrument.GetHistoricalData();
		}
	}
}
