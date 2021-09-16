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
	class FinNewsRetrieval
	{
		private const string URL_ROOT = "https://apidojo-yahoo-finance-v1.p.rapidapi.com/stock/v2/get-insights?symbol={0}";
		private const string URL_KEY = "47d8468cf0msh96b01986208e4b6p17fbf3jsnead6aacd5743";
		private const string URL_HOST = "apidojo-yahoo-finance-v1.p.rapidapi.com";

		private Instrument instrument;
		private string symbol;
		public FinNewsRetrieval(string symbol)
		{
			this.symbol = symbol;
			instrument = new Instrument(symbol);
		}
		private IRestClient GetClient()
		{
			string restURL = string.Format(URL_ROOT, symbol);
			return new RestClient(restURL);
		}
		private IRestRequest GetRequest()
		{
			var request = new RestRequest(Method.GET);
			request.AddHeader("x-rapidapi-key", URL_KEY);
			request.AddHeader("x-rapidapi-host", URL_HOST);
			return request;
		}
		private IRestResponse ExecuteRequest()
		{
			var client = GetClient();
			if (client == null) return null;

			var request = GetRequest();

			IRestResponse response = client.Execute(request);
			return response;
		}
		public HistoricalDataSet GetData()
		{
			if (instrument == null) return null;

			var response = ExecuteRequest();
			if (response == null) return null;

			var quoteList = JsonSerializer.Deserialize<QuoteList>(response.Content);

			return null;
			//instrument.SetHistoricalData(quoteList);
			//return instrument.GetHistoricalData();
		}
	}
}