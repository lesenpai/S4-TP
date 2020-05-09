using System.Drawing;

namespace S4_TP.Lab3
{
	partial class Lab3Form
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
			this.components = new System.ComponentModel.Container();
			this.Options_MS = new System.Windows.Forms.MenuStrip();
			this.File_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.Open_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Save_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveAs_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Exit_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.View_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.BackgroundColor_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectionFont_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SelectionBackgroundColor_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectionTextColor = new System.Windows.Forms.ToolStripMenuItem();
			this.Font_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.About_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.ContextMS = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.Copy_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Cut_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.Paste_TSMI = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveFD = new System.Windows.Forms.SaveFileDialog();
			this.OpenFD = new System.Windows.Forms.OpenFileDialog();
			this.FontDlg = new System.Windows.Forms.FontDialog();
			this.colorDlg = new System.Windows.Forms.ColorDialog();
			this.Options_MS.SuspendLayout();
			this.ContextMS.SuspendLayout();
			this.SuspendLayout();
			// 
			// Options_MS
			// 
			this.Options_MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.File_TSMI,
			this.View_TSMI,
			this.About_TSMI});
			this.Options_MS.Location = new System.Drawing.Point(0, 0);
			this.Options_MS.Name = "Options_MS";
			this.Options_MS.Size = new System.Drawing.Size(698, 24);
			this.Options_MS.TabIndex = 0;
			// 
			// File_TSMI
			// 
			this.File_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmiNew,
			this.Open_TSMI,
			this.Save_TSMI,
			this.SaveAs_TSMI,
			this.Exit_TSMI});
			this.File_TSMI.Name = "File_TSMI";
			this.File_TSMI.Size = new System.Drawing.Size(37, 20);
			this.File_TSMI.Text = "File";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.Size = new System.Drawing.Size(112, 22);
			this.tsmiNew.Text = "New";
			this.tsmiNew.Click += new System.EventHandler(this.TsmiNew_Click);
			// 
			// Open_TSMI
			// 
			this.Open_TSMI.Name = "Open_TSMI";
			this.Open_TSMI.Size = new System.Drawing.Size(112, 22);
			this.Open_TSMI.Text = "Open";
			this.Open_TSMI.Click += new System.EventHandler(this.Open_TSMI_Click);
			// 
			// Save_TSMI
			// 
			this.Save_TSMI.Name = "Save_TSMI";
			this.Save_TSMI.Size = new System.Drawing.Size(112, 22);
			this.Save_TSMI.Text = "Save";
			this.Save_TSMI.Click += new System.EventHandler(this.Save_TSMI_Click);
			// 
			// SaveAs_TSMI
			// 
			this.SaveAs_TSMI.Name = "SaveAs_TSMI";
			this.SaveAs_TSMI.Size = new System.Drawing.Size(112, 22);
			this.SaveAs_TSMI.Text = "Save as";
			this.SaveAs_TSMI.Click += new System.EventHandler(this.SaveAs_TSMI_Click);
			// 
			// Exit_TSMI
			// 
			this.Exit_TSMI.Name = "Exit_TSMI";
			this.Exit_TSMI.Size = new System.Drawing.Size(112, 22);
			this.Exit_TSMI.Text = "Exit";
			this.Exit_TSMI.Click += new System.EventHandler(this.Exit_TSMI_Click);
			// 
			// View_TSMI
			// 
			this.View_TSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.BackgroundColor_TSMI,
			this.SelectionFont_TSMI,
			this.SelectionBackgroundColor_TSMI,
			this.tsmiSelectionTextColor,
			this.Font_TSMI});
			this.View_TSMI.Name = "View_TSMI";
			this.View_TSMI.Size = new System.Drawing.Size(44, 20);
			this.View_TSMI.Text = "View";
			// 
			// BackgroundColor_TSMI
			// 
			this.BackgroundColor_TSMI.Name = "BackgroundColor_TSMI";
			this.BackgroundColor_TSMI.Size = new System.Drawing.Size(219, 22);
			this.BackgroundColor_TSMI.Text = "Background color";
			this.BackgroundColor_TSMI.Click += new System.EventHandler(this.BackgroundColor_TSMI_Click);
			// 
			// SelectionFont_TSMI
			// 
			this.SelectionFont_TSMI.Name = "SelectionFont_TSMI";
			this.SelectionFont_TSMI.Size = new System.Drawing.Size(219, 22);
			this.SelectionFont_TSMI.Text = "Selection font";
			this.SelectionFont_TSMI.Click += new System.EventHandler(this.SelectionFont_TSMI_Click);
			// 
			// SelectionBackgroundColor_TSMI
			// 
			this.SelectionBackgroundColor_TSMI.Name = "SelectionBackgroundColor_TSMI";
			this.SelectionBackgroundColor_TSMI.Size = new System.Drawing.Size(219, 22);
			this.SelectionBackgroundColor_TSMI.Text = "Selection background color";
			this.SelectionBackgroundColor_TSMI.Click += new System.EventHandler(this.SelectionColor_TSMI_Click);
			// 
			// tsmiSelectionTextColor
			// 
			this.tsmiSelectionTextColor.Name = "tsmiSelectionTextColor";
			this.tsmiSelectionTextColor.Size = new System.Drawing.Size(219, 22);
			this.tsmiSelectionTextColor.Text = "Selection text color";
			this.tsmiSelectionTextColor.Click += new System.EventHandler(this.TsmiSelectionTextColor_Click);
			// 
			// Font_TSMI
			// 
			this.Font_TSMI.Name = "Font_TSMI";
			this.Font_TSMI.Size = new System.Drawing.Size(219, 22);
			this.Font_TSMI.Text = "Font";
			this.Font_TSMI.Click += new System.EventHandler(this.Font_TSMI_Click);
			// 
			// About_TSMI
			// 
			this.About_TSMI.Name = "About_TSMI";
			this.About_TSMI.Size = new System.Drawing.Size(52, 20);
			this.About_TSMI.Text = "About";
			this.About_TSMI.Click += new System.EventHandler(this.About_TSMI_Click);
			// 
			// rtb
			// 
			this.rtb.AcceptsTab = true;
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.rtb.ContextMenuStrip = this.ContextMS;
			this.rtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtb.Location = new System.Drawing.Point(0, 24);
			this.rtb.Margin = new System.Windows.Forms.Padding(0);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(698, 483);
			this.rtb.TabIndex = 1;
			this.rtb.Text = "";
			this.rtb.TextChanged += new System.EventHandler(this.Text_RTB_TextChanged);
			// 
			// ContextMS
			// 
			this.ContextMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.Copy_TSMI,
			this.Cut_TSMI,
			this.Paste_TSMI});
			this.ContextMS.Name = "ContextMS";
			this.ContextMS.Size = new System.Drawing.Size(103, 70);
			// 
			// Copy_TSMI
			// 
			this.Copy_TSMI.Name = "Copy_TSMI";
			this.Copy_TSMI.Size = new System.Drawing.Size(102, 22);
			this.Copy_TSMI.Text = "Copy";
			this.Copy_TSMI.Click += new System.EventHandler(this.Copy_TSMI_Click);
			// 
			// Cut_TSMI
			// 
			this.Cut_TSMI.Name = "Cut_TSMI";
			this.Cut_TSMI.Size = new System.Drawing.Size(102, 22);
			this.Cut_TSMI.Text = "Cut";
			this.Cut_TSMI.Click += new System.EventHandler(this.Cut_TSMI_Click);
			// 
			// Paste_TSMI
			// 
			this.Paste_TSMI.Name = "Paste_TSMI";
			this.Paste_TSMI.Size = new System.Drawing.Size(102, 22);
			this.Paste_TSMI.Text = "Paste";
			this.Paste_TSMI.Click += new System.EventHandler(this.Paste_TSMI_Click);
			// 
			// SaveFD
			// 
			this.SaveFD.DefaultExt = "*.rft";
			this.SaveFD.Filter = "RTF Files|*.rtf|TXT|*.txt|All files|*.*";
			// 
			// OpenFD
			// 
			this.OpenFD.DefaultExt = "*.rft";
			this.OpenFD.Filter = "RTF Files|*.rtf|TXT|*.txt|All files|*.*";
			// 
			// Lab3Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 508);
			this.Controls.Add(this.rtb);
			this.Controls.Add(this.Options_MS);
			this.MainMenuStrip = this.Options_MS;
			this.Name = "Lab3Form";
			this.Text = "S 4. TP 3. RTF editor";
			this.Load += new System.EventHandler(this.F3Form_Load);
			this.Options_MS.ResumeLayout(false);
			this.Options_MS.PerformLayout();
			this.ContextMS.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private System.Windows.Forms.MenuStrip Options_MS;
		private System.Windows.Forms.ToolStripMenuItem File_TSMI;
		private System.Windows.Forms.ToolStripMenuItem View_TSMI;
		private System.Windows.Forms.ToolStripMenuItem About_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Open_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Save_TSMI;
		private System.Windows.Forms.ToolStripMenuItem SaveAs_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Exit_TSMI;
		private System.Windows.Forms.ToolStripMenuItem BackgroundColor_TSMI;
		private System.Windows.Forms.ToolStripMenuItem SelectionFont_TSMI;
		private System.Windows.Forms.ToolStripMenuItem SelectionBackgroundColor_TSMI;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.SaveFileDialog SaveFD;
		private System.Windows.Forms.OpenFileDialog OpenFD;
		private System.Windows.Forms.FontDialog FontDlg;
		private System.Windows.Forms.ColorDialog colorDlg;
		private System.Windows.Forms.ContextMenuStrip ContextMS;
		private System.Windows.Forms.ToolStripMenuItem Copy_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Cut_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Paste_TSMI;
		private System.Windows.Forms.ToolStripMenuItem Font_TSMI;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiSelectionTextColor;
	}
}