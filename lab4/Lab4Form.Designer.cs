namespace s4_tp
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
			this.Function_TB = new System.Windows.Forms.TextBox();
			this.Function_lbl = new System.Windows.Forms.Label();
			this.dgvTable = new System.Windows.Forms.DataGridView();
			this.Go_btn = new System.Windows.Forms.Button();
			this.Chart_EH = new System.Windows.Forms.Integration.ElementHost();
			this.XFChart = new LiveCharts.Wpf.CartesianChart();
			this.Step_lbl = new System.Windows.Forms.Label();
			this.XStep_TB = new System.Windows.Forms.TextBox();
			this.XStart_lbl = new System.Windows.Forms.Label();
			this.XEnd_lbl = new System.Windows.Forms.Label();
			this.XStart_TB = new System.Windows.Forms.TextBox();
			this.XEnd_TB = new System.Windows.Forms.TextBox();
			this.LoadData_btn = new System.Windows.Forms.Button();
			this.SaveData_btn = new System.Windows.Forms.Button();
			this.OpenFD = new System.Windows.Forms.OpenFileDialog();
			this.SaveFD = new System.Windows.Forms.SaveFileDialog();
			this.Clear_btn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
			this.SuspendLayout();
			// 
			// Function_TB
			// 
			this.Function_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Function_TB.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Function_TB.Location = new System.Drawing.Point(120, 6);
			this.Function_TB.Name = "Function_TB";
			this.Function_TB.Size = new System.Drawing.Size(269, 30);
			this.Function_TB.TabIndex = 0;
			// 
			// Function_lbl
			// 
			this.Function_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Function_lbl.AutoSize = true;
			this.Function_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Function_lbl.Location = new System.Drawing.Point(12, 9);
			this.Function_lbl.Name = "Function_lbl";
			this.Function_lbl.Size = new System.Drawing.Size(102, 16);
			this.Function_lbl.TabIndex = 1;
			this.Function_lbl.Text = "Function with \"x\"";
			// 
			// XF_DGV
			// 
			this.dgvTable.AllowUserToAddRows = false;
			this.dgvTable.AllowUserToDeleteRows = false;
			this.dgvTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTable.Font = new System.Drawing.Font("Times New Roman", 10F);
			this.dgvTable.Location = new System.Drawing.Point(15, 135);
			this.dgvTable.Name = "XF_DGV";
			this.dgvTable.ReadOnly = true;
			this.dgvTable.RowHeadersVisible = false;
			this.dgvTable.Size = new System.Drawing.Size(374, 232);
			this.dgvTable.TabIndex = 5;
			// 
			// Go_btn
			// 
			this.Go_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Go_btn.Location = new System.Drawing.Point(268, 42);
			this.Go_btn.Name = "Go_btn";
			this.Go_btn.Size = new System.Drawing.Size(121, 34);
			this.Go_btn.TabIndex = 7;
			this.Go_btn.Text = "Go";
			this.Go_btn.UseVisualStyleBackColor = true;
			this.Go_btn.Click += new System.EventHandler(this.Go_btn_Click);
			// 
			// Chart_EH
			// 
			this.Chart_EH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Chart_EH.Location = new System.Drawing.Point(395, 6);
			this.Chart_EH.Name = "Chart_EH";
			this.Chart_EH.Size = new System.Drawing.Size(525, 421);
			this.Chart_EH.TabIndex = 8;
			this.Chart_EH.Text = "Chart_ElementHost";
			this.Chart_EH.Child = this.XFChart;
			// 
			// Step_lbl
			// 
			this.Step_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.Step_lbl.AutoSize = true;
			this.Step_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Step_lbl.Location = new System.Drawing.Point(279, 102);
			this.Step_lbl.Name = "Step_lbl";
			this.Step_lbl.Size = new System.Drawing.Size(36, 16);
			this.Step_lbl.TabIndex = 9;
			this.Step_lbl.Text = "Step";
			// 
			// XStep_TB
			// 
			this.XStep_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.XStep_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.XStep_TB.Location = new System.Drawing.Point(321, 99);
			this.XStep_TB.Name = "XStep_TB";
			this.XStep_TB.Size = new System.Drawing.Size(67, 22);
			this.XStep_TB.TabIndex = 10;
			// 
			// XStart_lbl
			// 
			this.XStart_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.XStart_lbl.AutoSize = true;
			this.XStart_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.XStart_lbl.Location = new System.Drawing.Point(13, 102);
			this.XStart_lbl.Name = "XStart_lbl";
			this.XStart_lbl.Size = new System.Drawing.Size(44, 16);
			this.XStart_lbl.TabIndex = 11;
			this.XStart_lbl.Text = "X start";
			// 
			// XEnd_lbl
			// 
			this.XEnd_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.XEnd_lbl.AutoSize = true;
			this.XEnd_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.XEnd_lbl.Location = new System.Drawing.Point(149, 102);
			this.XEnd_lbl.Name = "XEnd_lbl";
			this.XEnd_lbl.Size = new System.Drawing.Size(42, 16);
			this.XEnd_lbl.TabIndex = 12;
			this.XEnd_lbl.Text = "X end";
			// 
			// XStart_TB
			// 
			this.XStart_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.XStart_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.XStart_TB.Location = new System.Drawing.Point(63, 99);
			this.XStart_TB.Name = "XStart_TB";
			this.XStart_TB.Size = new System.Drawing.Size(67, 22);
			this.XStart_TB.TabIndex = 13;
			// 
			// XEnd_TB
			// 
			this.XEnd_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.XEnd_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.XEnd_TB.Location = new System.Drawing.Point(197, 99);
			this.XEnd_TB.Name = "XEnd_TB";
			this.XEnd_TB.Size = new System.Drawing.Size(67, 22);
			this.XEnd_TB.TabIndex = 14;
			// 
			// LoadData_btn
			// 
			this.LoadData_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.LoadData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LoadData_btn.Location = new System.Drawing.Point(266, 373);
			this.LoadData_btn.Name = "LoadData_btn";
			this.LoadData_btn.Size = new System.Drawing.Size(121, 24);
			this.LoadData_btn.TabIndex = 15;
			this.LoadData_btn.Text = "Load data";
			this.LoadData_btn.UseVisualStyleBackColor = true;
			this.LoadData_btn.Click += new System.EventHandler(this.LoadData_btn_Click);
			// 
			// SaveData_btn
			// 
			this.SaveData_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SaveData_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.SaveData_btn.Location = new System.Drawing.Point(139, 373);
			this.SaveData_btn.Name = "SaveData_btn";
			this.SaveData_btn.Size = new System.Drawing.Size(121, 24);
			this.SaveData_btn.TabIndex = 16;
			this.SaveData_btn.Text = "Save data";
			this.SaveData_btn.UseVisualStyleBackColor = true;
			this.SaveData_btn.Click += new System.EventHandler(this.SaveData_btn_Click);
			// 
			// OpenFD
			// 
			this.OpenFD.DefaultExt = "*.xml";
			this.OpenFD.FileName = "example.xml";
			this.OpenFD.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFD_FileOk);
			// 
			// SaveFD
			// 
			this.SaveFD.DefaultExt = "*.xml";
			this.SaveFD.Filter = "XML Files|*.xml";
			this.SaveFD.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFD_FileOk);
			// 
			// Clear_btn
			// 
			this.Clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Clear_btn.Location = new System.Drawing.Point(12, 373);
			this.Clear_btn.Name = "Clear_btn";
			this.Clear_btn.Size = new System.Drawing.Size(121, 24);
			this.Clear_btn.TabIndex = 17;
			this.Clear_btn.Text = "Clear";
			this.Clear_btn.UseVisualStyleBackColor = true;
			this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
			// 
			// Lab4Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 439);
			this.Controls.Add(this.Clear_btn);
			this.Controls.Add(this.SaveData_btn);
			this.Controls.Add(this.LoadData_btn);
			this.Controls.Add(this.XEnd_TB);
			this.Controls.Add(this.XStart_TB);
			this.Controls.Add(this.XEnd_lbl);
			this.Controls.Add(this.XStart_lbl);
			this.Controls.Add(this.XStep_TB);
			this.Controls.Add(this.Step_lbl);
			this.Controls.Add(this.Chart_EH);
			this.Controls.Add(this.Go_btn);
			this.Controls.Add(this.dgvTable);
			this.Controls.Add(this.Function_lbl);
			this.Controls.Add(this.Function_TB);
			this.Name = "Lab4Form";
			this.Text = "Top X Chart";
			this.Load += new System.EventHandler(this.F4Form_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox Function_TB;
		private System.Windows.Forms.Label Function_lbl;
		private System.Windows.Forms.DataGridView dgvTable;
		private System.Windows.Forms.Button Go_btn;
		private System.Windows.Forms.Integration.ElementHost Chart_EH;
		private LiveCharts.Wpf.CartesianChart XFChart; // chart
		private System.Windows.Forms.Label Step_lbl;
		private System.Windows.Forms.TextBox XStep_TB;
		private System.Windows.Forms.Label XStart_lbl;
		private System.Windows.Forms.Label XEnd_lbl;
		private System.Windows.Forms.TextBox XStart_TB;
		private System.Windows.Forms.TextBox XEnd_TB;
		private System.Windows.Forms.Button LoadData_btn;
		private System.Windows.Forms.Button SaveData_btn;
		private System.Windows.Forms.OpenFileDialog OpenFD;
		private System.Windows.Forms.SaveFileDialog SaveFD;
		private System.Windows.Forms.Button Clear_btn;
	}
}