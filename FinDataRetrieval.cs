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
		private const string URL_ROOT = "https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-historical-data?symbol={0}&period1={1}&period2={2}&frequency=1d&filter=history";
		private const string URL_KEY = "47d8468cf0msh96b01986208e4b6p17fbf3jsnead6aacd5743";
		private const string URL_HOST = "apidojo-yahoo-finance-v1.p.rapidapi.com";

		private Instrument instrument;
		private string symbol;
		public FinDataRetrieval(string symbol)
		{
			this.symbol = symbol;
			instrument = new Instrument(symbol);
		}
		private IRestClient GetClient(DateTime startDate, DateTime endDate)
		{
			startDate = startDate.Date;
			endDate = endDate.Date;
			DateTime today = DateTime.Today.Date;

			if (startDate >= today || endDate >= today || startDate > endDate) return null;

			DateTime _endDate = (instrument.Type == InstrumentType.STOCK ? endDate.AddDays(1) : endDate);

			string restURL = string.Format(URL_ROOT, symbol, Helper.ToEpochTime(startDate), Helper.ToEpochTime(_endDate));
			return new RestClient(restURL);
		}
		private IRestRequest GetRequest()
		{
			var request = new RestRequest(Method.GET);
			request.AddHeader("x-rapidapi-key", URL_KEY);
			request.AddHeader("x-rapidapi-host", URL_HOST);
			return request;
		}
		private IRestResponse ExecuteRequest(DateTime startDate, DateTime endDate)
		{
			var client = GetClient(startDate, endDate);
			if (client == null) return null;

			var request = GetRequest();

			IRestResponse response = client.Execute(request);
			return response;
		}
		public HistoricalDataSet GetData(DateTime startDate, DateTime endDate)
		{
			if (instrument == null) return null;

			var response = ExecuteRequest(startDate, endDate);
			if (response == null) return null;

			var quoteList = JsonSerializer.Deserialize<QuoteList>(response.Content);
			instrument.SetHistoricalData(quoteList);
			return instrument.GetHistoricalData();
		}
	}
}
