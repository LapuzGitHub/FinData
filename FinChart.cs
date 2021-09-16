using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace FinDataForm
{
	class FinChart
	{
		private Charting.Chart chart;
		private Charting.ChartArea chartArea;
		private Dictionary<int, Charting.Series> chartSeries = new Dictionary<int, Charting.Series>();
		public FinChart(Charting.Chart chart)
		{
			this.chart = chart;
			chartArea = chart.ChartAreas[0];
			chart.Series.Clear();
		}
		public Font Font { set { chartArea.AxisX.LabelStyle.Font = chartArea.AxisY.LabelStyle.Font = value; } }
		public Charting.DateTimeIntervalType AxisXIntervalType { set { chartArea.AxisX.IntervalType = value; } }
		public string AxisXLabelStyle { set { chartArea.AxisX.LabelStyle.Format = value; } }
		public void Clear()
		{
			foreach (var index in chartSeries.Keys)
			{
				var series = chartSeries[index];
				if (series == null || series.Points == null) continue;
				series.Points.Clear();
			}
		}
		public void AddSeries(int index, Charting.Series series)
		{
			series.IsVisibleInLegend = series.IsXValueIndexed = false;
			chartSeries[index] = series;
			chart.Series.Add(series);
		}
		public void AddPoint(int index, double X, double Y)
		{
			if (!chartSeries.ContainsKey(index)) return;
			var series = chartSeries[index];
			if (series == null || series.Points == null) return;
			series.Points.Add(new Charting.DataPoint(X, Y));
		}
	}
}