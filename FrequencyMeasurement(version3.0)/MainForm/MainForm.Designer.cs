namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountMeas = new System.Windows.Forms.ToolStripStatusLabel();
            this.TableSKSV = new System.Windows.Forms.TabPage();
            this.chartSKSV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SKSV = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableSKO = new System.Windows.Forms.TabPage();
            this.chartSKO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SKO = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKO_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TableAllan = new System.Windows.Forms.TabPage();
            this.chartAllan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AllanTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MainTable = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClearTables = new System.Windows.Forms.ToolStripMenuItem();
            this.MainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TableAllanOver = new System.Windows.Forms.TabPage();
            this.chartOverAllan = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.AllanOver = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StartMeas = new System.Windows.Forms.ToolStripButton();
            this.StopMeas = new System.Windows.Forms.ToolStripButton();
            this.OpenSetting = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundproccess = new System.ComponentModel.BackgroundWorker();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.TableSKSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSKSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKSV)).BeginInit();
            this.TableSKO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSKO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKO)).BeginInit();
            this.TableAllan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAllan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllanTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TableAllanOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOverAllan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllanOver)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.CountMeas});
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(130, 17);
            this.toolStripStatusLabel1.Text = "Количество значений:";
            // 
            // CountMeas
            // 
            this.CountMeas.Name = "CountMeas";
            this.CountMeas.Size = new System.Drawing.Size(13, 17);
            this.CountMeas.Text = "0";
            // 
            // TableSKSV
            // 
            this.TableSKSV.Controls.Add(this.chartSKSV);
            this.TableSKSV.Controls.Add(this.SKSV);
            this.TableSKSV.Location = new System.Drawing.Point(4, 22);
            this.TableSKSV.Name = "TableSKSV";
            this.TableSKSV.Padding = new System.Windows.Forms.Padding(3);
            this.TableSKSV.Size = new System.Drawing.Size(796, 307);
            this.TableSKSV.TabIndex = 3;
            this.TableSKSV.Text = "СКСВ";
            this.TableSKSV.UseVisualStyleBackColor = true;
            // 
            // chartSKSV
            // 
            this.chartSKSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IsLogarithmic = true;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Minimum = 1D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 1D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisY.IsLogarithmic = true;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 1D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.Name = "ChartArea1";
            this.chartSKSV.ChartAreas.Add(chartArea1);
            this.chartSKSV.Location = new System.Drawing.Point(235, 1);
            this.chartSKSV.Name = "chartSKSV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DarkRed;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            this.chartSKSV.Series.Add(series1);
            this.chartSKSV.Size = new System.Drawing.Size(558, 312);
            this.chartSKSV.TabIndex = 2;
            this.chartSKSV.Text = "chart1";
            // 
            // SKSV
            // 
            this.SKSV.AllowUserToAddRows = false;
            this.SKSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SKSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SKSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Column5,
            this.Column7});
            this.SKSV.Location = new System.Drawing.Point(3, 0);
            this.SKSV.Name = "SKSV";
            this.SKSV.RowHeadersVisible = false;
            this.SKSV.Size = new System.Drawing.Size(232, 315);
            this.SKSV.TabIndex = 1;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.Width = 71;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "СКСВ";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "N";
            this.Column7.Name = "Column7";
            this.Column7.Width = 71;
            // 
            // TableSKO
            // 
            this.TableSKO.Controls.Add(this.chartSKO);
            this.TableSKO.Controls.Add(this.SKO);
            this.TableSKO.Location = new System.Drawing.Point(4, 22);
            this.TableSKO.Name = "TableSKO";
            this.TableSKO.Padding = new System.Windows.Forms.Padding(3);
            this.TableSKO.Size = new System.Drawing.Size(796, 307);
            this.TableSKO.TabIndex = 2;
            this.TableSKO.Text = "СКО";
            this.TableSKO.UseVisualStyleBackColor = true;
            // 
            // chartSKO
            // 
            this.chartSKO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisX.IsLogarithmic = true;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.Minimum = 1D;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.Interval = 1D;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisY.IsLogarithmic = true;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.Interval = 1D;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea2.Name = "ChartArea1";
            this.chartSKO.ChartAreas.Add(chartArea2);
            this.chartSKO.Location = new System.Drawing.Point(235, 1);
            this.chartSKO.Name = "chartSKO";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.DarkRed;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Series1";
            series2.Points.Add(dataPoint2);
            this.chartSKO.Series.Add(series2);
            this.chartSKO.Size = new System.Drawing.Size(558, 312);
            this.chartSKO.TabIndex = 1;
            this.chartSKO.Text = "chartSKO";
            // 
            // SKO
            // 
            this.SKO.AllowUserToAddRows = false;
            this.SKO.AllowUserToDeleteRows = false;
            this.SKO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SKO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SKO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.SKO_N});
            this.SKO.Location = new System.Drawing.Point(3, 0);
            this.SKO.Name = "SKO";
            this.SKO.RowHeadersVisible = false;
            this.SKO.Size = new System.Drawing.Size(232, 315);
            this.SKO.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 111.9289F;
            this.Column3.HeaderText = "Время";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 111.9289F;
            this.Column4.HeaderText = "СКО";
            this.Column4.Name = "Column4";
            // 
            // SKO_N
            // 
            this.SKO_N.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SKO_N.FillWeight = 76.14214F;
            this.SKO_N.HeaderText = "N";
            this.SKO_N.Name = "SKO_N";
            // 
            // TableAllan
            // 
            this.TableAllan.Controls.Add(this.chartAllan);
            this.TableAllan.Controls.Add(this.AllanTable);
            this.TableAllan.Location = new System.Drawing.Point(4, 22);
            this.TableAllan.Name = "TableAllan";
            this.TableAllan.Padding = new System.Windows.Forms.Padding(3);
            this.TableAllan.Size = new System.Drawing.Size(796, 307);
            this.TableAllan.TabIndex = 1;
            this.TableAllan.Text = "Вариация Аллана";
            this.TableAllan.UseVisualStyleBackColor = true;
            // 
            // chartAllan
            // 
            this.chartAllan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisX.IsLogarithmic = true;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisX.Minimum = 1D;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisX.MinorGrid.Interval = 1D;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea3.AxisY.IsLogarithmic = true;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.Interval = 1D;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea3.Name = "ChartArea1";
            this.chartAllan.ChartAreas.Add(chartArea3);
            this.chartAllan.Location = new System.Drawing.Point(235, 1);
            this.chartAllan.Name = "chartAllan";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.DarkRed;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series3.Name = "Series1";
            series3.Points.Add(dataPoint3);
            this.chartAllan.Series.Add(series3);
            this.chartAllan.Size = new System.Drawing.Size(558, 312);
            this.chartAllan.TabIndex = 3;
            this.chartAllan.Text = "chart1";
            // 
            // AllanTable
            // 
            this.AllanTable.AllowUserToAddRows = false;
            this.AllanTable.AllowUserToDeleteRows = false;
            this.AllanTable.AllowUserToOrderColumns = true;
            this.AllanTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AllanTable.ColumnHeadersHeight = 21;
            this.AllanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6});
            this.AllanTable.Location = new System.Drawing.Point(3, 0);
            this.AllanTable.Name = "AllanTable";
            this.AllanTable.RowHeadersVisible = false;
            this.AllanTable.Size = new System.Drawing.Size(232, 315);
            this.AllanTable.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Время";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Вариация Аллана";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "N";
            this.Column6.Name = "Column6";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MainTable);
            this.tabPage1.Controls.Add(this.MainChart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 307);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Частота";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainTable
            // 
            this.MainTable.AllowUserToAddRows = false;
            this.MainTable.AllowUserToDeleteRows = false;
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.DateTime1,
            this.Data});
            this.MainTable.ContextMenuStrip = this.contextMenuStrip1;
            this.MainTable.Location = new System.Drawing.Point(3, 0);
            this.MainTable.Name = "MainTable";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MainTable.RowHeadersVisible = false;
            this.MainTable.RowHeadersWidth = 45;
            this.MainTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.MainTable.Size = new System.Drawing.Size(242, 315);
            this.MainTable.TabIndex = 1;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.FillWeight = 45.68528F;
            this.Column11.HeaderText = "№";
            this.Column11.Name = "Column11";
            // 
            // DateTime1
            // 
            this.DateTime1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTime1.FillWeight = 136.5765F;
            this.DateTime1.HeaderText = "Дата/Время";
            this.DateTime1.Name = "DateTime1";
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Data.FillWeight = 117.7382F;
            this.Data.HeaderText = "Отн. частота";
            this.Data.Name = "Data";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearTables});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 26);
            // 
            // ClearTables
            // 
            this.ClearTables.Name = "ClearTables";
            this.ClearTables.Size = new System.Drawing.Size(174, 22);
            this.ClearTables.Text = "Очистить таблицу";
            this.ClearTables.Click += new System.EventHandler(this.очиститьТаблицуToolStripMenuItem_Click);
            // 
            // MainChart
            // 
            this.MainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Days;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelStyle.Angle = -30;
            chartArea4.AxisX.LabelStyle.Format = "d/MMM HH:mm";
            chartArea4.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisX.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea4.AxisY.Title = "Отн. погрешность частоты";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea4.Name = "ChartArea1";
            this.MainChart.ChartAreas.Add(chartArea4);
            this.MainChart.Location = new System.Drawing.Point(240, 0);
            this.MainChart.Name = "MainChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "Series1";
            this.MainChart.Series.Add(series4);
            this.MainChart.Size = new System.Drawing.Size(559, 309);
            this.MainChart.TabIndex = 0;
            this.MainChart.Text = "MainChart";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TableAllan);
            this.tabControl1.Controls.Add(this.TableSKO);
            this.tabControl1.Controls.Add(this.TableSKSV);
            this.tabControl1.Controls.Add(this.TableAllanOver);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 333);
            this.tabControl1.TabIndex = 5;
            // 
            // TableAllanOver
            // 
            this.TableAllanOver.Controls.Add(this.chartOverAllan);
            this.TableAllanOver.Controls.Add(this.AllanOver);
            this.TableAllanOver.Location = new System.Drawing.Point(4, 22);
            this.TableAllanOver.Name = "TableAllanOver";
            this.TableAllanOver.Padding = new System.Windows.Forms.Padding(3);
            this.TableAllanOver.Size = new System.Drawing.Size(796, 307);
            this.TableAllanOver.TabIndex = 4;
            this.TableAllanOver.Text = "Аллан с перекрытиями";
            this.TableAllanOver.UseVisualStyleBackColor = true;
            // 
            // chartOverAllan
            // 
            this.chartOverAllan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea5.AxisX.IsLogarithmic = true;
            chartArea5.AxisX.IsStartedFromZero = false;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisX.Minimum = 1D;
            chartArea5.AxisX.MinorGrid.Enabled = true;
            chartArea5.AxisX.MinorGrid.Interval = 1D;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea5.AxisY.Crossing = -1.7976931348623157E+308D;
            chartArea5.AxisY.IsLogarithmic = true;
            chartArea5.AxisY.IsStartedFromZero = false;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.AxisY.MinorGrid.Enabled = true;
            chartArea5.AxisY.MinorGrid.Interval = 1D;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea5.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea5.Name = "ChartArea1";
            this.chartOverAllan.ChartAreas.Add(chartArea5);
            this.chartOverAllan.Location = new System.Drawing.Point(235, 1);
            this.chartOverAllan.Name = "chartOverAllan";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.DarkRed;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series5.Name = "Series1";
            series5.Points.Add(dataPoint4);
            this.chartOverAllan.Series.Add(series5);
            this.chartOverAllan.Size = new System.Drawing.Size(558, 312);
            this.chartOverAllan.TabIndex = 2;
            this.chartOverAllan.Text = "chart1";
            // 
            // AllanOver
            // 
            this.AllanOver.AllowUserToAddRows = false;
            this.AllanOver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllanOver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10});
            this.AllanOver.Location = new System.Drawing.Point(3, 0);
            this.AllanOver.Name = "AllanOver";
            this.AllanOver.RowHeadersVisible = false;
            this.AllanOver.Size = new System.Drawing.Size(232, 315);
            this.AllanOver.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.StartMeas,
            this.StopMeas,
            this.OpenSetting,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.справкаToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(804, 28);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // StartMeas
            // 
            this.StartMeas.AutoSize = false;
            this.StartMeas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartMeas.Image = global::MainForm.Properties.Resources.START;
            this.StartMeas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartMeas.Name = "StartMeas";
            this.StartMeas.Size = new System.Drawing.Size(24, 22);
            this.StartMeas.Text = "Старт";
            this.StartMeas.Click += new System.EventHandler(this.StartMeas_Click);
            // 
            // StopMeas
            // 
            this.StopMeas.AutoSize = false;
            this.StopMeas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StopMeas.Image = global::MainForm.Properties.Resources.STOP;
            this.StopMeas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StopMeas.Name = "StopMeas";
            this.StopMeas.Size = new System.Drawing.Size(24, 22);
            this.StopMeas.Text = "Стоп";
            this.StopMeas.Click += new System.EventHandler(this.StopMeas_Click);
            // 
            // OpenSetting
            // 
            this.OpenSetting.AutoSize = false;
            this.OpenSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenSetting.Image = global::MainForm.Properties.Resources.SET;
            this.OpenSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenSetting.Name = "OpenSetting";
            this.OpenSetting.Size = new System.Drawing.Size(24, 22);
            this.OpenSetting.Text = "Настройки";
            this.OpenSetting.Click += new System.EventHandler(this.OpenSetting_Click);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.AutoSize = false;
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(24, 22);
            this.открытьToolStripButton.Text = "&Открыть";
            this.открытьToolStripButton.Click += new System.EventHandler(this.открытьToolStripButton_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.AutoSize = false;
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(24, 22);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.AutoSize = false;
            this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(24, 22);
            this.справкаToolStripButton.Text = "Спр&авка";
            // 
            // backgroundproccess
            // 
            this.backgroundproccess.WorkerReportsProgress = true;
            this.backgroundproccess.WorkerSupportsCancellation = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.HeaderText = "Время";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.HeaderText = "Вариация";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.HeaderText = "N";
            this.Column10.Name = "Column10";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 383);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "MainForm";
            this.Text = "Программа сбора и обработки частотных данных";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TableSKSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSKSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKSV)).EndInit();
            this.TableSKO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSKO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SKO)).EndInit();
            this.TableAllan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAllan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllanTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TableAllanOver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOverAllan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllanOver)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage TableSKSV;
        private System.Windows.Forms.TabPage TableSKO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSKO;
        private System.Windows.Forms.DataGridView SKO;
        private System.Windows.Forms.TabPage TableAllan;
        public System.Windows.Forms.DataGridView AllanTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView MainTable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridView SKSV;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart MainChart;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton;
        private System.Windows.Forms.ToolStripButton StartMeas;
        private System.Windows.Forms.ToolStripButton StopMeas;
        private System.Windows.Forms.ToolStripButton OpenSetting;
        private System.Windows.Forms.ToolStripStatusLabel CountMeas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabPage TableAllanOver;
        private System.Windows.Forms.DataGridView AllanOver;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSKSV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOverAllan;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAllan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKO_N;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClearTables;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundproccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

