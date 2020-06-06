namespace S4_TP.Lab4
{
	partial class Lab4Form
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.tbFunction = new System.Windows.Forms.TextBox();
			this.tbXMin = new System.Windows.Forms.TextBox();
			this.tbXMax = new System.Windows.Forms.TextBox();
			this.tbXStepsNumber = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.table = new System.Windows.Forms.DataGridView();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.btnClear = new System.Windows.Forms.Button();
			this.lblFunction = new System.Windows.Forms.Label();
			this.lblXMin = new System.Windows.Forms.Label();
			this.lblXMax = new System.Windows.Forms.Label();
			this.lblXStepsNumber = new System.Windows.Forms.Label();
			this.lblXStep = new System.Windows.Forms.Label();
			this.lblXStepValue = new System.Windows.Forms.Label();
			this.chbChartSmoothing = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.SuspendLayout();
			// 
			// tbFunction
			// 
			this.tbFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbFunction.Location = new System.Drawing.Point(125, 39);
			this.tbFunction.Name = "tbFunction";
			this.tbFunction.Size = new System.Drawing.Size(104, 22);
			this.tbFunction.TabIndex = 0;
			this.tbFunction.Text = "x^3";
			// 
			// tbXMin
			// 
			this.tbXMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbXMin.Location = new System.Drawing.Point(55, 72);
			this.tbXMin.Name = "tbXMin";
			this.tbXMin.Size = new System.Drawing.Size(54, 22);
			this.tbXMin.TabIndex = 1;
			this.tbXMin.Text = "-7";
			// 
			// tbXMax
			// 
			this.tbXMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbXMax.Location = new System.Drawing.Point(172, 72);
			this.tbXMax.Name = "tbXMax";
			this.tbXMax.Size = new System.Drawing.Size(57, 22);
			this.tbXMax.TabIndex = 2;
			this.tbXMax.Text = "10";
			// 
			// tbXStepsNumber
			// 
			this.tbXStepsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbXStepsNumber.Location = new System.Drawing.Point(115, 104);
			this.tbXStepsNumber.Name = "tbXStepsNumber";
			this.tbXStepsNumber.Size = new System.Drawing.Size(60, 22);
			this.tbXStepsNumber.TabIndex = 3;
			this.tbXStepsNumber.Text = "6";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCalculate.Location = new System.Drawing.Point(12, 137);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(97, 32);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// table
			// 
			this.table.AllowUserToAddRows = false;
			this.table.AllowUserToDeleteRows = false;
			this.table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)));
			this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.table.DefaultCellStyle = dataGridViewCellStyle1;
			this.table.Location = new System.Drawing.Point(12, 207);
			this.table.Name = "table";
			this.table.ReadOnly = true;
			this.table.RowHeadersVisible = false;
			this.table.Size = new System.Drawing.Size(403, 323);
			this.table.TabIndex = 5;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiFile});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1132, 24);
			this.menuStrip.TabIndex = 6;
			this.menuStrip.Text = "menuStrip1";
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiExport,
			this.tsmiLoad});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "File";
			// 
			// tsmiLoad
			// 
			this.tsmiLoad.Name = "tsmiLoad";
			this.tsmiLoad.Size = new System.Drawing.Size(180, 22);
			this.tsmiLoad.Text = "Load";
			this.tsmiLoad.Click += new System.EventHandler(this.TsmiLoad_Click);
			// 
			// tsmiExport
			// 
			this.tsmiExport.Name = "tsmiExport";
			this.tsmiExport.Size = new System.Drawing.Size(180, 22);
			this.tsmiExport.Text = "Export";
			this.tsmiExport.Click += new System.EventHandler(this.TsmiExport_Click);
			// 
			// ofd
			// 
			this.ofd.DefaultExt = "*.lab4xml";
			this.ofd.Filter = "LAB4XML Files|*.lab4xml";
			this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.Ofd_FileOk);
			// 
			// sfd
			// 
			this.sfd.DefaultExt = "*.lab4xml";
			this.sfd.Filter = "LAB4XML Files|*.lab4xml";
			this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.Sfd_FileOk);
			// 
			// chart
			// 
			this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(421, 39);
			this.chart.Name = "chart";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chart.Series.Add(series1);
			this.chart.Size = new System.Drawing.Size(699, 468);
			this.chart.TabIndex = 7;
			this.chart.Text = "chart1";
			// 
			// btnClear
			// 
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClear.Location = new System.Drawing.Point(115, 137);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(86, 32);
			this.btnClear.TabIndex = 8;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
			// 
			// lblFunction
			// 
			this.lblFunction.AutoSize = true;
			this.lblFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblFunction.Location = new System.Drawing.Point(9, 42);
			this.lblFunction.Name = "lblFunction";
			this.lblFunction.Size = new System.Drawing.Size(110, 16);
			this.lblFunction.TabIndex = 9;
			this.lblFunction.Text = "Function (with \"x\")";
			// 
			// lblXMin
			// 
			this.lblXMin.AutoSize = true;
			this.lblXMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblXMin.Location = new System.Drawing.Point(9, 75);
			this.lblXMin.Name = "lblXMin";
			this.lblXMin.Size = new System.Drawing.Size(40, 16);
			this.lblXMin.TabIndex = 10;
			this.lblXMin.Text = "X min";
			// 
			// lblXMax
			// 
			this.lblXMax.AutoSize = true;
			this.lblXMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblXMax.Location = new System.Drawing.Point(122, 75);
			this.lblXMax.Name = "lblXMax";
			this.lblXMax.Size = new System.Drawing.Size(44, 16);
			this.lblXMax.TabIndex = 11;
			this.lblXMax.Text = "X max";
			// 
			// lblXStepsNumber
			// 
			this.lblXStepsNumber.AutoSize = true;
			this.lblXStepsNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblXStepsNumber.Location = new System.Drawing.Point(9, 107);
			this.lblXStepsNumber.Name = "lblXStepsNumber";
			this.lblXStepsNumber.Size = new System.Drawing.Size(100, 16);
			this.lblXStepsNumber.TabIndex = 12;
			this.lblXStepsNumber.Text = "X steps number";
			// 
			// lblXStep
			// 
			this.lblXStep.AutoSize = true;
			this.lblXStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblXStep.Location = new System.Drawing.Point(9, 181);
			this.lblXStep.Name = "lblXStep";
			this.lblXStep.Size = new System.Drawing.Size(45, 16);
			this.lblXStep.TabIndex = 13;
			this.lblXStep.Text = "X step";
			// 
			// lblXStepValue
			// 
			this.lblXStepValue.AutoSize = true;
			this.lblXStepValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblXStepValue.Location = new System.Drawing.Point(60, 181);
			this.lblXStepValue.Name = "lblXStepValue";
			this.lblXStepValue.Size = new System.Drawing.Size(17, 16);
			this.lblXStepValue.TabIndex = 14;
			this.lblXStepValue.Text = "...";
			// 
			// chbChartSmoothing
			// 
			this.chbChartSmoothing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.chbChartSmoothing.AutoSize = true;
			this.chbChartSmoothing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chbChartSmoothing.Location = new System.Drawing.Point(446, 513);
			this.chbChartSmoothing.Name = "chbChartSmoothing";
			this.chbChartSmoothing.Size = new System.Drawing.Size(123, 20);
			this.chbChartSmoothing.TabIndex = 15;
			this.chbChartSmoothing.Text = "Chart smoothing";
			this.chbChartSmoothing.UseVisualStyleBackColor = true;
			this.chbChartSmoothing.CheckedChanged += new System.EventHandler(this.ChbChartSmoothing_CheckedChanged);
			// 
			// Lab4Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1132, 542);
			this.Controls.Add(this.chbChartSmoothing);
			this.Controls.Add(this.lblXStepValue);
			this.Controls.Add(this.lblXStep);
			this.Controls.Add(this.lblXStepsNumber);
			this.Controls.Add(this.lblXMax);
			this.Controls.Add(this.lblXMin);
			this.Controls.Add(this.lblFunction);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.table);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.tbXStepsNumber);
			this.Controls.Add(this.tbXMax);
			this.Controls.Add(this.tbXMin);
			this.Controls.Add(this.tbFunction);
			this.Controls.Add(this.menuStrip);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "Lab4Form";
			this.Text = "Lab4Form";
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbFunction;
		private System.Windows.Forms.TextBox tbXMin;
		private System.Windows.Forms.TextBox tbXMax;
		private System.Windows.Forms.TextBox tbXStepsNumber;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Label lblFunction;
		private System.Windows.Forms.Label lblXMin;
		private System.Windows.Forms.Label lblXMax;
		private System.Windows.Forms.Label lblXStepsNumber;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
		private System.Windows.Forms.ToolStripMenuItem tsmiExport;
		private System.Windows.Forms.Label lblXStep;
		private System.Windows.Forms.Label lblXStepValue;
		private System.Windows.Forms.CheckBox chbChartSmoothing;
	}
}
