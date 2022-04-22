using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace FinDataForm
{
	public class ProfileData
	{
		[JsonPropertyName("quoteType")]
		public QuoteType QuoteType { get; set; }
	}
	public class QuoteType
	{
		[JsonPropertyName("longName")]
		public string LongName { get; set; }
	}
}
