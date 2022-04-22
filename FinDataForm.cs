using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charting = System.Windows.Forms.DataVisualization.Charting;

namespace FinDataForm
{
	public partial class FinDataForm : Form
	{
		enum TimeSeriesChartSeries
		{
			ACTUAL,
			MOVING_AVERAGE
		}
		enum CorrelationChartSeries
		{
			ACTUAL,
			OLS
		}

		private FinChart timeSeriesFinChart, correlationFinChart;

		// To maintain
		private const int STOCK_NUMBER = 5;
		private const string INITIAL_SYMBOL1 = "^DJI";
		private const string INITIAL_SYMBOL2 = "^GSPC";
		private const string INITIAL_SYMBOL3 = "AMZN";
		private const string INITIAL_SYMBOL4 = "^IXIC";
		private const string INITIAL_SYMBOL5 = "TSLA";

		private const int DEFAULT_TIMESPAN = 180;
		private const int DEFAULT_END_PERIOD = 7;

		private const int DEFAULT_MOVING_AVERAGE_DAY_NUMBER = 20;
		private const int DEFAULT_OLS_ORDER = 1;
		private const int MAX_OLS_ORDER = 10;

		private Dictionary<string, HistoricalDataSet> historicalDataSets = new Dictionary<string, HistoricalDataSet>();

		private string timeSeriesSymbol, correlatedSymbolX, correlatedSymbolY;
		public FinDataForm()
		{
			InitializeComponent();

			endDateTimePicker.Value = DateTime.Today.AddDays(-DEFAULT_END_PERIOD);
			startDateTimePicker.Value = endDateTimePicker.Value.AddDays(-DEFAULT_TIMESPAN);

			// To maintain
			string[] initialSymbols = { INITIAL_SYMBOL1, INITIAL_SYMBOL2, INITIAL_SYMBOL3, INITIAL_SYMBOL4, INITIAL_SYMBOL5 };
			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				GetTextBox(i).Text = initialSymbols[i];
			}
			UpdateCombos();

			maTextBox.Text = DEFAULT_MOVING_AVERAGE_DAY_NUMBER.ToString();
			orderTextBox.Text = DEFAULT_OLS_ORDER.ToString();

			correlationMatrix.Enabled = false;
			correlationMatrix.RowCount = correlationMatrix.ColumnCount = STOCK_NUMBER;
			correlationMatrix.Rows[0].Cells[1].Selected = true;
			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				GetLabel(i).Text = string.Empty;
				UpdateStockSymbol(i);

				for (int j = 0; j < STOCK_NUMBER; j++)
				{
					var currentCell = correlationMatrix.Rows[i].Cells[j];
					currentCell.Style.ForeColor = Color.Black;
					if (i == j)
					{
						currentCell.Value = string.Format("{0:0.00}", 1);
						currentCell.Style.BackColor = System.Drawing.SystemColors.Control;
					}
				}
			}

			timeSeriesFinChart = new FinChart(timeSeriesChart) { Font = Font, AxisXIntervalType = Charting.DateTimeIntervalType.Days };
			timeSeriesFinChart.AddSeries((int)TimeSeriesChartSeries.ACTUAL, new Charting.Series()
			{
				ChartType = Charting.SeriesChartType.Line,
				Color = Color.Black,
				YValuesPerPoint = 1,
			});
			timeSeriesFinChart.AddSeries((int)TimeSeriesChartSeries.MOVING_AVERAGE, new Charting.Series()
			{
				ChartType = Charting.SeriesChartType.Line,
				Color = Color.Blue,
				YValuesPerPoint = 1,
			});

