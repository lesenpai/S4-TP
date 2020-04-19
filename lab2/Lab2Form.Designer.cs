namespace s4_tp
{
	partial class Lab2Form
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
			this.File_tlmi = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.Open_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.Save_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAs_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.Exit_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.View_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.Font_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.BackgroundColor_tsmi = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTextColor = new System.Windows.Forms.ToolStripMenuItem();
			this.About_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Options_ms = new System.Windows.Forms.MenuStrip();
			this.tb = new System.Windows.Forms.TextBox();
			this.Save_sfd = new System.Windows.Forms.SaveFileDialog();
			this.Open_ofd = new System.Windows.Forms.OpenFileDialog();
			this.Font_dlg = new System.Windows.Forms.FontDialog();
			this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
			this.cdTextColor = new System.Windows.Forms.ColorDialog();
			this.Options_ms.SuspendLayout();
			this.SuspendLayout();
			// 
			// File_tlmi
			// 
			this.File_tlmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.Open_tsmi,
            this.Save_tsmi,
            this.SaveAs_tsmi,
            this.Exit_tsmi});
			this.File_tlmi.Name = "File_tlmi";
			this.File_tlmi.Size = new System.Drawing.Size(37, 20);
			this.File_tlmi.Text = "File";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.Size = new System.Drawing.Size(112, 22);
			this.tsmiNew.Text = "New";
			this.tsmiNew.Click += new System.EventHandler(this.TsmiNew_Click);
			// 
			// Open_tsmi
			// 
			this.Open_tsmi.Name = "Open_tsmi";
			this.Open_tsmi.Size = new System.Drawing.Size(112, 22);
			this.Open_tsmi.Text = "Open";
			this.Open_tsmi.Click += new System.EventHandler(this.Open_tsmi_Click);
			// 
			// Save_tsmi
			// 
			this.Save_tsmi.Name = "Save_tsmi";
			this.Save_tsmi.Size = new System.Drawing.Size(112, 22);
			this.Save_tsmi.Text = "Save";
			this.Save_tsmi.Click += new System.EventHandler(this.Save_tsmi_Click);
			// 
			// SaveAs_tsmi
			// 
			this.SaveAs_tsmi.Name = "SaveAs_tsmi";
			this.SaveAs_tsmi.Size = new System.Drawing.Size(112, 22);
			this.SaveAs_tsmi.Text = "Save as";
			this.SaveAs_tsmi.Click += new System.EventHandler(this.SaveAs_tsmi_Click);
			// 
			// Exit_tsmi
			// 
			this.Exit_tsmi.Name = "Exit_tsmi";
			this.Exit_tsmi.Size = new System.Drawing.Size(112, 22);
			this.Exit_tsmi.Text = "Exit";
			this.Exit_tsmi.Click += new System.EventHandler(this.Exit_tsmi_Click);
			// 
			// View_tsmi
			// 
			this.View_tsmi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Font_tsmi,
            this.BackgroundColor_tsmi,
            this.tsmiTextColor});
			this.View_tsmi.Name = "View_tsmi";
			this.View_tsmi.Size = new System.Drawing.Size(44, 20);
			this.View_tsmi.Text = "View";
			// 
			// Font_tsmi
			// 
			this.Font_tsmi.Name = "Font_tsmi";
			this.Font_tsmi.Size = new System.Drawing.Size(180, 22);
			this.Font_tsmi.Text = "Font";
			this.Font_tsmi.Click += new System.EventHandler(this.Font_tsmi_Click);
			// 
			// BackgroundColor_tsmi
			// 
			this.BackgroundColor_tsmi.Name = "BackgroundColor_tsmi";
			this.BackgroundColor_tsmi.Size = new System.Drawing.Size(180, 22);
			this.BackgroundColor_tsmi.Text = "Background color";
			this.BackgroundColor_tsmi.Click += new System.EventHandler(this.BackgroundColor_tsmi_Click);
			// 
			// tsmiTextColor
			// 
			this.tsmiTextColor.Name = "tsmiTextColor";
			this.tsmiTextColor.Size = new System.Drawing.Size(180, 22);
			this.tsmiTextColor.Text = "Text color";
			this.tsmiTextColor.Click += new System.EventHandler(this.TsmiTextColor_Click);
			// 
			// About_TSMI
			// 
			this.About_TSMI.Name = "About_TSMI";
			this.About_TSMI.Size = new System.Drawing.Size(52, 20);
			this.About_TSMI.Text = "About";
			this.About_TSMI.Click += new System.EventHandler(this.About_TSMI_Click);
			// 
			// Options_ms
			// 
			this.Options_ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_tlmi,
            this.View_tsmi,
            this.About_TSMI});
			this.Options_ms.Location = new System.Drawing.Point(0, 0);
			this.Options_ms.Name = "Options_ms";
			this.Options_ms.Size = new System.Drawing.Size(583, 24);
			this.Options_ms.TabIndex = 1;
			this.Options_ms.Text = "menuStrip2";
			// 
			// tb
			// 
			this.tb.AcceptsTab = true;
			this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tb.BackColor = System.Drawing.Color.WhiteSmoke;
			this.tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tb.Location = new System.Drawing.Point(0, 24);
			this.tb.Margin = new System.Windows.Forms.Padding(0);
			this.tb.Multiline = true;
			this.tb.Name = "tb";
			this.tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb.Size = new System.Drawing.Size(583, 374);
			this.tb.TabIndex = 2;
			this.tb.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// Save_sfd
			// 
			this.Save_sfd.DefaultExt = "*.txt";
			this.Save_sfd.FileName = "filename.txt";
			this.Save_sfd.Filter = "TXT files|*.txt|All files|*.*";
			// 
			// Open_ofd
			// 
			this.Open_ofd.DefaultExt = "*.txt";
			this.Open_ofd.FileName = "filename.txt";
			this.Open_ofd.Filter = "TXT Files|*.txt|All files|*.*";
			this.Open_ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.Open_ofd_FileOk);
			// 
			// cdBackgroundColor
			// 
			this.cdBackgroundColor.Color = this.tb.BackColor;
			this.cdBackgroundColor.FullOpen = true;
			// 
			// Lab2Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 399);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.Options_ms);
			this.Name = "Lab2Form";
			this.Text = "Blocknotik";
			this.Load += new System.EventHandler(this.F2Form_Load);
			this.Options_ms.ResumeLayout(false);
			this.Options_ms.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStripMenuItem File_tlmi;
		private System.Windows.Forms.ToolStripMenuItem Open_tsmi;
		private System.Windows.Forms.ToolStripMenuItem Save_tsmi;
		private System.Windows.Forms.ToolStripMenuItem SaveAs_tsmi;
		private System.Windows.Forms.ToolStripMenuItem Exit_tsmi;
		private System.Windows.Forms.ToolStripMenuItem View_tsmi;
		private System.Windows.Forms.ToolStripMenuItem Font_tsmi;
		private System.Windows.Forms.ToolStripMenuItem BackgroundColor_tsmi;
		private System.Windows.Forms.ToolStripMenuItem About_TSMI;
		private System.Windows.Forms.MenuStrip Options_ms;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.SaveFileDialog Save_sfd;
		private System.Windows.Forms.OpenFileDialog Open_ofd;
		private System.Windows.Forms.FontDialog Font_dlg;
		private System.Windows.Forms.ColorDialog cdBackgroundColor;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiTextColor;
		private System.Windows.Forms.ColorDialog cdTextColor;
	}
}

