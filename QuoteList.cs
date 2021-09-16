using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FinDataForm
{
	public class QuoteList
	{
		[JsonPropertyName("prices")]
		public List<Quote> Quotes { get; set; }
	}
	public class Quote
	{
		[JsonPropertyName("date")]
		public long Date { get; set; }

		[JsonPropertyName("close")]
		public double Close { get; set; }
	}
}
