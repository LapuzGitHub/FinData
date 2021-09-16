namespace FinDataForm
{
	partial class FinDataForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinDataForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.stockLabel1 = new System.Windows.Forms.Label();
			this.stockText1 = new System.Windows.Forms.TextBox();
			this.historicalDataList1 = new System.Windows.Forms.ListBox();
			this.stockLabel2 = new System.Windows.Forms.Label();
			this.stockText2 = new System.Windows.Forms.TextBox();
			this.historicalDataList2 = new System.Windows.Forms.ListBox();
			this.historicalDataList3 = new System.Windows.Forms.ListBox();
			this.stockLabel3 = new System.Windows.Forms.Label();
			this.stockText3 = new System.Windows.Forms.TextBox();
			this.updateButton1 = new System.Windows.Forms.Button();
			this.updateButton2 = new System.Windows.Forms.Button();
			this.updateButton3 = new System.Windows.Forms.Button();
			this.updateAllButton = new System.Windows.Forms.Button();
			this.listBoxLabel1 = new System.Windows.Forms.Label();
			this.listBoxLabel2 = new System.Windows.Forms.Label();
			this.listBoxLabel3 = new System.Windows.Forms.Label();
			this.correlationMatrix = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.listBoxLabel4 = new System.Windows.Forms.Label();
			this.updateButton4 = new System.Windows.Forms.Button();
			this.stockText4 = new System.Windows.Forms.TextBox();
			this.stockLabel4 = new System.Windows.Forms.Label();
			this.historicalDataList4 = new System.Windows.Forms.ListBox();
			this.listBoxLabel5 = new System.Windows.Forms.Label();
			this.updateButton5 = new System.Windows.Forms.Button();
			this.stockText5 = new System.Windows.Forms.TextBox();
			this.stockLabel5 = new System.Windows.Forms.Label();
			this.historicalDataList5 = new System.Windows.Forms.ListBox();
			this.correlationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.correlatedComboX = new System.Windows.Forms.ComboBox();
			this.correlatedComboY = new System.Windows.Forms.ComboBox();
			this.orderTextBox = new System.Windows.Forms.TextBox();
			this.ChartTab = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.maTextBox = new System.Windows.Forms.TextBox();
			this.maLabel = new System.Windows.Forms.Label();
			this.timeSeriesCombo = new System.Windows.Forms.ComboBox();
			this.timeSeriesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.orderButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.correlationMatrix)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.correlationChart)).BeginInit();
			this.ChartTab.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeSeriesChart)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// stockLabel1
			// 
			this.stockLabel1.AutoSize = true;
			this.stockLabel1.Location = new System.Drawing.Point(281, 69);
			this.stockLabel1.Name = "stockLabel1";
			this.stockLabel1.Size = new System.Drawing.Size(49, 16);
			this.stockLabel1.TabIndex = 0;
			this.stockLabel1.Text = "Stock 1:";
			// 
			// stockText1
			// 
			this.stockText1.Location = new System.Drawing.Point(336, 66);
			this.stockText1.Name = "stockText1";
			this.stockText1.Size = new System.Drawing.Size(109, 21);
			this.stockText1.TabIndex = 1;
			this.stockText1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockText_KeyPress);
			// 
			// historicalDataList1
			// 
			this.historicalDataList1.BackColor = System.Drawing.Color.Gainsboro;
			this.historicalDataList1.FormattingEnabled = true;
			this.historicalDataList1.ItemHeight = 16;
			this.historicalDataList1.Location = new System.Drawing.Point(280, 90);
			this.historicalDataList1.Name = "historicalDataList1";
			this.historicalDataList1.Size = new System.Drawing.Size(165, 132);
			this.historicalDataList1.TabIndex = 2;
			// 
			// stockLabel2
			// 
			this.stockLabel2.AutoSize = true;
			this.stockLabel2.Location = new System.Drawing.Point(468, 69);
			this.stockLabel2.Name = "stockLabel2";
			this.stockLabel2.Size = new System.Drawing.Size(49, 16);
			this.stockLabel2.TabIndex = 5;
			this.stockLabel2.Text = "Stock 2:";
			// 
			// stockText2
			// 
			this.stockText2.Location = new System.Drawing.Point(524, 66);
			this.stockText2.Name = "stockText2";
			this.stockText2.Size = new System.Drawing.Size(104, 21);
			this.stockText2.TabIndex = 6;
			this.stockText2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockText_KeyPress);
			// 
			// historicalDataList2
			// 
			this.historicalDataList2.BackColor = System.Drawing.Color.Gainsboro;
			this.historicalDataList2.FormattingEnabled = true;
			this.historicalDataList2.ItemHeight = 16;
			this.historicalDataList2.Location = new System.Drawing.Point(463, 90);
			this.historicalDataList2.Name = "historicalDataList2";
			this.historicalDataList2.Size = new System.Drawing.Size(165, 132);
			this.historicalDataList2.TabIndex = 7;
			// 
			// historicalDataList3
			// 
			this.historicalDataList3.BackColor = System.Drawing.Color.Gainsboro;
			this.historicalDataList3.FormattingEnabled = true;
			this.historicalDataList3.ItemHeight = 16;
			this.historicalDataList3.Location = new System.Drawing.Point(647, 90);
			this.historicalDataList3.Name = "historicalDataList3";
			this.historicalDataList3.Size = new System.Drawing.Size(165, 132);
			this.historicalDataList3.TabIndex = 8;
			// 
			// stockLabel3
			// 
			this.stockLabel3.AutoSize = true;
			this.stockLabel3.Location = new System.Drawing.Point(655, 69);
			this.stockLabel3.Name = "stockLabel3";
			this.stockLabel3.Size = new System.Drawing.Size(49, 16);
			this.stockLabel3.TabIndex = 9;
			this.stockLabel3.Text = "Stock 3:";
			// 
			// stockText3
			// 
			this.stockText3.Location = new System.Drawing.Point(708, 66);
			this.stockText3.Name = "stockText3";
			this.stockText3.Size = new System.Drawing.Size(104, 21);
			this.stockText3.TabIndex = 10;
			this.stockText3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockText_KeyPress);
			// 
			// updateButton1
			// 
			this.updateButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton1.Image = ((System.Drawing.Image)(resources.GetObject("updateButton1.Image")));
			this.updateButton1.Location = new System.Drawing.Point(283, 5);
			this.updateButton1.Name = "updateButton1";
			this.updateButton1.Size = new System.Drawing.Size(75, 52);
			this.updateButton1.TabIndex = 11;
			this.updateButton1.Text = "Update";
			this.updateButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updateButton1.UseVisualStyleBackColor = true;
			this.updateButton1.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// updateButton2
			// 
			this.updateButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton2.Image = ((System.Drawing.Image)(resources.GetObject("updateButton2.Image")));
			this.updateButton2.Location = new System.Drawing.Point(466, 6);
			this.updateButton2.Name = "updateButton2";
			this.updateButton2.Size = new System.Drawing.Size(75, 51);
			this.updateButton2.TabIndex = 12;
			this.updateButton2.Text = "Update";
			this.updateButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.updateButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updateButton2.UseVisualStyleBackColor = true;
			this.updateButton2.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// updateButton3
			// 
			this.updateButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton3.Image = ((System.Drawing.Image)(resources.GetObject("updateButton3.Image")));
			this.updateButton3.Location = new System.Drawing.Point(647, 6);
			this.updateButton3.Name = "updateButton3";
			this.updateButton3.Size = new System.Drawing.Size(75, 51);
			this.updateButton3.TabIndex = 13;
			this.updateButton3.Text = "Update";
			this.updateButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updateButton3.UseVisualStyleBackColor = true;
			this.updateButton3.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// updateAllButton
			// 
			this.updateAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateAllButton.Image = ((System.Drawing.Image)(resources.GetObject("updateAllButton.Image")));
			this.updateAllButton.Location = new System.Drawing.Point(98, 6);
			this.updateAllButton.Name = "updateAllButton";
			this.updateAllButton.Size = new System.Drawing.Size(79, 51);
			this.updateAllButton.TabIndex = 14;
			this.updateAllButton.Text = "Update all";
			this.updateAllButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.updateAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updateAllButton.UseVisualStyleBackColor = true;
			this.updateAllButton.Click += new System.EventHandler(this.updateAllButton_Click);
			// 
			// listBoxLabel1
			// 
			this.listBoxLabel1.AutoSize = true;
			this.listBoxLabel1.Location = new System.Drawing.Point(280, 224);
			this.listBoxLabel1.Name = "listBoxLabel1";
			this.listBoxLabel1.Size = new System.Drawing.Size(41, 16);
			this.listBoxLabel1.TabIndex = 15;
			this.listBoxLabel1.Text = "label1";
			// 
			// listBoxLabel2
			// 
			this.listBoxLabel2.AutoSize = true;
			this.listBoxLabel2.Location = new System.Drawing.Point(463, 224);
			this.listBoxLabel2.Name = "listBoxLabel2";
			this.listBoxLabel2.Size = new System.Drawing.Size(41, 16);
			this.listBoxLabel2.TabIndex = 16;
			this.listBoxLabel2.Text = "label2";
			// 
			// listBoxLabel3
			// 
			this.listBoxLabel3.AutoSize = true;
			this.listBoxLabel3.Location = new System.Drawing.Point(647, 224);
			this.listBoxLabel3.Name = "listBoxLabel3";
			this.listBoxLabel3.Size = new System.Drawing.Size(41, 16);
			this.listBoxLabel3.TabIndex = 17;
			this.listBoxLabel3.Text = "label3";
			// 
			// correlationMatrix
			// 
			this.correlationMatrix.AllowUserToAddRows = false;
			this.correlationMatrix.AllowUserToDeleteRows = false;
			this.correlationMatrix.AllowUserToResizeColumns = false;
			this.correlationMatrix.AllowUserToResizeRows = false;
			this.correlationMatrix.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.correlationMatrix.CausesValidation = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.correlationMatrix.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.correlationMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.correlationMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.correlationMatrix.Enabled = false;
			this.correlationMatrix.EnableHeadersVisualStyles = false;
			this.correlationMatrix.Location = new System.Drawing.Point(15, 59);
			this.correlationMatrix.MultiSelect = false;
			this.correlationMatrix.Name = "correlationMatrix";
			this.correlationMatrix.ReadOnly = true;
			this.correlationMatrix.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.correlationMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.correlationMatrix.RowHeadersWidth = 70;
			this.correlationMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.correlationMatrix.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.correlationMatrix.RowTemplate.Height = 20;
			this.correlationMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.correlationMatrix.Size = new System.Drawing.Size(422, 123);
			this.correlationMatrix.TabIndex = 18;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.HeaderText = "Column1";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column1.Width = 70;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column2.HeaderText = "Column2";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column2.Width = 70;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column3.HeaderText = "Column3";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Column3.Width = 70;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column4.HeaderText = "Column4";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 70;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column5.HeaderText = "Column5";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 70;
			// 
			// startDateTimePicker
			// 
			this.startDateTimePicker.Location = new System.Drawing.Point(98, 90);
			this.startDateTimePicker.Name = "startDateTimePicker";
			this.startDateTimePicker.Size = new System.Drawing.Size(166, 21);
			this.startDateTimePicker.TabIndex = 19;
			// 
			// endDateTimePicker
			// 
			this.endDateTimePicker.Location = new System.Drawing.Point(98, 125);
			this.endDateTimePicker.Name = "endDateTimePicker";
			this.endDateTimePicker.Size = new System.Drawing.Size(166, 21);
			this.endDateTimePicker.TabIndex = 20;
			// 
			// listBoxLabel4
			// 
			this.listBoxLabel4.AutoSize = true;
			this.listBoxLabel4.Location = new System.Drawing.Point(832, 224);
			this.listBoxLabel4.Name = "listBoxLabel4";
			this.listBoxLabel4.Size = new System.Drawing.Size(41, 16);
			this.listBoxLabel4.TabIndex = 25;
			this.listBoxLabel4.Text = "label4";
			// 
			// updateButton4
			// 
			this.updateButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton4.Image = ((System.Drawing.Image)(resources.GetObject("updateButton4.Image")));
			this.updateButton4.Location = new System.Drawing.Point(832, 6);
			this.updateButton4.Name = "updateButton4";
			this.updateButton4.Size = new System.Drawing.Size(75, 51);
			this.updateButton4.TabIndex = 24;
			this.updateButton4.Text = "Update";
			this.updateButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updateButton4.UseVisualStyleBackColor = true;
			this.updateButton4.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// stockText4
			// 
			this.stockText4.Location = new System.Drawing.Point(893, 66);
			this.stockText4.Name = "stockText4";
			this.stockText4.Size = new System.Drawing.Size(104, 21);
			this.stockText4.TabIndex = 23;
			this.stockText4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockText_KeyPress);
			// 
			// stockLabel4
			// 
			this.stockLabel4.AutoSize = true;
			this.stockLabel4.Location = new System.Drawing.Point(840, 69);
			this.stockLabel4.Name = "stockLabel4";
			this.stockLabel4.Size = new System.Drawing.Size(49, 16);
			this.stockLabel4.TabIndex = 22;
			this.stockLabel4.Text = "Stock 4:";
			// 
			// historicalDataList4
			// 
			this.historicalDataList4.BackColor = System.Drawing.Color.Gainsboro;
			this.historicalDataList4.FormattingEnabled = true;
			this.historicalDataList4.ItemHeight = 16;
			this.historicalDataList4.Location = new System.Drawing.Point(832, 90);
			this.historicalDataList4.Name = "historicalDataList4";
			this.historicalDataList4.Size = new System.Drawing.Size(165, 132);
			this.historicalDataList4.TabIndex = 21;
			// 
			// listBoxLabel5
			// 
			this.listBoxLabel5.AutoSize = true;
			this.listBoxLabel5.Location = new System.Drawing.Point(1016, 224);
			this.listBoxLabel5.Name = "listBoxLabel5";
			this.listBoxLabel5.Size = new System.Drawing.Size(41, 16);
			this.listBoxLabel5.TabIndex = 30;
			this.listBoxLabel5.Text = "label5";
			// 
			// updateButton5
			// 
			this.updateButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.updateButton5.Image = ((System.Drawing.Image)(resources.GetObject("updateButton5.Image")));
			this.updateButton5.Location = new System.Drawing.Point(1016, 6);
			this.updateButton5.Name = "updateButton5";
			this.updateButton5.Size = new System.Drawing.Size(75, 51);
			this.updateButton5.TabIndex = 29;
			this.updateButton5.Text = "Update";
			this.updateButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.updateButton5.UseVisualStyleBackColor = true;
			this.updateButton5.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// stockText5
			// 
			this.stockText5.Location = new System.Drawing.Point(1077, 66);
			this.stockText5.Name = "stockText5";
			this.stockText5.Size = new System.Drawing.Size(104, 21);
			this.stockText5.TabIndex = 28;
			this.stockText5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stockText_KeyPress);
			// 
			// stockLabel5
			// 
			this.stockLabel5.AutoSize = true;
			this.stockLabel5.Location = new System.Drawing.Point(1024, 69);
			this.stockLabel5.Name = "stockLabel5";
			this.stockLabel5.Size = new System.Drawing.Size(49, 16);
			this.stockLabel5.TabIndex = 27;
			this.stockLabel5.Text = "Stock 5:";
			// 
			// historicalDataList5
			// 
			this.historicalDataList5.BackColor = System.Drawing.Color.Gainsboro;
			this.historicalDataList5.FormattingEnabled = true;
			this.historicalDataList5.ItemHeight = 16;
			this.historicalDataList5.Location = new System.Drawing.Point(1016, 90);
			this.historicalDataList5.Name = "historicalDataList5";
			this.historicalDataList5.Size = new System.Drawing.Size(165, 132);
			this.historicalDataList5.TabIndex = 26;
			// 
			// correlationChart
			// 
			this.correlationChart.BackColor = System.Drawing.Color.Gainsboro;
			this.correlationChart.BackImageTransparentColor = System.Drawing.Color.White;
			this.correlationChart.BackSecondaryColor = System.Drawing.SystemColors.Control;
			this.correlationChart.BorderlineColor = System.Drawing.Color.Black;
			this.correlationChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea1.AxisX.IsStartedFromZero = false;
			chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.AxisY.IsStartedFromZero = false;
			chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea1.Name = "ChartArea1";
			this.correlationChart.ChartAreas.Add(chartArea1);
			this.correlationChart.Location = new System.Drawing.Point(453, 55);
			this.correlationChart.Name = "correlationChart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series1.Name = "Series1";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series2.Name = "Series2";
			this.correlationChart.Series.Add(series1);
			this.correlationChart.Series.Add(series2);
			this.correlationChart.Size = new System.Drawing.Size(425, 254);
			this.correlationChart.TabIndex = 31;
			this.correlationChart.Text = "chart1";
			// 
			// correlatedComboX
			// 
			this.correlatedComboX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.correlatedComboX.FormattingEnabled = true;
			this.correlatedComboX.Location = new System.Drawing.Point(454, 19);
			this.correlatedComboX.Name = "correlatedComboX";
			this.correlatedComboX.Size = new System.Drawing.Size(121, 24);
			this.correlatedComboX.TabIndex = 32;
			this.correlatedComboX.SelectedIndexChanged += new System.EventHandler(this.correlatedCombo_SelectedIndexChanged);
			// 
			// correlatedComboY
			// 
			this.correlatedComboY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.correlatedComboY.FormattingEnabled = true;
			this.correlatedComboY.Location = new System.Drawing.Point(592, 19);
			this.correlatedComboY.Name = "correlatedComboY";
			this.correlatedComboY.Size = new System.Drawing.Size(121, 24);
			this.correlatedComboY.TabIndex = 33;
			this.correlatedComboY.SelectedIndexChanged += new System.EventHandler(this.correlatedCombo_SelectedIndexChanged);
			// 
			// orderTextBox
			// 
			this.orderTextBox.Location = new System.Drawing.Point(830, 19);
			this.orderTextBox.Name = "orderTextBox";
			this.orderTextBox.Size = new System.Drawing.Size(46, 21);
			this.orderTextBox.TabIndex = 35;
			this.orderTextBox.Text = "1";
			this.orderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.orderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderTextBox_KeyPress);
			// 
			// ChartTab
			// 
			this.ChartTab.Controls.Add(this.tabPage1);
			this.ChartTab.Controls.Add(this.tabPage2);
			this.ChartTab.Location = new System.Drawing.Point(279, 254);
			this.ChartTab.Name = "ChartTab";
			this.ChartTab.SelectedIndex = 0;
			this.ChartTab.Size = new System.Drawing.Size(901, 363);
			this.ChartTab.TabIndex = 36;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
			this.tabPage1.Controls.Add(this.maTextBox);
			this.tabPage1.Controls.Add(this.maLabel);
			this.tabPage1.Controls.Add(this.timeSeriesCombo);
			this.tabPage1.Controls.Add(this.timeSeriesChart);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(893, 334);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "TA chart";
			// 
			// maTextBox
			// 
			this.maTextBox.Location = new System.Drawing.Point(421, 28);
			this.maTextBox.Name = "maTextBox";
			this.maTextBox.Size = new System.Drawing.Size(46, 21);
			this.maTextBox.TabIndex = 38;
			this.maTextBox.Text = "20";
			this.maTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.maTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maTextBox_KeyPress);
			// 
			// maLabel
			// 
			this.maLabel.AutoSize = true;
			this.maLabel.Location = new System.Drawing.Point(360, 31);
			this.maLabel.Name = "maLabel";
			this.maLabel.Size = new System.Drawing.Size(58, 16);
			this.maLabel.TabIndex = 37;
			this.maLabel.Text = "MA days:";
			// 
			// timeSeriesCombo
			// 
			this.timeSeriesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeSeriesCombo.FormattingEnabled = true;
			this.timeSeriesCombo.Location = new System.Drawing.Point(42, 23);
			this.timeSeriesCombo.Name = "timeSeriesCombo";
			this.timeSeriesCombo.Size = new System.Drawing.Size(121, 24);
			this.timeSeriesCombo.TabIndex = 33;
			this.timeSeriesCombo.SelectedIndexChanged += new System.EventHandler(this.timeSeriesCombo_SelectedIndexChanged);
			// 
			// timeSeriesChart
			// 
			this.timeSeriesChart.BackColor = System.Drawing.Color.Gainsboro;
			this.timeSeriesChart.BackImageTransparentColor = System.Drawing.Color.White;
			this.timeSeriesChart.BackSecondaryColor = System.Drawing.SystemColors.Control;
			this.timeSeriesChart.BorderlineColor = System.Drawing.Color.Black;
			this.timeSeriesChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea2.AxisX.IsStartedFromZero = false;
			chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.AxisY.IsStartedFromZero = false;
			chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
			chartArea2.BackColor = System.Drawing.Color.WhiteSmoke;
			chartArea2.Name = "ChartArea1";
			this.timeSeriesChart.ChartAreas.Add(chartArea2);
			this.timeSeriesChart.Location = new System.Drawing.Point(42, 52);
			this.timeSeriesChart.Name = "timeSeriesChart";
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series3.Name = "Series1";
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series4.Name = "Series2";
			this.timeSeriesChart.Series.Add(series3);
			this.timeSeriesChart.Series.Add(series4);
			this.timeSeriesChart.Size = new System.Drawing.Size(425, 254);
			this.timeSeriesChart.TabIndex = 32;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
			this.tabPage2.Controls.Add(this.orderButton);
			this.tabPage2.Controls.Add(this.correlationMatrix);
			this.tabPage2.Controls.Add(this.orderTextBox);
			this.tabPage2.Controls.Add(this.correlationChart);
			this.tabPage2.Controls.Add(this.correlatedComboX);
			this.tabPage2.Controls.Add(this.correlatedComboY);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(893, 334);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Correlation";
			// 
			// orderButton
			// 
			this.orderButton.Location = new System.Drawing.Point(774, 18);
			this.orderButton.Name = "orderButton";
			this.orderButton.Size = new System.Drawing.Size(52, 23);
			this.orderButton.TabIndex = 36;
			this.orderButton.Text = "Order";
			this.orderButton.UseVisualStyleBackColor = true;
			this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(72, 640);
			this.panel1.TabIndex = 37;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(72, 61);
			this.panel3.TabIndex = 39;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 39);
			this.label1.TabIndex = 39;
			this.label1.Text = "FD";
			// 
			// FinDataForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
			this.ClientSize = new System.Drawing.Size(1208, 640);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ChartTab);
			this.Controls.Add(this.listBoxLabel5);
			this.Controls.Add(this.updateButton5);
			this.Controls.Add(this.stockText5);
			this.Controls.Add(this.stockLabel5);
			this.Controls.Add(this.historicalDataList5);
			this.Controls.Add(this.listBoxLabel4);
			this.Controls.Add(this.updateButton4);
			this.Controls.Add(this.stockText4);
			this.Controls.Add(this.stockLabel4);
			this.Controls.Add(this.historicalDataList4);
			this.Controls.Add(this.endDateTimePicker);
			this.Controls.Add(this.startDateTimePicker);
			this.Controls.Add(this.listBoxLabel3);
			this.Controls.Add(this.listBoxLabel2);
			this.Controls.Add(this.listBoxLabel1);
			this.Controls.Add(this.updateAllButton);
			this.Controls.Add(this.updateButton3);
			this.Controls.Add(this.updateButton2);
			this.Controls.Add(this.updateButton1);
			this.Controls.Add(this.stockText3);
			this.Controls.Add(this.stockLabel3);
			this.Controls.Add(this.historicalDataList3);
			this.Controls.Add(this.historicalDataList2);
			this.Controls.Add(this.stockText2);
			this.Controls.Add(this.stockLabel2);
			this.Controls.Add(this.historicalDataList1);
			this.Controls.Add(this.stockText1);
			this.Controls.Add(this.stockLabel1);
			this.Font = new System.Drawing.Font("Century Gothic", 8F);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FinDataForm";
			this.Text = "Financial Data";
			((System.ComponentModel.ISupportInitialize)(this.correlationMatrix)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.correlationChart)).EndInit();
			this.ChartTab.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeSeriesChart)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label stockLabel1;
		private System.Windows.Forms.TextBox stockText1;
		private System.Windows.Forms.ListBox historicalDataList1;
		private System.Windows.Forms.Label stockLabel2;
		private System.Windows.Forms.TextBox stockText2;
		private System.Windows.Forms.ListBox historicalDataList2;
		private System.Windows.Forms.ListBox historicalDataList3;
		private System.Windows.Forms.Label stockLabel3;
		private System.Windows.Forms.TextBox stockText3;
		private System.Windows.Forms.Button updateButton1;
		private System.Windows.Forms.Button updateButton2;
		private System.Windows.Forms.Button updateButton3;
		private System.Windows.Forms.Button updateAllButton;
		private System.Windows.Forms.Label listBoxLabel1;
		private System.Windows.Forms.Label listBoxLabel2;
		private System.Windows.Forms.Label listBoxLabel3;
		private System.Windows.Forms.DataGridView correlationMatrix;
		private System.Windows.Forms.DateTimePicker startDateTimePicker;
		private System.Windows.Forms.DateTimePicker endDateTimePicker;
		private System.Windows.Forms.Label listBoxLabel4;
		private System.Windows.Forms.Button updateButton4;
		private System.Windows.Forms.TextBox stockText4;
		private System.Windows.Forms.Label stockLabel4;
		private System.Windows.Forms.ListBox historicalDataList4;
		private System.Windows.Forms.Label listBoxLabel5;
		private System.Windows.Forms.Button updateButton5;
		private System.Windows.Forms.TextBox stockText5;
		private System.Windows.Forms.Label stockLabel5;
		private System.Windows.Forms.ListBox historicalDataList5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataVisualization.Charting.Chart correlationChart;
		private System.Windows.Forms.ComboBox correlatedComboX;
		private System.Windows.Forms.ComboBox correlatedComboY;
		private System.Windows.Forms.TextBox orderTextBox;
		private System.Windows.Forms.TabControl ChartTab;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataVisualization.Charting.Chart timeSeriesChart;
		private System.Windows.Forms.ComboBox timeSeriesCombo;
		private System.Windows.Forms.Button orderButton;
		private System.Windows.Forms.TextBox maTextBox;
		private System.Windows.Forms.Label maLabel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
	}
}

