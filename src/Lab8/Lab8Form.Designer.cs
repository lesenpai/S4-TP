namespace S4_TP.Lab8
{
	partial class Lab8Form
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
			this.CP_CanvasArea = new S4_TP.Lab8.Lab8Form.CustomPanel();
			this.PB_Canvas = new System.Windows.Forms.PictureBox();
			this.MS_Menu = new System.Windows.Forms.MenuStrip();
			this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_File_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_File_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.OFD_Dialog = new System.Windows.Forms.OpenFileDialog();
			this.SFD_Dialog = new System.Windows.Forms.SaveFileDialog();
			this.Pnl_Tools = new System.Windows.Forms.Panel();
			this.TB_ContrastCoeff = new System.Windows.Forms.TextBox();
			this.Lbl_ContrastCoeff = new System.Windows.Forms.Label();
			this.PB_ContrastProcessProgress = new System.Windows.Forms.ProgressBar();
			this.Btn_ApplyContrast = new System.Windows.Forms.Button();
			this.CP_CanvasArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PB_Canvas)).BeginInit();
			this.MS_Menu.SuspendLayout();
			this.Pnl_Tools.SuspendLayout();
			this.SuspendLayout();
			// 
			// CP_CanvasArea
			// 
			this.CP_CanvasArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CP_CanvasArea.AutoScroll = true;
			this.CP_CanvasArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CP_CanvasArea.Controls.Add(this.PB_Canvas);
			this.CP_CanvasArea.Location = new System.Drawing.Point(12, 27);
			this.CP_CanvasArea.Name = "CP_CanvasArea";
			this.CP_CanvasArea.Size = new System.Drawing.Size(723, 476);
			this.CP_CanvasArea.TabIndex = 0;
			// 
			// PB_Canvas
			// 
			this.PB_Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PB_Canvas.Location = new System.Drawing.Point(3, 3);
			this.PB_Canvas.Name = "PB_Canvas";
			this.PB_Canvas.Size = new System.Drawing.Size(477, 215);
			this.PB_Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PB_Canvas.TabIndex = 0;
			this.PB_Canvas.TabStop = false;
			// 
			// MS_Menu
			// 
			this.MS_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File});
			this.MS_Menu.Location = new System.Drawing.Point(0, 0);
			this.MS_Menu.Name = "MS_Menu";
			this.MS_Menu.Size = new System.Drawing.Size(1047, 24);
			this.MS_Menu.TabIndex = 1;
			this.MS_Menu.Text = "menuStrip1";
			// 
			// TSMI_File
			// 
			this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File_Open,
            this.TSMI_File_SaveAs});
			this.TSMI_File.Name = "TSMI_File";
			this.TSMI_File.Size = new System.Drawing.Size(48, 20);
			this.TSMI_File.Text = "Файл";
			// 
			// TSMI_File_Open
			// 
			this.TSMI_File_Open.Name = "TSMI_File_Open";
			this.TSMI_File_Open.Size = new System.Drawing.Size(155, 22);
			this.TSMI_File_Open.Text = "Открыть";
			this.TSMI_File_Open.Click += new System.EventHandler(this.TSMI_File_Open_Click);
			// 
			// TSMI_File_SaveAs
			// 
			this.TSMI_File_SaveAs.Enabled = false;
			this.TSMI_File_SaveAs.Name = "TSMI_File_SaveAs";
			this.TSMI_File_SaveAs.Size = new System.Drawing.Size(155, 22);
			this.TSMI_File_SaveAs.Text = "Сохранить Как";
			this.TSMI_File_SaveAs.Click += new System.EventHandler(this.TSMI_File_SaveAs_Click);
			// 
			// OFD_Dialog
			// 
			this.OFD_Dialog.Filter = "PNG (*.png)|*png|JPEG (*.jpeg)|*.jpeg|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
			this.OFD_Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_Dialog_FileOk);
			// 
			// SFD_Dialog
			// 
			this.SFD_Dialog.DefaultExt = "png";
			this.SFD_Dialog.Filter = "PNG (*.png)|*png|JPEG (*.jpeg)|*.jpeg|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
			this.SFD_Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SFD_Dialog_FileOk);
			// 
			// Pnl_Tools
			// 
			this.Pnl_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Pnl_Tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pnl_Tools.Controls.Add(this.TB_ContrastCoeff);
			this.Pnl_Tools.Controls.Add(this.Lbl_ContrastCoeff);
			this.Pnl_Tools.Controls.Add(this.PB_ContrastProcessProgress);
			this.Pnl_Tools.Controls.Add(this.Btn_ApplyContrast);
			this.Pnl_Tools.Location = new System.Drawing.Point(743, 27);
			this.Pnl_Tools.Name = "Pnl_Tools";
			this.Pnl_Tools.Size = new System.Drawing.Size(294, 123);
			this.Pnl_Tools.TabIndex = 2;
			// 
			// TB_ContrastCoeff
			// 
			this.TB_ContrastCoeff.Location = new System.Drawing.Point(198, 16);
			this.TB_ContrastCoeff.Name = "TB_ContrastCoeff";
			this.TB_ContrastCoeff.Size = new System.Drawing.Size(76, 20);
			this.TB_ContrastCoeff.TabIndex = 1;
			this.TB_ContrastCoeff.Text = "1";
			// 
			// Lbl_ContrastCoeff
			// 
			this.Lbl_ContrastCoeff.AutoSize = true;
			this.Lbl_ContrastCoeff.Location = new System.Drawing.Point(10, 19);
			this.Lbl_ContrastCoeff.Name = "Lbl_ContrastCoeff";
			this.Lbl_ContrastCoeff.Size = new System.Drawing.Size(188, 13);
			this.Lbl_ContrastCoeff.TabIndex = 1;
			this.Lbl_ContrastCoeff.Text = "Коэффициент контрастности (k > 0)";
			// 
			// PB_ContrastProcessProgress
			// 
			this.PB_ContrastProcessProgress.Location = new System.Drawing.Point(150, 56);
			this.PB_ContrastProcessProgress.MarqueeAnimationSpeed = 10;
			this.PB_ContrastProcessProgress.Name = "PB_ContrastProcessProgress";
			this.PB_ContrastProcessProgress.Size = new System.Drawing.Size(124, 30);
			this.PB_ContrastProcessProgress.Step = 1;
			this.PB_ContrastProcessProgress.TabIndex = 3;
			this.PB_ContrastProcessProgress.Visible = false;
			// 
			// Btn_ApplyContrast
			// 
			this.Btn_ApplyContrast.Location = new System.Drawing.Point(13, 56);
			this.Btn_ApplyContrast.Name = "Btn_ApplyContrast";
			this.Btn_ApplyContrast.Size = new System.Drawing.Size(131, 30);
			this.Btn_ApplyContrast.TabIndex = 0;
			this.Btn_ApplyContrast.Text = "Применить";
			this.Btn_ApplyContrast.UseVisualStyleBackColor = true;
			this.Btn_ApplyContrast.Click += new System.EventHandler(this.Btn_ApplyContrast_Click);
			// 
			// Lab8Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1047, 515);
			this.Controls.Add(this.Pnl_Tools);
			this.Controls.Add(this.CP_CanvasArea);
			this.Controls.Add(this.MS_Menu);
			this.MainMenuStrip = this.MS_Menu;
			this.Name = "Lab8Form";
			this.Text = "Lab 8: Contrast";
			this.Load += new System.EventHandler(this.Lab7Form_Load);
			this.CP_CanvasArea.ResumeLayout(false);
			this.CP_CanvasArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PB_Canvas)).EndInit();
			this.MS_Menu.ResumeLayout(false);
			this.MS_Menu.PerformLayout();
			this.Pnl_Tools.ResumeLayout(false);
			this.Pnl_Tools.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomPanel CP_CanvasArea;
		private System.Windows.Forms.PictureBox PB_Canvas;
		private System.Windows.Forms.MenuStrip MS_Menu;
		private System.Windows.Forms.ToolStripMenuItem TSMI_File;
		private System.Windows.Forms.ToolStripMenuItem TSMI_File_Open;
		private System.Windows.Forms.ToolStripMenuItem TSMI_File_SaveAs;
		private System.Windows.Forms.OpenFileDialog OFD_Dialog;
		private System.Windows.Forms.SaveFileDialog SFD_Dialog;
		private System.Windows.Forms.Panel Pnl_Tools;
		private System.Windows.Forms.Button Btn_ApplyContrast;
		private System.Windows.Forms.ProgressBar PB_ContrastProcessProgress;
		private System.Windows.Forms.TextBox TB_ContrastCoeff;
		private System.Windows.Forms.Label Lbl_ContrastCoeff;
	}
}