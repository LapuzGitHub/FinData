using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinDataForm
{
	class StatisticalDataSeries
	{
		private class CorrelatedData
		{
			public double First { get; set; }
			public double Second { get; set; }
		}

		private Dictionary<DateTime, CorrelatedData> fullContainer = new Dictionary<DateTime, CorrelatedData>();

		private double[] xValues, yValues;
		public double[] XValues { get { return xValues == null ? null : (double[])xValues.Clone(); } }
		public double[] YValues { get { return yValues == null ? null : (double[])yValues.Clone(); } }
		public StatisticalDataSeries(HistoricalDataSet first, HistoricalDataSet second)
		{
			if (first == null || second == null) return;

			var firstDates = first.Dates();
			var secondDates = second.Dates();
			if (firstDates == null || secondDates == null) return;

			foreach (DateTime date in firstDates)
			{
				if (secondDates.Contains(date))
				{
					AddData(date, first.Value(date), second.Value(date));
				}
			}

			SetXYValues();
		}
		private void AddData(DateTime date, double first, double second)
		{
			if (!fullContainer.ContainsKey(date)) fullContainer[date] = new CorrelatedData() { First = first, Second = second };
		}
		private void SetXYValues()
		{
			xValues = fullContainer.Values.Select(correlatedData => correlatedData.First).ToArray();
			yValues = fullContainer.Values.Select(correlatedData => correlatedData.Second).ToArray();

			Array.Sort(xValues, yValues);
		}
		public double[] GetOLSValues(int order)
		{
			int dotNumber;
			if (order < 1 || xValues == null || yValues == null || (dotNumber = xValues.Length) != yValues.Length) return null;

			Matrix y = new Matrix(yValues);

			Matrix X = new Matrix(dotNumber, order + 1);
			for (int i = 0; i < dotNumber; i++)
			{
				for (int j = 0; j <= order; j++)
				{
					X.Set(Math.Pow(xValues[i], j), i, j);
				}
			}

			Matrix Xt = X.Transpose();

			Matrix a = Xt.Product(X).Inverse().Product(Xt.Product(y));

			double[] olsValues = new double[dotNumber];
			for (int i = 0; i < xValues.Length; i++)
			{
				double xValue = xValues[i], olsValue = 0.0;
				for (int j = 0; j <= order; j++)
				{ 
					olsValue += a.Get(j) * Math.Pow(xValue, j);
				}
				olsValues[i] = olsValue;
			}

			return olsValues;
		}
		public double[] GetOLSValues(int maxOLSOrder, out int order)
		{
			double previousError = 0.0, currentError = 0.0;
			double[] previousOLSValues = null, currentOLSValues = null;
			bool selectPrevious = false;

			for (order = 1; order <= maxOLSOrder; order++)
			{
				previousOLSValues = currentOLSValues;
				currentOLSValues = GetOLSValues(order);

				previousError = currentError;
				var _currentError = Helper.Error(YValues, currentOLSValues);
				if (!_currentError.HasValue)
				{
					selectPrevious = true;
					break;
				}
				currentError = _currentError.Value;

				if (order > 1 && currentError > previousError)
				{
					selectPrevious = true;
					break;
				}
			}

			if (order > maxOLSOrder)
			{
				order = maxOLSOrder;
			}
			else if (selectPrevious)
			{
				order--;
				currentOLSValues = previousOLSValues;
			}

			return currentOLSValues;
		}
		public double? Correlation()
		{
			return Helper.Correlation(xValues, yValues);
		}
	}
}