			correlationFinChart = new FinChart(correlationChart) { Font = Font, AxisXLabelStyle = "0.00" };
			correlationFinChart.AddSeries((int)CorrelationChartSeries.ACTUAL, new Charting.Series()
			{
				ChartType = Charting.SeriesChartType.Point,
				Color = Color.Black,
				MarkerSize = 3,
				YValuesPerPoint = 32,
			});
			correlationFinChart.AddSeries((int)CorrelationChartSeries.OLS, new Charting.Series()
			{
				ChartType = Charting.SeriesChartType.Line,
				Color = Color.Blue,
				YValuesPerPoint = 32,
			});
		}
		private void UpdateCombos()
		{
			timeSeriesCombo.Items.Clear();
			correlatedComboX.Items.Clear();
			correlatedComboY.Items.Clear();
			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				string symbol = GetTextBox(i).Text;
				timeSeriesCombo.Items.Add(symbol);
				correlatedComboX.Items.Add(symbol);
				correlatedComboY.Items.Add(symbol);
			}
		}
		private void ResetControls() 
		{
			timeSeriesSymbol = correlatedSymbolX = correlatedSymbolY = string.Empty;
			UpdateCombos();
			UpdateTimeSeriesChart();
			UpdateCorrelationChart();
		}
		private void UpdateStockSymbol(int index)
		{
			correlationMatrix.Rows[index].HeaderCell.Value = correlationMatrix.Columns[index].HeaderText = GetTextBox(index).Text;
		}
		// To maintain
		private Button GetUpdateButton(int index)
		{
			switch (index)
			{
				case 0: return updateButton1;
				case 1: return updateButton2;
				case 2: return updateButton3;
				case 3: return updateButton4;
				case 4: return updateButton5;
			}
			return null;
		}
		// To maintain
		private TextBox GetTextBox(int index)
		{
			switch (index)
			{
				case 0: return stockText1;
				case 1: return stockText2;
				case 2: return stockText3;
				case 3: return stockText4;
				case 4: return stockText5;
			}
			return null;
		}
		// To maintain
		private ListBox GetListBox(int index)
		{
			switch (index)
			{
				case 0: return historicalDataList1;
				case 1: return historicalDataList2;
				case 2: return historicalDataList3;
				case 3: return historicalDataList4;
				case 4: return historicalDataList5;
			}
			return null;
		}
		// To maintain
		private Label GetLabel(int index)
		{
			switch (index)
			{
				case 0: return listBoxLabel1;
				case 1: return listBoxLabel2;
				case 2: return listBoxLabel3;
				case 3: return listBoxLabel4;
				case 4: return listBoxLabel5;
			}
			return null;
		}
		private void RunParallelThreads()
		{
			EnableForm(false);

			try
			{
				_RunParallelThreads();
			}
			finally
			{
				EnableForm(true);
			}
		}

		private void EnableForm(bool b)
		{
			if (b)
			{
				Enabled = true;
				ResumeLayout();
				Cursor.Current = Cursors.Default;
			}
			else
			{
				Enabled = false;
				SuspendLayout();
				Cursor.Current = Cursors.WaitCursor;
			}
		}
		private void _RunParallelThreads()
		{
			ResetControls();

			DateTime startDate = startDateTimePicker.Value;
			DateTime endDate = endDateTimePicker.Value;

			var stockList = new List<string>();
			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				var stock = GetTextBox(i).Text;
				if (!string.IsNullOrWhiteSpace(stock))
				{
					stockList.Add(stock);
				}
			}

			historicalDataSets.Clear();
			List<Task> taskList = new List<Task>();
			foreach (var stock in stockList)
			{
				Task t = Task.Run(
					() =>
					{
						try
						{
							HistoricalDataSet historicalDataSet = RetrieveHistoricalDataSet(startDate, endDate, stock);
							if (historicalDataSet != null)
							{
								historicalDataSets[stock] = historicalDataSet;
							}
						}
						catch
						{ }
						return stock;
					}
				);
				taskList.Add(t);
			}
			Task.WaitAll(taskList.ToArray());

			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				var stock = GetTextBox(i).Text;
				var historicalDataSet = (!string.IsNullOrWhiteSpace(stock) && historicalDataSets.ContainsKey(stock) ? historicalDataSets[stock] : null);
				UpdateSingleStockData(i, historicalDataSet);
			}

			for (int columnIndex = 0; columnIndex < STOCK_NUMBER; columnIndex++)
			{
				UpdateCorrelationColumn(columnIndex, true);
			}
		}
		private void RunSingleThread(int index) 
		{
			Cursor.Current = Cursors.WaitCursor;

			ResetControls();

			DateTime startDate = startDateTimePicker.Value;
			DateTime endDate = endDateTimePicker.Value;

			HistoricalDataSet historicalData = RetrieveHistoricalDataSet(startDate, endDate, GetTextBox(index).Text);

			historicalDataSets[GetTextBox(index).Text] = historicalData;

			UpdateSingleStockData(index, historicalData);

			UpdateCorrelationColumn(index, false);

			UpdateCorrelationChart();

			Cursor.Current = Cursors.Default;
		}
		private void UpdateCorrelationColumn(int columnIndex, bool partial)
		{
			int startRowIndex = (partial ? columnIndex + 1 : 0);
			for (int rowIndex = startRowIndex; rowIndex < STOCK_NUMBER; rowIndex++)
			{
				if (rowIndex != columnIndex)
				{
					UpdateCorrelationMatrixCell(rowIndex, columnIndex);
				}
			}
		}
		private void UpdateSingleStockData(int index, HistoricalDataSet historicalData)
		{
			UpdateStockSymbol(index);

			ListBox listBox = GetListBox(index);
			if (listBox == null) return;

			listBox.Tag = historicalData;

			listBox.Items.Clear();

			Label label = GetLabel(index);
			if(label != null)
			{
				label.Text = string.Empty;
			}

			if (historicalData == null) return;

			var dataDates = historicalData.Dates();
			if (dataDates == null || dataDates.Count == 0) return;

			listBox.BeginUpdate();
			foreach (DateTime date in dataDates)
			{
				listBox.Items.Add(string.Format(" {0:MM.dd.yyyy}        {1:0.00}", date, historicalData.FormattedValue(date)));
			}
			listBox.EndUpdate();

			if (label != null)
			{
				label.Text = string.Format("{0} from {1:MM.dd.yyyy} to {2:MM.dd.yyyy}", dataDates.Count.ToString(), dataDates.Min(), dataDates.Max());
			}
		}
		private void UpdateCorrelationMatrixCell(int rowIndex, int columnIndex)
		{
			var cellContent = string.Empty;

			var rowIndexStockSymbol = GetTextBox(rowIndex).Text;
			var columnIndexStockSymbol = GetTextBox(columnIndex).Text;

			if (historicalDataSets.ContainsKey(rowIndexStockSymbol) && historicalDataSets.ContainsKey(columnIndexStockSymbol))
			{
				HistoricalDataSet rowDataSet = historicalDataSets[rowIndexStockSymbol];
				HistoricalDataSet columnDataSet = historicalDataSets[columnIndexStockSymbol];

				if (rowDataSet != null && columnDataSet != null)
				{
					double? correlation = rowDataSet.GetCorrelation(columnDataSet);
					if (correlation.HasValue) cellContent = string.Format("{0:0.00}", correlation.Value);
				}
			}

			var currentCell = correlationMatrix.Rows[rowIndex].Cells[columnIndex];
			var transposedCell = correlationMatrix.Rows[columnIndex].Cells[rowIndex];
			currentCell.Value = transposedCell.Value = cellContent;
		}
		private HistoricalDataSet RetrieveHistoricalDataSet(DateTime startDate, DateTime endDate, string symbol)
		{
			string _symbol = Helper.FitString(symbol);
			if(string.IsNullOrWhiteSpace(_symbol)) return null;

			HistoricalDataSet historicalData = null;
			try
			{
				historicalData = (new FinDataRetrieval(_symbol)).GetHistoricalData(startDate, endDate);
			}
			catch
			{
			}

			return historicalData;
		}
		private void UpdateTimeSeriesChart()
		{
			timeSeriesFinChart.Clear();

			var actualHistoricalDataSet = (!string.IsNullOrWhiteSpace(timeSeriesSymbol) && historicalDataSets.ContainsKey(timeSeriesSymbol) ? historicalDataSets[timeSeriesSymbol] : null);
			List<DateTime> actualDates;
			if (actualHistoricalDataSet == null || (actualDates = actualHistoricalDataSet.Dates()) == null) return;

			foreach (DateTime actualDate in actualDates)
			{
				timeSeriesFinChart.AddPoint((int)TimeSeriesChartSeries.ACTUAL, actualDate.ToOADate(), actualHistoricalDataSet.Value(actualDate));
			}

			int dayNumber;
			if (!int.TryParse(maTextBox.Text, out dayNumber)) return;
			var startDate = startDateTimePicker.Value.AddDays((int)(-1.1 * (dayNumber / 5 * 7)));
			var endDate = endDateTimePicker.Value;
			Cursor.Current = Cursors.WaitCursor;
			var movingAverageHistoricalDataSet = RetrieveHistoricalDataSet(startDate, endDate, timeSeriesSymbol);
			Cursor.Current = Cursors.Default;
			if (movingAverageHistoricalDataSet == null) return;

			foreach (DateTime actualDate in actualDates)
			{
				double? movingAverage = movingAverageHistoricalDataSet.GetMovingAverage(actualDate, dayNumber);
				if (movingAverage != null) timeSeriesFinChart.AddPoint((int)TimeSeriesChartSeries.MOVING_AVERAGE, actualDate.ToOADate(), movingAverage.Value);
			}
		}
		private void UpdateCorrelationChart(bool optimize = false)
		{
			correlationFinChart.Clear();

			if (string.IsNullOrWhiteSpace(correlatedSymbolX) || string.IsNullOrWhiteSpace(correlatedSymbolY) ||
				!historicalDataSets.ContainsKey(correlatedSymbolX) || !historicalDataSets.ContainsKey(correlatedSymbolY)) return;

			StatisticalDataSeries dataSeries = new StatisticalDataSeries(historicalDataSets[correlatedSymbolX], historicalDataSets[correlatedSymbolY]);

			UpdateCorrelationChartSeries(CorrelationChartSeries.ACTUAL, dataSeries.XValues, dataSeries.YValues);

			int order;
			if (optimize)
			{
				UpdateCorrelationChartSeries(CorrelationChartSeries.OLS, dataSeries.XValues, dataSeries.GetOLSValues(MAX_OLS_ORDER, out order));
				orderTextBox.Text = order.ToString();
			}
			else
			{
				if (int.TryParse(orderTextBox.Text, out order) && order <= MAX_OLS_ORDER)
				{
					UpdateCorrelationChartSeries(CorrelationChartSeries.OLS, dataSeries.XValues, dataSeries.GetOLSValues(order));
				}
			}
		}
		private void UpdateCorrelationChartSeries(CorrelationChartSeries series, double[] XValues, double[] YValues)
		{
			int dotNumber;
			if (XValues == null || YValues == null || (dotNumber = XValues.Length) != YValues.Length) return;

			for (int i = 0; i < dotNumber; i++)
			{
				correlationFinChart.AddPoint((int)series, XValues[i], YValues[i]);
			}
		}
		private void updateAllButton_Click(object sender, EventArgs e)
		{
			RunParallelThreads();
		}
		private void updateButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				if (sender == GetUpdateButton(i))
				{
					RunSingleThread(i);
					return;
				}
			}
		}
		private void stockText_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != (char)Keys.Return) return;

			UpdateCombos();

			for (int i = 0; i < STOCK_NUMBER; i++)
			{
				if (sender == GetTextBox(i))
				{
					RunSingleThread(i);
					return;
				}
			}
		}
		private void orderTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != (char)Keys.Return) return;
			UpdateCorrelationChart();
		}
		private void orderButton_Click(object sender, EventArgs e)
		{
			UpdateCorrelationChart(true);
		}
		private void timeSeriesCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			timeSeriesSymbol = timeSeriesCombo.Text;
			UpdateTimeSeriesChart();
		}
		private void maTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar != (char)Keys.Return) return;
			UpdateTimeSeriesChart();
		}
		private void correlatedCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (sender == correlatedComboX)
			{
				correlatedSymbolX = correlatedComboX.Text;
			}
			else if (sender == correlatedComboY)
			{
				correlatedSymbolY = correlatedComboY.Text;
			}
			else
			{
				return;
			}

			UpdateCorrelationChart();
		}
	}
}