namespace ClustersPlot
{
    partial class ClusterOut
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.StripLine stripLine2 = new System.Windows.Forms.DataVisualization.Charting.StripLine();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.factorX_label = new System.Windows.Forms.Label();
            this.factorY_label = new System.Windows.Forms.Label();
            this.factorX = new System.Windows.Forms.ComboBox();
            this.factorY = new System.Windows.Forms.ComboBox();
            this.getListProvince = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.infoOutPut = new System.Windows.Forms.TextBox();
            this.paintForel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRows = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faq1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faq2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberForel = new System.Windows.Forms.TextBox();
            this.radiusForel = new System.Windows.Forms.TextBox();
            this.Radius_label = new System.Windows.Forms.Label();
            this.NumberP_label = new System.Windows.Forms.Label();
            this.showPoints = new System.Windows.Forms.Button();
            this.Xmax = new System.Windows.Forms.TextBox();
            this.Ymax = new System.Windows.Forms.TextBox();
            this.intervalXY = new System.Windows.Forms.TextBox();
            this.setScale = new System.Windows.Forms.Button();
            this.Xmax_label = new System.Windows.Forms.Label();
            this.Ymax_label = new System.Windows.Forms.Label();
            this.intervalXY_label = new System.Windows.Forms.Label();
            this.initData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // factorX_label
            // 
            this.factorX_label.AutoSize = true;
            this.factorX_label.Location = new System.Drawing.Point(6, 11);
            this.factorX_label.Name = "factorX_label";
            this.factorX_label.Size = new System.Drawing.Size(72, 13);
            this.factorX_label.TabIndex = 1;
            this.factorX_label.Text = "Фактор 1 [X]";
            // 
            // factorY_label
            // 
            this.factorY_label.AutoSize = true;
            this.factorY_label.Location = new System.Drawing.Point(252, 11);
            this.factorY_label.Name = "factorY_label";
            this.factorY_label.Size = new System.Drawing.Size(72, 13);
            this.factorY_label.TabIndex = 2;
            this.factorY_label.Text = "Фактор 2 [Y]";
            // 
            // factorX
            // 
            this.factorX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.factorX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.factorX.ForeColor = System.Drawing.Color.Black;
            this.factorX.FormattingEnabled = true;
            this.factorX.Items.AddRange(new object[] {
            "[1] Происшествий.ДТП",
            "[2] Пострадавшие.ДТП",
            "[3] Погибшие.ДТП",
            "[4] Происшествия.Пожары",
            "[5] Пострадавшие.Пожары",
            "[6] Погибшие.Пожары",
            "[7] Энергоснабжение"});
            this.factorX.Location = new System.Drawing.Point(84, 8);
            this.factorX.Name = "factorX";
            this.factorX.Size = new System.Drawing.Size(162, 21);
            this.factorX.TabIndex = 3;
            // 
            // factorY
            // 
            this.factorY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.factorY.FormattingEnabled = true;
            this.factorY.Items.AddRange(new object[] {
            "[1] Происшествий.ДТП",
            "[2] Пострадавшие.ДТП",
            "[3] Погибшие.ДТП",
            "[4] Происшествия.Пожары",
            "[5] Пострадавшие.Пожары",
            "[6] Погибшие.Пожары",
            "[7] Энергоснабжение"});
            this.factorY.Location = new System.Drawing.Point(335, 8);
            this.factorY.Name = "factorY";
            this.factorY.Size = new System.Drawing.Size(162, 21);
            this.factorY.TabIndex = 4;
            // 
            // getListProvince
            // 
            this.getListProvince.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.getListProvince.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.getListProvince.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.getListProvince.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getListProvince.Location = new System.Drawing.Point(597, 8);
            this.getListProvince.Name = "getListProvince";
            this.getListProvince.Size = new System.Drawing.Size(75, 23);
            this.getListProvince.TabIndex = 6;
            this.getListProvince.Text = "Список";
            this.getListProvince.UseVisualStyleBackColor = true;
            this.getListProvince.Click += new System.EventHandler(this.getListProvince_Click);
            // 
            // chart1
            // 
            chartArea2.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.Interval = 0D;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX2.CustomLabels.Add(customLabel2);
            chartArea2.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.StripLines.Add(stripLine2);
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Arrow;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 72);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Black;
            series2.Legend = "Legend1";
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "Начальный график";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(769, 639);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // infoOutPut
            // 
            this.infoOutPut.Location = new System.Drawing.Point(781, 7);
            this.infoOutPut.Multiline = true;
            this.infoOutPut.Name = "infoOutPut";
            this.infoOutPut.ReadOnly = true;
            this.infoOutPut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoOutPut.Size = new System.Drawing.Size(404, 177);
            this.infoOutPut.TabIndex = 10;
            // 
            // paintForel
            // 
            this.paintForel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.paintForel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.paintForel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.paintForel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paintForel.Location = new System.Drawing.Point(164, 38);
            this.paintForel.Name = "paintForel";
            this.paintForel.Size = new System.Drawing.Size(121, 23);
            this.paintForel.TabIndex = 14;
            this.paintForel.Text = "Форель";
            this.paintForel.UseVisualStyleBackColor = true;
            this.paintForel.Click += new System.EventHandler(this.paintForel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumGrid,
            this.NameRows,
            this.Faq1,
            this.Faq2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(781, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(404, 442);
            this.dataGridView1.TabIndex = 15;
            // 
            // NumGrid
            // 
            this.NumGrid.HeaderText = "№";
            this.NumGrid.Name = "NumGrid";
            this.NumGrid.ReadOnly = true;
            this.NumGrid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameRows
            // 
            this.NameRows.HeaderText = "Район";
            this.NameRows.Name = "NameRows";
            this.NameRows.ReadOnly = true;
            this.NameRows.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Faq1
            // 
            this.Faq1.FillWeight = 35.7868F;
            this.Faq1.HeaderText = "NameФактор1";
            this.Faq1.Name = "Faq1";
            this.Faq1.ReadOnly = true;
            this.Faq1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Faq2
            // 
            this.Faq2.FillWeight = 35.7868F;
            this.Faq2.HeaderText = "NameФактор2";
            this.Faq2.Name = "Faq2";
            this.Faq2.ReadOnly = true;
            this.Faq2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // numberForel
            // 
            this.numberForel.Location = new System.Drawing.Point(103, 40);
            this.numberForel.Name = "numberForel";
            this.numberForel.Size = new System.Drawing.Size(50, 20);
            this.numberForel.TabIndex = 16;
            this.numberForel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberForel_KeyPress);
            this.numberForel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numberForel_KeyUp);
            // 
            // radiusForel
            // 
            this.radiusForel.Location = new System.Drawing.Point(30, 40);
            this.radiusForel.Name = "radiusForel";
            this.radiusForel.Size = new System.Drawing.Size(38, 20);
            this.radiusForel.TabIndex = 17;
            this.radiusForel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusForel_KeyPress);
            this.radiusForel.KeyUp += new System.Windows.Forms.KeyEventHandler(this.radiusForel_KeyUp);
            // 
            // Radius_label
            // 
            this.Radius_label.AutoSize = true;
            this.Radius_label.Location = new System.Drawing.Point(6, 43);
            this.Radius_label.Name = "Radius_label";
            this.Radius_label.Size = new System.Drawing.Size(21, 13);
            this.Radius_label.TabIndex = 18;
            this.Radius_label.Text = "R=";
            // 
            // NumberP_label
            // 
            this.NumberP_label.AutoSize = true;
            this.NumberP_label.Location = new System.Drawing.Point(76, 43);
            this.NumberP_label.Name = "NumberP_label";
            this.NumberP_label.Size = new System.Drawing.Size(27, 13);
            this.NumberP_label.TabIndex = 19;
            this.NumberP_label.Text = "№ =";
            // 
            // showPoints
            // 
            this.showPoints.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.showPoints.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.showPoints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.showPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPoints.Location = new System.Drawing.Point(503, 8);
            this.showPoints.Name = "showPoints";
            this.showPoints.Size = new System.Drawing.Size(75, 23);
            this.showPoints.TabIndex = 20;
            this.showPoints.Text = "OK";
            this.showPoints.UseVisualStyleBackColor = true;
            this.showPoints.Click += new System.EventHandler(this.showPoints_Click);
            // 
            // Xmax
            // 
            this.Xmax.Location = new System.Drawing.Point(851, 190);
            this.Xmax.Name = "Xmax";
            this.Xmax.Size = new System.Drawing.Size(100, 20);
            this.Xmax.TabIndex = 21;
            this.Xmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Xmax_KeyPress);
            // 
            // Ymax
            // 
            this.Ymax.Location = new System.Drawing.Point(851, 216);
            this.Ymax.Name = "Ymax";
            this.Ymax.Size = new System.Drawing.Size(100, 20);
            this.Ymax.TabIndex = 22;
            this.Ymax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ymax_KeyPress);
            // 
            // intervalXY
            // 
            this.intervalXY.Location = new System.Drawing.Point(851, 243);
            this.intervalXY.Name = "intervalXY";
            this.intervalXY.Size = new System.Drawing.Size(100, 20);
            this.intervalXY.TabIndex = 23;
            this.intervalXY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervalXY_KeyPress);
            // 
            // setScale
            // 
            this.setScale.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.setScale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.setScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.setScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setScale.Location = new System.Drawing.Point(973, 214);
            this.setScale.Name = "setScale";
            this.setScale.Size = new System.Drawing.Size(75, 23);
            this.setScale.TabIndex = 24;
            this.setScale.Text = "Масштаб";
            this.setScale.UseVisualStyleBackColor = true;
            this.setScale.Click += new System.EventHandler(this.setScale_Click);
            // 
            // Xmax_label
            // 
            this.Xmax_label.AutoSize = true;
            this.Xmax_label.Location = new System.Drawing.Point(781, 190);
            this.Xmax_label.Name = "Xmax_label";
            this.Xmax_label.Size = new System.Drawing.Size(36, 13);
            this.Xmax_label.TabIndex = 25;
            this.Xmax_label.Text = "X max";
            // 
            // Ymax_label
            // 
            this.Ymax_label.AutoSize = true;
            this.Ymax_label.Location = new System.Drawing.Point(781, 216);
            this.Ymax_label.Name = "Ymax_label";
            this.Ymax_label.Size = new System.Drawing.Size(36, 13);
            this.Ymax_label.TabIndex = 26;
            this.Ymax_label.Text = "Y max";
            // 
            // intervalXY_label
            // 
            this.intervalXY_label.AutoSize = true;
            this.intervalXY_label.Location = new System.Drawing.Point(781, 243);
            this.intervalXY_label.Name = "intervalXY_label";
            this.intervalXY_label.Size = new System.Drawing.Size(56, 13);
            this.intervalXY_label.TabIndex = 27;
            this.intervalXY_label.Text = "Интервал";
            // 
            // initData
            // 
            this.initData.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.initData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.initData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.initData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.initData.Location = new System.Drawing.Point(692, 8);
            this.initData.Name = "initData";
            this.initData.Size = new System.Drawing.Size(83, 52);
            this.initData.TabIndex = 28;
            this.initData.Text = "Исходные данные";
            this.initData.UseVisualStyleBackColor = true;
            this.initData.Click += new System.EventHandler(this.initData_Click);
            // 
            // ClusterOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1190, 714);
            this.Controls.Add(this.initData);
            this.Controls.Add(this.intervalXY_label);
            this.Controls.Add(this.Ymax_label);
            this.Controls.Add(this.Xmax_label);
            this.Controls.Add(this.setScale);
            this.Controls.Add(this.intervalXY);
            this.Controls.Add(this.Ymax);
            this.Controls.Add(this.Xmax);
            this.Controls.Add(this.showPoints);
            this.Controls.Add(this.NumberP_label);
            this.Controls.Add(this.Radius_label);
            this.Controls.Add(this.radiusForel);
            this.Controls.Add(this.numberForel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.paintForel);
            this.Controls.Add(this.infoOutPut);
            this.Controls.Add(this.getListProvince);
            this.Controls.Add(this.factorY);
            this.Controls.Add(this.factorX);
            this.Controls.Add(this.factorY_label);
            this.Controls.Add(this.factorX_label);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClusterOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кластерный Анализ";
            this.Load += new System.EventHandler(this.Cluster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label factorX_label;
        private System.Windows.Forms.Label factorY_label;
        private System.Windows.Forms.ComboBox factorX;
        private System.Windows.Forms.ComboBox factorY;
        private System.Windows.Forms.Button getListProvince;
        private System.Windows.Forms.TextBox infoOutPut;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button paintForel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox numberForel;
        private System.Windows.Forms.TextBox radiusForel;
        private System.Windows.Forms.Label Radius_label;
        private System.Windows.Forms.Label NumberP_label;
        private System.Windows.Forms.Button showPoints;
        private System.Windows.Forms.TextBox Xmax;
        private System.Windows.Forms.TextBox Ymax;
        private System.Windows.Forms.TextBox intervalXY;
        private System.Windows.Forms.Button setScale;
        private System.Windows.Forms.Label Xmax_label;
        private System.Windows.Forms.Label Ymax_label;
        private System.Windows.Forms.Label intervalXY_label;
        private System.Windows.Forms.Button initData;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faq1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faq2;
    }
}

