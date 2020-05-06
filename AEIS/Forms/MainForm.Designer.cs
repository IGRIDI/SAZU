namespace AEIS.Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPlotMain = new System.Windows.Forms.Button();
            this.comboBoxFunctions = new System.Windows.Forms.ComboBox();
            this.labelFunction = new System.Windows.Forms.Label();
            this.labelResources = new System.Windows.Forms.Label();
            this.labelMinEfficiency = new System.Windows.Forms.Label();
            this.labelMainTime = new System.Windows.Forms.Label();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownE = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.dataGridViewKNotes = new System.Windows.Forms.DataGridView();
            this.labelBottom = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.buttonExtraFunctions = new System.Windows.Forms.Button();
            this.labelProject = new System.Windows.Forms.Label();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.buttonPlotAdvanced = new System.Windows.Forms.Button();
            this.groupBoxProject = new System.Windows.Forms.GroupBox();
            this.buttonRemoveProject = new System.Windows.Forms.Button();
            this.buttonViewPoints = new System.Windows.Forms.Button();
            this.buttonCreateProject = new System.Windows.Forms.Button();
            this.chartAdvanced = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageRisk = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelSystemRisk = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.textBoxSystemRisk = new System.Windows.Forms.TextBox();
            this.labelModeDescription = new System.Windows.Forms.Label();
            this.buttonCalcSystemRisk = new System.Windows.Forms.Button();
            this.trackBarFailureCost = new System.Windows.Forms.TrackBar();
            this.textBoxFailureCostVector = new System.Windows.Forms.TextBox();
            this.numericUpDownFailureCost = new System.Windows.Forms.NumericUpDown();
            this.labelFailureCostVector = new System.Windows.Forms.Label();
            this.buttonAddFailureCost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKNotes)).BeginInit();
            this.panelMain.SuspendLayout();
            this.tabPageAdvanced.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            this.groupBoxProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAdvanced)).BeginInit();
            this.tabPageRisk.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFailureCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFailureCost)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea1);
            this.chartMain.Location = new System.Drawing.Point(332, 6);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chartMain.Series.Add(series1);
            this.chartMain.Size = new System.Drawing.Size(560, 292);
            this.chartMain.SuppressExceptions = true;
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart";
            this.chartMain.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            // 
            // buttonPlotMain
            // 
            this.buttonPlotMain.Location = new System.Drawing.Point(172, 106);
            this.buttonPlotMain.Name = "buttonPlotMain";
            this.buttonPlotMain.Size = new System.Drawing.Size(148, 23);
            this.buttonPlotMain.TabIndex = 1;
            this.buttonPlotMain.Text = "Построить график";
            this.buttonPlotMain.UseVisualStyleBackColor = true;
            this.buttonPlotMain.Click += new System.EventHandler(this.buttonPlotMain_Click);
            // 
            // comboBoxFunctions
            // 
            this.comboBoxFunctions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFunctions.FormattingEnabled = true;
            this.comboBoxFunctions.Location = new System.Drawing.Point(192, 0);
            this.comboBoxFunctions.Name = "comboBoxFunctions";
            this.comboBoxFunctions.Size = new System.Drawing.Size(128, 21);
            this.comboBoxFunctions.TabIndex = 2;
            this.comboBoxFunctions.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunctions_SelectedIndexChanged);
            // 
            // labelFunction
            // 
            this.labelFunction.AutoSize = true;
            this.labelFunction.Location = new System.Drawing.Point(0, 3);
            this.labelFunction.Name = "labelFunction";
            this.labelFunction.Size = new System.Drawing.Size(56, 13);
            this.labelFunction.TabIndex = 3;
            this.labelFunction.Text = "Функция:";
            // 
            // labelResources
            // 
            this.labelResources.AutoSize = true;
            this.labelResources.Location = new System.Drawing.Point(0, 29);
            this.labelResources.Name = "labelResources";
            this.labelResources.Size = new System.Drawing.Size(132, 13);
            this.labelResources.TabIndex = 4;
            this.labelResources.Text = "Остаточные ресурсы (k):";
            // 
            // labelMinEfficiency
            // 
            this.labelMinEfficiency.AutoSize = true;
            this.labelMinEfficiency.Location = new System.Drawing.Point(0, 55);
            this.labelMinEfficiency.Name = "labelMinEfficiency";
            this.labelMinEfficiency.Size = new System.Drawing.Size(186, 13);
            this.labelMinEfficiency.TabIndex = 7;
            this.labelMinEfficiency.Text = "Минимальная эффективность (E0):";
            // 
            // labelMainTime
            // 
            this.labelMainTime.AutoSize = true;
            this.labelMainTime.Location = new System.Drawing.Point(0, 82);
            this.labelMainTime.Name = "labelMainTime";
            this.labelMainTime.Size = new System.Drawing.Size(172, 13);
            this.labelMainTime.TabIndex = 9;
            this.labelMainTime.Text = "Время использования системы:";
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.DecimalPlaces = 2;
            this.numericUpDownK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownK.Location = new System.Drawing.Point(192, 27);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(128, 20);
            this.numericUpDownK.TabIndex = 10;
            // 
            // numericUpDownE
            // 
            this.numericUpDownE.DecimalPlaces = 2;
            this.numericUpDownE.Location = new System.Drawing.Point(192, 53);
            this.numericUpDownE.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownE.Name = "numericUpDownE";
            this.numericUpDownE.Size = new System.Drawing.Size(128, 20);
            this.numericUpDownE.TabIndex = 11;
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.Location = new System.Drawing.Point(192, 80);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownTime.TabIndex = 12;
            this.numericUpDownTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTime.ValueChanged += new System.EventHandler(this.numericUpDownTime_ValueChanged);
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Items.AddRange(new object[] {
            "день",
            "месяц",
            "год"});
            this.comboBoxTime.Location = new System.Drawing.Point(255, 79);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(65, 21);
            this.comboBoxTime.TabIndex = 13;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageMain);
            this.tabControl.Controls.Add(this.tabPageAdvanced);
            this.tabControl.Controls.Add(this.tabPageRisk);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(906, 356);
            this.tabControl.TabIndex = 14;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(this.dataGridViewKNotes);
            this.tabPageMain.Controls.Add(this.labelBottom);
            this.tabPageMain.Controls.Add(this.panelMain);
            this.tabPageMain.Controls.Add(this.chartMain);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(898, 330);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Основной функционал";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // dataGridViewKNotes
            // 
            this.dataGridViewKNotes.AllowUserToAddRows = false;
            this.dataGridViewKNotes.AllowUserToDeleteRows = false;
            this.dataGridViewKNotes.AllowUserToResizeColumns = false;
            this.dataGridViewKNotes.AllowUserToResizeRows = false;
            this.dataGridViewKNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewKNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewKNotes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewKNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKNotes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKNotes.Location = new System.Drawing.Point(9, 142);
            this.dataGridViewKNotes.Name = "dataGridViewKNotes";
            this.dataGridViewKNotes.ReadOnly = true;
            this.dataGridViewKNotes.RowHeadersVisible = false;
            this.dataGridViewKNotes.ShowEditingIcon = false;
            this.dataGridViewKNotes.Size = new System.Drawing.Size(317, 156);
            this.dataGridViewKNotes.TabIndex = 16;
            this.dataGridViewKNotes.SelectionChanged += new System.EventHandler(this.dataGridViewKNotes_SelectionChanged);
            // 
            // labelBottom
            // 
            this.labelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBottom.Location = new System.Drawing.Point(6, 301);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(886, 23);
            this.labelBottom.TabIndex = 15;
            this.labelBottom.Text = "Моделирование производится на основании сложной системы с умеренным устареванием," +
    " имеющую среднюю стоимость отказа";
            this.labelBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.labelFunction);
            this.panelMain.Controls.Add(this.numericUpDownE);
            this.panelMain.Controls.Add(this.numericUpDownK);
            this.panelMain.Controls.Add(this.labelMainTime);
            this.panelMain.Controls.Add(this.buttonPlotMain);
            this.panelMain.Controls.Add(this.numericUpDownTime);
            this.panelMain.Controls.Add(this.comboBoxFunctions);
            this.panelMain.Controls.Add(this.labelMinEfficiency);
            this.panelMain.Controls.Add(this.labelResources);
            this.panelMain.Controls.Add(this.comboBoxTime);
            this.panelMain.Location = new System.Drawing.Point(6, 6);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(320, 130);
            this.panelMain.TabIndex = 14;
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Controls.Add(this.panelAdvanced);
            this.tabPageAdvanced.Controls.Add(this.chartAdvanced);
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvanced.Size = new System.Drawing.Size(898, 330);
            this.tabPageAdvanced.TabIndex = 1;
            this.tabPageAdvanced.Text = "Расширенный функционал";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.Controls.Add(this.buttonExtraFunctions);
            this.panelAdvanced.Controls.Add(this.labelProject);
            this.panelAdvanced.Controls.Add(this.comboBoxProjects);
            this.panelAdvanced.Controls.Add(this.buttonPlotAdvanced);
            this.panelAdvanced.Controls.Add(this.groupBoxProject);
            this.panelAdvanced.Location = new System.Drawing.Point(6, 6);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(320, 160);
            this.panelAdvanced.TabIndex = 7;
            // 
            // buttonExtraFunctions
            // 
            this.buttonExtraFunctions.Enabled = false;
            this.buttonExtraFunctions.Location = new System.Drawing.Point(163, 126);
            this.buttonExtraFunctions.Name = "buttonExtraFunctions";
            this.buttonExtraFunctions.Size = new System.Drawing.Size(157, 34);
            this.buttonExtraFunctions.TabIndex = 5;
            this.buttonExtraFunctions.Text = "Дополнительные функции";
            this.buttonExtraFunctions.UseVisualStyleBackColor = true;
            this.buttonExtraFunctions.Click += new System.EventHandler(this.buttonExtraFunctions_Click);
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(0, 0);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(47, 13);
            this.labelProject.TabIndex = 0;
            this.labelProject.Text = "Проект:";
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(0, 16);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(320, 21);
            this.comboBoxProjects.TabIndex = 1;
            this.comboBoxProjects.SelectedIndexChanged += new System.EventHandler(this.comboBoxProjects_SelectedIndexChanged);
            // 
            // buttonPlotAdvanced
            // 
            this.buttonPlotAdvanced.Enabled = false;
            this.buttonPlotAdvanced.Location = new System.Drawing.Point(0, 126);
            this.buttonPlotAdvanced.Name = "buttonPlotAdvanced";
            this.buttonPlotAdvanced.Size = new System.Drawing.Size(157, 34);
            this.buttonPlotAdvanced.TabIndex = 4;
            this.buttonPlotAdvanced.Text = "Построить график";
            this.buttonPlotAdvanced.UseVisualStyleBackColor = true;
            this.buttonPlotAdvanced.Click += new System.EventHandler(this.buttonPlotAdvanced_Click);
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Controls.Add(this.buttonRemoveProject);
            this.groupBoxProject.Controls.Add(this.buttonViewPoints);
            this.groupBoxProject.Controls.Add(this.buttonCreateProject);
            this.groupBoxProject.Location = new System.Drawing.Point(0, 43);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Size = new System.Drawing.Size(320, 77);
            this.groupBoxProject.TabIndex = 2;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "Работа с проектом";
            // 
            // buttonRemoveProject
            // 
            this.buttonRemoveProject.Enabled = false;
            this.buttonRemoveProject.Location = new System.Drawing.Point(161, 19);
            this.buttonRemoveProject.Name = "buttonRemoveProject";
            this.buttonRemoveProject.Size = new System.Drawing.Size(153, 23);
            this.buttonRemoveProject.TabIndex = 1;
            this.buttonRemoveProject.Text = "Удалить проект";
            this.buttonRemoveProject.UseVisualStyleBackColor = true;
            this.buttonRemoveProject.Click += new System.EventHandler(this.buttonRemoveProject_Click);
            // 
            // buttonViewPoints
            // 
            this.buttonViewPoints.Enabled = false;
            this.buttonViewPoints.Location = new System.Drawing.Point(6, 48);
            this.buttonViewPoints.Name = "buttonViewPoints";
            this.buttonViewPoints.Size = new System.Drawing.Size(308, 23);
            this.buttonViewPoints.TabIndex = 2;
            this.buttonViewPoints.Text = "Просмотреть добавленные точки";
            this.buttonViewPoints.UseVisualStyleBackColor = true;
            this.buttonViewPoints.Click += new System.EventHandler(this.buttonViewPoints_Click);
            // 
            // buttonCreateProject
            // 
            this.buttonCreateProject.Location = new System.Drawing.Point(6, 19);
            this.buttonCreateProject.Name = "buttonCreateProject";
            this.buttonCreateProject.Size = new System.Drawing.Size(149, 23);
            this.buttonCreateProject.TabIndex = 0;
            this.buttonCreateProject.Text = "Создать новый проект";
            this.buttonCreateProject.UseVisualStyleBackColor = true;
            this.buttonCreateProject.Click += new System.EventHandler(this.buttonCreateProject_Click);
            // 
            // chartAdvanced
            // 
            this.chartAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartAdvanced.ChartAreas.Add(chartArea2);
            this.chartAdvanced.Location = new System.Drawing.Point(332, 6);
            this.chartAdvanced.Name = "chartAdvanced";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chartAdvanced.Series.Add(series2);
            this.chartAdvanced.Size = new System.Drawing.Size(560, 318);
            this.chartAdvanced.SuppressExceptions = true;
            this.chartAdvanced.TabIndex = 6;
            this.chartAdvanced.Text = "chart";
            this.chartAdvanced.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.chart_MouseWheel);
            // 
            // tabPageRisk
            // 
            this.tabPageRisk.Controls.Add(this.panel1);
            this.tabPageRisk.Location = new System.Drawing.Point(4, 22);
            this.tabPageRisk.Name = "tabPageRisk";
            this.tabPageRisk.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRisk.Size = new System.Drawing.Size(898, 330);
            this.tabPageRisk.TabIndex = 2;
            this.tabPageRisk.Text = "Оценка риска системы";
            this.tabPageRisk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.labelMode);
            this.panel1.Controls.Add(this.labelSystemRisk);
            this.panel1.Controls.Add(this.comboBoxMode);
            this.panel1.Controls.Add(this.textBoxSystemRisk);
            this.panel1.Controls.Add(this.labelModeDescription);
            this.panel1.Controls.Add(this.buttonCalcSystemRisk);
            this.panel1.Controls.Add(this.trackBarFailureCost);
            this.panel1.Controls.Add(this.textBoxFailureCostVector);
            this.panel1.Controls.Add(this.numericUpDownFailureCost);
            this.panel1.Controls.Add(this.labelFailureCostVector);
            this.panel1.Controls.Add(this.buttonAddFailureCost);
            this.panel1.Location = new System.Drawing.Point(349, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 269);
            this.panel1.TabIndex = 11;
            // 
            // labelMode
            // 
            this.labelMode.AutoSize = true;
            this.labelMode.Location = new System.Drawing.Point(0, 3);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(130, 13);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Режим работы системы";
            // 
            // labelSystemRisk
            // 
            this.labelSystemRisk.AutoSize = true;
            this.labelSystemRisk.Location = new System.Drawing.Point(0, 252);
            this.labelSystemRisk.Name = "labelSystemRisk";
            this.labelSystemRisk.Size = new System.Drawing.Size(83, 13);
            this.labelSystemRisk.TabIndex = 10;
            this.labelSystemRisk.Text = "Риск системы:";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBoxMode.Location = new System.Drawing.Point(136, 0);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(64, 21);
            this.comboBoxMode.TabIndex = 1;
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            // 
            // textBoxSystemRisk
            // 
            this.textBoxSystemRisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSystemRisk.Location = new System.Drawing.Point(89, 249);
            this.textBoxSystemRisk.Name = "textBoxSystemRisk";
            this.textBoxSystemRisk.ReadOnly = true;
            this.textBoxSystemRisk.Size = new System.Drawing.Size(111, 20);
            this.textBoxSystemRisk.TabIndex = 9;
            // 
            // labelModeDescription
            // 
            this.labelModeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelModeDescription.Location = new System.Drawing.Point(0, 24);
            this.labelModeDescription.Name = "labelModeDescription";
            this.labelModeDescription.Size = new System.Drawing.Size(200, 48);
            this.labelModeDescription.TabIndex = 2;
            this.labelModeDescription.Text = "Режим A используется при критических последствиях отказа";
            this.labelModeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCalcSystemRisk
            // 
            this.buttonCalcSystemRisk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCalcSystemRisk.Location = new System.Drawing.Point(0, 220);
            this.buttonCalcSystemRisk.Name = "buttonCalcSystemRisk";
            this.buttonCalcSystemRisk.Size = new System.Drawing.Size(200, 23);
            this.buttonCalcSystemRisk.TabIndex = 8;
            this.buttonCalcSystemRisk.Text = "Рассчитать";
            this.buttonCalcSystemRisk.UseVisualStyleBackColor = true;
            this.buttonCalcSystemRisk.Click += new System.EventHandler(this.buttonCalcSystemRisk_Click);
            // 
            // trackBarFailureCost
            // 
            this.trackBarFailureCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFailureCost.LargeChange = 50;
            this.trackBarFailureCost.Location = new System.Drawing.Point(0, 75);
            this.trackBarFailureCost.Maximum = 1000;
            this.trackBarFailureCost.Name = "trackBarFailureCost";
            this.trackBarFailureCost.Size = new System.Drawing.Size(200, 45);
            this.trackBarFailureCost.TabIndex = 3;
            this.trackBarFailureCost.TickFrequency = 50;
            this.trackBarFailureCost.ValueChanged += new System.EventHandler(this.trackBarFailureCost_ValueChanged);
            // 
            // textBoxFailureCostVector
            // 
            this.textBoxFailureCostVector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFailureCostVector.Location = new System.Drawing.Point(0, 194);
            this.textBoxFailureCostVector.Name = "textBoxFailureCostVector";
            this.textBoxFailureCostVector.Size = new System.Drawing.Size(200, 20);
            this.textBoxFailureCostVector.TabIndex = 7;
            // 
            // numericUpDownFailureCost
            // 
            this.numericUpDownFailureCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownFailureCost.DecimalPlaces = 2;
            this.numericUpDownFailureCost.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownFailureCost.Location = new System.Drawing.Point(0, 126);
            this.numericUpDownFailureCost.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFailureCost.Name = "numericUpDownFailureCost";
            this.numericUpDownFailureCost.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownFailureCost.TabIndex = 4;
            this.numericUpDownFailureCost.ValueChanged += new System.EventHandler(this.numericUpDownFailureCost_ValueChanged);
            // 
            // labelFailureCostVector
            // 
            this.labelFailureCostVector.AutoSize = true;
            this.labelFailureCostVector.Location = new System.Drawing.Point(0, 178);
            this.labelFailureCostVector.Name = "labelFailureCostVector";
            this.labelFailureCostVector.Size = new System.Drawing.Size(138, 13);
            this.labelFailureCostVector.TabIndex = 6;
            this.labelFailureCostVector.Text = "Вектор стоимости отказа";
            // 
            // buttonAddFailureCost
            // 
            this.buttonAddFailureCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFailureCost.Location = new System.Drawing.Point(0, 152);
            this.buttonAddFailureCost.Name = "buttonAddFailureCost";
            this.buttonAddFailureCost.Size = new System.Drawing.Size(200, 23);
            this.buttonAddFailureCost.TabIndex = 5;
            this.buttonAddFailureCost.Text = "Добавить";
            this.buttonAddFailureCost.UseVisualStyleBackColor = true;
            this.buttonAddFailureCost.Click += new System.EventHandler(this.buttonAddFailureCost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 380);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Система анализа заложенного устаревания";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKNotes)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.tabPageAdvanced.ResumeLayout(false);
            this.panelAdvanced.ResumeLayout(false);
            this.panelAdvanced.PerformLayout();
            this.groupBoxProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAdvanced)).EndInit();
            this.tabPageRisk.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFailureCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFailureCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.Button buttonPlotMain;
        private System.Windows.Forms.ComboBox comboBoxFunctions;
        private System.Windows.Forms.Label labelFunction;
        private System.Windows.Forms.Label labelResources;
        private System.Windows.Forms.Label labelMinEfficiency;
        private System.Windows.Forms.Label labelMainTime;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.NumericUpDown numericUpDownE;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.ComboBox comboBoxProjects;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.GroupBox groupBoxProject;
        private System.Windows.Forms.Button buttonViewPoints;
        private System.Windows.Forms.Button buttonRemoveProject;
        private System.Windows.Forms.Button buttonCreateProject;
        private System.Windows.Forms.Button buttonPlotAdvanced;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAdvanced;
        private System.Windows.Forms.TabPage tabPageRisk;
        private System.Windows.Forms.Label labelSystemRisk;
        private System.Windows.Forms.TextBox textBoxSystemRisk;
        private System.Windows.Forms.Button buttonCalcSystemRisk;
        private System.Windows.Forms.TextBox textBoxFailureCostVector;
        private System.Windows.Forms.Label labelFailureCostVector;
        private System.Windows.Forms.Button buttonAddFailureCost;
        private System.Windows.Forms.NumericUpDown numericUpDownFailureCost;
        private System.Windows.Forms.TrackBar trackBarFailureCost;
        private System.Windows.Forms.Label labelModeDescription;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Button buttonExtraFunctions;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBottom;
        private System.Windows.Forms.DataGridView dataGridViewKNotes;
    }
}

