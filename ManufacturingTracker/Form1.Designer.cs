namespace ManufacturingTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            btnExport = new Button();
            maintable_layout = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            tableLayoutPanelKPI = new TableLayoutPanel();
            panelDefect = new Panel();
            lblTotalDefects = new Label();
            titleTotalDefects = new Label();
            panelProduction = new Panel();
            lblTotalProduction = new Label();
            labelProduction = new Label();
            panelDowntime = new Panel();
            lblTotalDowntime = new Label();
            labeldowntime = new Label();
            panelRate = new Panel();
            lblDefectRate = new Label();
            titleDefectrate = new Label();
            tableLayoutPanel_row2 = new TableLayoutPanel();
            panelProductionInput = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDefect = new TextBox();
            labelproductdowntime = new Label();
            labelDefect = new Label();
            txtDowntime = new TextBox();
            txtQuantity = new TextBox();
            txtProduct = new TextBox();
            labelQuantity = new Label();
            labelProductName = new Label();
            label5 = new Label();
            panelAnalysis = new Panel();
            sourceGenCartesianChart1 = new LiveChartsGeneratedCode.SourceGenCartesianChart();
            panel2 = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            maintable_layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanelKPI.SuspendLayout();
            panelDefect.SuspendLayout();
            panelProduction.SuspendLayout();
            panelDowntime.SuspendLayout();
            panelRate.SuspendLayout();
            tableLayoutPanel_row2.SuspendLayout();
            panelProductionInput.SuspendLayout();
            panelAnalysis.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExport.Location = new Point(4, -1);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(108, 28);
            btnExport.TabIndex = 14;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // maintable_layout
            // 
            maintable_layout.ColumnCount = 1;
            maintable_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            maintable_layout.Controls.Add(dataGridView1, 0, 3);
            maintable_layout.Controls.Add(tableLayoutPanelKPI, 0, 0);
            maintable_layout.Controls.Add(tableLayoutPanel_row2, 0, 1);
            maintable_layout.Controls.Add(panel2, 0, 2);
            maintable_layout.Dock = DockStyle.Fill;
            maintable_layout.Location = new Point(0, 0);
            maintable_layout.Name = "maintable_layout";
            maintable_layout.RowCount = 4;
            maintable_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6511631F));
            maintable_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 34.1860466F));
            maintable_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 4.65116262F));
            maintable_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5116272F));
            maintable_layout.Size = new Size(1014, 785);
            maintable_layout.TabIndex = 22;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = SystemColors.ActiveBorder;
            dataGridView1.Location = new Point(3, 422);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1008, 360);
            dataGridView1.TabIndex = 25;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tableLayoutPanelKPI
            // 
            tableLayoutPanelKPI.ColumnCount = 4;
            tableLayoutPanelKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelKPI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanelKPI.Controls.Add(panelDefect, 0, 0);
            tableLayoutPanelKPI.Controls.Add(panelProduction, 0, 0);
            tableLayoutPanelKPI.Controls.Add(panelDowntime, 3, 0);
            tableLayoutPanelKPI.Controls.Add(panelRate, 2, 0);
            tableLayoutPanelKPI.Dock = DockStyle.Top;
            tableLayoutPanelKPI.Location = new Point(3, 3);
            tableLayoutPanelKPI.Name = "tableLayoutPanelKPI";
            tableLayoutPanelKPI.RowCount = 1;
            tableLayoutPanelKPI.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelKPI.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelKPI.Size = new Size(1008, 109);
            tableLayoutPanelKPI.TabIndex = 21;
            // 
            // panelDefect
            // 
            panelDefect.BackColor = Color.WhiteSmoke;
            panelDefect.BorderStyle = BorderStyle.FixedSingle;
            panelDefect.Controls.Add(lblTotalDefects);
            panelDefect.Controls.Add(titleTotalDefects);
            panelDefect.Dock = DockStyle.Fill;
            panelDefect.Location = new Point(255, 3);
            panelDefect.Name = "panelDefect";
            panelDefect.Size = new Size(246, 103);
            panelDefect.TabIndex = 23;
            // 
            // lblTotalDefects
            // 
            lblTotalDefects.Dock = DockStyle.Fill;
            lblTotalDefects.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDefects.ForeColor = Color.Red;
            lblTotalDefects.Location = new Point(0, 25);
            lblTotalDefects.Name = "lblTotalDefects";
            lblTotalDefects.Size = new Size(244, 76);
            lblTotalDefects.TabIndex = 3;
            lblTotalDefects.Text = "label7";
            lblTotalDefects.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleTotalDefects
            // 
            titleTotalDefects.Dock = DockStyle.Top;
            titleTotalDefects.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleTotalDefects.ForeColor = Color.DimGray;
            titleTotalDefects.Location = new Point(0, 0);
            titleTotalDefects.Name = "titleTotalDefects";
            titleTotalDefects.Size = new Size(244, 25);
            titleTotalDefects.TabIndex = 2;
            titleTotalDefects.Text = "Defects";
            titleTotalDefects.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelProduction
            // 
            panelProduction.BackColor = Color.WhiteSmoke;
            panelProduction.BorderStyle = BorderStyle.FixedSingle;
            panelProduction.Controls.Add(lblTotalProduction);
            panelProduction.Controls.Add(labelProduction);
            panelProduction.Dock = DockStyle.Fill;
            panelProduction.Location = new Point(3, 3);
            panelProduction.Name = "panelProduction";
            panelProduction.Size = new Size(246, 103);
            panelProduction.TabIndex = 22;
            // 
            // lblTotalProduction
            // 
            lblTotalProduction.Dock = DockStyle.Fill;
            lblTotalProduction.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalProduction.ForeColor = Color.Green;
            lblTotalProduction.Location = new Point(0, 25);
            lblTotalProduction.Name = "lblTotalProduction";
            lblTotalProduction.Size = new Size(244, 76);
            lblTotalProduction.TabIndex = 1;
            lblTotalProduction.Text = "label7";
            lblTotalProduction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelProduction
            // 
            labelProduction.Dock = DockStyle.Top;
            labelProduction.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelProduction.ForeColor = Color.DimGray;
            labelProduction.Location = new Point(0, 0);
            labelProduction.Name = "labelProduction";
            labelProduction.Size = new Size(244, 25);
            labelProduction.TabIndex = 0;
            labelProduction.Text = "Production";
            labelProduction.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDowntime
            // 
            panelDowntime.BackColor = Color.WhiteSmoke;
            panelDowntime.BorderStyle = BorderStyle.FixedSingle;
            panelDowntime.Controls.Add(lblTotalDowntime);
            panelDowntime.Controls.Add(labeldowntime);
            panelDowntime.Dock = DockStyle.Fill;
            panelDowntime.Location = new Point(759, 3);
            panelDowntime.Name = "panelDowntime";
            panelDowntime.Size = new Size(246, 103);
            panelDowntime.TabIndex = 21;
            // 
            // lblTotalDowntime
            // 
            lblTotalDowntime.Dock = DockStyle.Fill;
            lblTotalDowntime.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDowntime.ForeColor = Color.MediumBlue;
            lblTotalDowntime.Location = new Point(0, 25);
            lblTotalDowntime.Name = "lblTotalDowntime";
            lblTotalDowntime.Size = new Size(244, 76);
            lblTotalDowntime.TabIndex = 7;
            lblTotalDowntime.Text = "label7";
            lblTotalDowntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labeldowntime
            // 
            labeldowntime.Dock = DockStyle.Top;
            labeldowntime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeldowntime.ForeColor = Color.DimGray;
            labeldowntime.Location = new Point(0, 0);
            labeldowntime.Name = "labeldowntime";
            labeldowntime.Size = new Size(244, 25);
            labeldowntime.TabIndex = 6;
            labeldowntime.Text = "Downtime";
            labeldowntime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelRate
            // 
            panelRate.BackColor = Color.WhiteSmoke;
            panelRate.BorderStyle = BorderStyle.FixedSingle;
            panelRate.Controls.Add(lblDefectRate);
            panelRate.Controls.Add(titleDefectrate);
            panelRate.Dock = DockStyle.Fill;
            panelRate.Location = new Point(507, 3);
            panelRate.Name = "panelRate";
            panelRate.Size = new Size(246, 103);
            panelRate.TabIndex = 18;
            // 
            // lblDefectRate
            // 
            lblDefectRate.Dock = DockStyle.Fill;
            lblDefectRate.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDefectRate.ForeColor = Color.Orange;
            lblDefectRate.Location = new Point(0, 25);
            lblDefectRate.Name = "lblDefectRate";
            lblDefectRate.Size = new Size(244, 76);
            lblDefectRate.TabIndex = 5;
            lblDefectRate.Text = "label7";
            lblDefectRate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleDefectrate
            // 
            titleDefectrate.Dock = DockStyle.Top;
            titleDefectrate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            titleDefectrate.ForeColor = Color.DimGray;
            titleDefectrate.Location = new Point(0, 0);
            titleDefectrate.Name = "titleDefectrate";
            titleDefectrate.Size = new Size(244, 25);
            titleDefectrate.TabIndex = 4;
            titleDefectrate.Text = "Defect Rate";
            titleDefectrate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel_row2
            // 
            tableLayoutPanel_row2.ColumnCount = 2;
            tableLayoutPanel_row2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel_row2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel_row2.Controls.Add(panelProductionInput, 1, 0);
            tableLayoutPanel_row2.Controls.Add(panelAnalysis, 0, 0);
            tableLayoutPanel_row2.Dock = DockStyle.Fill;
            tableLayoutPanel_row2.Location = new Point(3, 118);
            tableLayoutPanel_row2.Name = "tableLayoutPanel_row2";
            tableLayoutPanel_row2.RowCount = 1;
            tableLayoutPanel_row2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_row2.Size = new Size(1008, 262);
            tableLayoutPanel_row2.TabIndex = 23;
            // 
            // panelProductionInput
            // 
            panelProductionInput.BackColor = Color.WhiteSmoke;
            panelProductionInput.BorderStyle = BorderStyle.FixedSingle;
            panelProductionInput.Controls.Add(btnDelete);
            panelProductionInput.Controls.Add(btnUpdate);
            panelProductionInput.Controls.Add(btnAdd);
            panelProductionInput.Controls.Add(txtDefect);
            panelProductionInput.Controls.Add(labelproductdowntime);
            panelProductionInput.Controls.Add(labelDefect);
            panelProductionInput.Controls.Add(txtDowntime);
            panelProductionInput.Controls.Add(txtQuantity);
            panelProductionInput.Controls.Add(txtProduct);
            panelProductionInput.Controls.Add(labelQuantity);
            panelProductionInput.Controls.Add(labelProductName);
            panelProductionInput.Controls.Add(label5);
            panelProductionInput.Dock = DockStyle.Fill;
            panelProductionInput.Location = new Point(607, 3);
            panelProductionInput.Name = "panelProductionInput";
            panelProductionInput.Size = new Size(398, 256);
            panelProductionInput.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(260, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 28);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(133, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 30);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.WindowText;
            btnAdd.Location = new Point(6, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 30);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add record";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDefect
            // 
            txtDefect.Location = new Point(146, 109);
            txtDefect.Name = "txtDefect";
            txtDefect.Size = new Size(174, 23);
            txtDefect.TabIndex = 5;
            // 
            // labelproductdowntime
            // 
            labelproductdowntime.AutoSize = true;
            labelproductdowntime.Font = new Font("Segoe UI", 9.75F);
            labelproductdowntime.Location = new Point(23, 146);
            labelproductdowntime.Name = "labelproductdowntime";
            labelproductdowntime.Size = new Size(73, 17);
            labelproductdowntime.TabIndex = 6;
            labelproductdowntime.Text = "Downtime :";
            // 
            // labelDefect
            // 
            labelDefect.AutoSize = true;
            labelDefect.Font = new Font("Segoe UI", 9.75F);
            labelDefect.Location = new Point(23, 112);
            labelDefect.Name = "labelDefect";
            labelDefect.Size = new Size(52, 17);
            labelDefect.TabIndex = 4;
            labelDefect.Text = "Defect :";
            // 
            // txtDowntime
            // 
            txtDowntime.Location = new Point(148, 143);
            txtDowntime.Name = "txtDowntime";
            txtDowntime.Size = new Size(174, 23);
            txtDowntime.TabIndex = 7;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(146, 72);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(174, 23);
            txtQuantity.TabIndex = 3;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(146, 36);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(174, 23);
            txtProduct.TabIndex = 1;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Font = new Font("Segoe UI", 9.75F);
            labelQuantity.Location = new Point(23, 76);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(63, 17);
            labelQuantity.TabIndex = 2;
            labelQuantity.Text = "Quantity :";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 9.75F);
            labelProductName.Location = new Point(24, 42);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(103, 17);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Product Name : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(140, 21);
            label5.TabIndex = 8;
            label5.Text = "Production Input";
            // 
            // panelAnalysis
            // 
            panelAnalysis.Controls.Add(sourceGenCartesianChart1);
            panelAnalysis.Dock = DockStyle.Fill;
            panelAnalysis.Location = new Point(3, 3);
            panelAnalysis.Name = "panelAnalysis";
            panelAnalysis.Size = new Size(598, 256);
            panelAnalysis.TabIndex = 20;
            // 
            // sourceGenCartesianChart1
            // 
            sourceGenCartesianChart1.AutoUpdateEnabled = true;
            sourceGenCartesianChart1.BackColor = Color.WhiteSmoke;
            sourceGenCartesianChart1.ChartTheme = null;
            sourceGenCartesianChart1.Dock = DockStyle.Fill;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = false;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            sourceGenCartesianChart1.Legend = skDefaultLegend1;
            sourceGenCartesianChart1.Location = new Point(0, 0);
            sourceGenCartesianChart1.MatchAxesScreenDataRatio = false;
            sourceGenCartesianChart1.Name = "sourceGenCartesianChart1";
            sourceGenCartesianChart1.Size = new Size(598, 256);
            sourceGenCartesianChart1.TabIndex = 0;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = false;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            sourceGenCartesianChart1.Tooltip = skDefaultTooltip1;
            sourceGenCartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
            sourceGenCartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
            // 
            // panel2
            // 
            panel2.Controls.Add(lblSearch);
            panel2.Controls.Add(btnExport);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 386);
            panel2.Name = "panel2";
            panel2.Size = new Size(1008, 30);
            panel2.TabIndex = 26;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Right;
            lblSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(746, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(107, 17);
            lblSearch.TabIndex = 12;
            lblSearch.Text = " Search Product :";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Right;
            txtSearch.Location = new Point(853, 0);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(155, 23);
            txtSearch.TabIndex = 14;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 785);
            Controls.Add(maintable_layout);
            Name = "Form1";
            Text = "Manufacturing Production Tracker";
            maintable_layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanelKPI.ResumeLayout(false);
            panelDefect.ResumeLayout(false);
            panelProduction.ResumeLayout(false);
            panelDowntime.ResumeLayout(false);
            panelRate.ResumeLayout(false);
            tableLayoutPanel_row2.ResumeLayout(false);
            panelProductionInput.ResumeLayout(false);
            panelProductionInput.PerformLayout();
            panelAnalysis.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnExport;
        private TableLayoutPanel maintable_layout;
        private TableLayoutPanel tableLayoutPanel_row2;
        private TableLayoutPanel tableLayoutPanelKPI;
        private Panel panelDefect;
        private Label lblTotalDefects;
        private Label titleTotalDefects;
        private Panel panelProduction;
        private Label lblTotalProduction;
        private Label labelProduction;
        private Panel panelDowntime;
        private Label lblTotalDowntime;
        private Label labeldowntime;
        private Panel panelRate;
        private Label lblDefectRate;
        private Label titleDefectrate;
        private Button btnDelete;
        private Label labelDefect;
        private Label labelproductdowntime;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtDowntime;
        private Label labelProductName;
        private Label labelQuantity;
        private TextBox txtProduct;
        private TextBox txtQuantity;
        private TextBox txtDefect;
        private Label label5;
        private Panel panelProductionInput;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtSearch;
        private Panel panelAnalysis;
        private LiveChartsGeneratedCode.SourceGenCartesianChart sourceGenCartesianChart1;
    }
}
