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
		STOCK,
		CURRENCY_PAIR,
		UNKNOWN
	}
	public class Instrument
	{
		public const int STOCK_QUOTE_DIGITS = 2;
		public const int CURRENCY_PAIR_QUOTE_DIGITS = 4;

		private string symbol;
		public InstrumentType Type { get; set; }

		private HistoricalDataSet historicalDataSet = null;
		public Instrument(string s)
		{
			symbol = Helper.FitString(s);

			Type = InstrumentType.UNKNOWN;
			if (!string.IsNullOrWhiteSpace(symbol))
			{
				if (symbol.EndsWith("=X"))
				{
					Type = InstrumentType.CURRENCY_PAIR;
				}
				else
				{
					Type = InstrumentType.STOCK;
				}
			}

			historicalDataSet = new HistoricalDataSet(DigitNumber(Type));
		}
		public static int DigitNumber(InstrumentType instrumentType)
		{
			switch (instrumentType)
			{
				case InstrumentType.CURRENCY_PAIR:
					return CURRENCY_PAIR_QUOTE_DIGITS;
				case InstrumentType.STOCK:
				default:
					return STOCK_QUOTE_DIGITS;
			}
		}
		public void SetHistoricalData(QuoteList quoteList)
		{
			historicalDataSet.Set(quoteList);
		}
		public HistoricalDataSet GetHistoricalData()
		{
			return historicalDataSet.Get();
		}
	}
}