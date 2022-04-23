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
		public QuoteTypeNode QuoteTypeNode { get; set; }

		[JsonPropertyName("assetProfile")]
		public AssetProfileNode AssetProfileNode { get; set; }
	}
	public class QuoteTypeNode
	{
		[JsonPropertyName("longName")]
		public string LongName { get; set; }

		[JsonPropertyName("quoteType")]
		public string QuoteType { get; set; }
	}
	public class AssetProfileNode
	{
		[JsonPropertyName("sector")]
		public string Sector { get; set; }

		[JsonPropertyName("country")]
		public string Country { get; set; }
	}
}
