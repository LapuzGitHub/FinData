using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinDataForm
{
	static class Helper
	{
		private static readonly DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		public static DateTime ToDateTime(long epochTime)
		{
			return epoch.AddSeconds(epochTime);
		}
		public static long ToEpochTime(DateTime dateTime)
		{
			TimeSpan timeSpan = dateTime - new DateTime(1970, 1, 1);
			long secondsSinceEpoch = (long)timeSpan.TotalSeconds;
			return secondsSinceEpoch;
		}
		public static string FitString(string str)
		{
			return string.IsNullOrWhiteSpace(str) ? string.Empty : str.Trim().ToUpper();
		}
		static public double? Mean(double[] values)
		{
			if (values == null) return null;

			return values.Average();
		}
		static public double? Variance(double[] values)
		{
			if (values == null) return null;
			if (values.Length < 2) return 0.0;

			var mean = Mean(values);
			return values.Sum(x => Math.Pow(x - mean.Value, 2.0));
		}
		static public double? StandardDeviation(double[] values)
		{
			if (values == null) return null;
			if (values.Length < 2) return 0.0;

			return Math.Sqrt(Variance(values).Value);
		}
		static public double? Covariance(double[] values1, double[] values2)
		{
			if (values1 == null || values2 == null || values1.Length != values2.Length) return null;
			if (values1.Length < 2) return 0.0;

			var mean1 = Mean(values1);
			var mean2 = Mean(values2);

			return values1.Zip(values2, (x, y) => (x - mean1) * (y - mean2)).Sum();
		}
		static public double? Correlation(double[] values1, double[] values2)
		{
			if (values1 == null || values2 == null || values1.Length != values2.Length) return null;
			if (values1.Length < 2) return 0.0;

			return Covariance(values1, values2) / (StandardDeviation(values1) * StandardDeviation(values2));
		}
		static public double? Error(double[] values1, double[] values2)
		{
			int length;
			if (values1 == null || values2 == null || (length = values1.Length) != values2.Length) return null;

			double error = 0.0;
			for (int i = 0; i < length; i++)
			{
				error += Math.Pow(values1[i] - values2[i], 2.0);
			}

			return Math.Sqrt(error);
		}
	}
}