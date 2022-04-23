using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinDataForm
{
	public class HistoricalDataSet
	{
		public string LongName { get; set; }
		public int DigitNumber { get; set; }

		private Dictionary<DateTime, double> historicalData;

		private readonly int DEFAULT_DIGIT_NUMBER = 2;
		public HistoricalDataSet(Dictionary<DateTime, double> historicalData = null)
		{
			this.historicalData = historicalData ?? new Dictionary<DateTime, double>();
			DigitNumber = DEFAULT_DIGIT_NUMBER;
		}
		public List<DateTime> Dates()
		{
			var list = historicalData.Keys.ToList();
			list.Sort();
			return list;
		}
		public double Value(DateTime date)
		{
			return historicalData[date];
		}
		public string FormattedValue(DateTime date)
		{
			return String.Format(String.Concat("{0:F", DigitNumber, "}"), Value(date)); 
		}
		public void Set(QuoteList quoteList)
		{
			if (quoteList == null || quoteList.Quotes == null) return;
			historicalData = (new List<Quote>(quoteList.Quotes)).ToDictionary(q => Helper.ToDateTime(q.Date).Date, q => Math.Round(q.Close, DigitNumber));
		}
		public bool IsEmpty()
		{
			return historicalData == null || historicalData.Values == null || historicalData.Values.Count() == 0;
		}
		public double? GetCorrelation(HistoricalDataSet other)
		{
			if (IsEmpty() || other.IsEmpty()) return null;

			try
			{
				return (new StatisticalDataSeries(this, other)).Correlation();
			}
			catch
			{
				return null;
			}
		}
		public double? GetMovingAverage(DateTime endDate, int dayNumber)
		{
			if (IsEmpty() || dayNumber <= 0) return null;

			try
			{
				var dates = Dates();
				int startDateIndex, endDateIndex;
				if ((endDateIndex = dates.IndexOf(endDate)) < 0 || (startDateIndex = endDateIndex - dayNumber + 1) < 0) return null;
				
				var dateSubset = historicalData.Keys.Where(d => d >= dates[startDateIndex] && d <= endDate);
				double average = 0.0;
				foreach (DateTime d in dateSubset)
				{
					average += historicalData[d];
				}
				return average / dayNumber;
			}
			catch
			{ 
			}

			return null;
		}
	}
}