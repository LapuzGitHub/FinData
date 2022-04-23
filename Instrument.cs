using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinDataForm
{
	public enum InstrumentType
	{ 
		INDEX,
		EQUITY,
		CURRENCY_PAIR,
		UNKNOWN
	}
	public class Instrument
	{
		public const int INDEX_QUOTE_DIGITS = 2;
		public const int EQUITY_QUOTE_DIGITS = 2;
		public const int CURRENCY_PAIR_QUOTE_DIGITS = 4;

		private string symbol;
		public InstrumentType Type { get; set; }

		private HistoricalDataSet historicalDataSet = null;
		public Instrument(string s, ProfileData profileData)
		{
			symbol = Helper.FitString(s);
			Type = InstrumentType.UNKNOWN;
			historicalDataSet = new HistoricalDataSet();
			SetProfileData(profileData);
		}
		private void SetProfileData(ProfileData profileData)
		{
			bool noData = (profileData == null || profileData.QuoteTypeNode == null);
			historicalDataSet.LongName = (noData ? string.Empty : profileData.QuoteTypeNode.LongName);

			string instrumentType = noData ? string.Empty : profileData.QuoteTypeNode.QuoteType;
			int digitNumber;
			switch (instrumentType)
			{
				case "EQUITY":
					digitNumber = EQUITY_QUOTE_DIGITS;
					break;
				default:
					if (symbol.StartsWith("^"))
						digitNumber = INDEX_QUOTE_DIGITS;
					else if (symbol.EndsWith("=X"))
						digitNumber = CURRENCY_PAIR_QUOTE_DIGITS;
					else
						digitNumber = EQUITY_QUOTE_DIGITS;
					break;
			}

			historicalDataSet.DigitNumber = digitNumber;
		}
		public void SetHistoricalData(QuoteList quoteList)
		{
			historicalDataSet.Set(quoteList);
		}
		public HistoricalDataSet GetHistoricalData()
		{
			return historicalDataSet;
		}
	}
}