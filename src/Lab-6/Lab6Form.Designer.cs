namespace S4_TP.Lab6
{
	partial class Lab6Form
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
			this.CP_canvasArea = new S4_TP.Lab6.Lab6Form.CustomPanel();
			this.PB_canvas = new System.Windows.Forms.PictureBox();
			this.MS_menu = new System.Windows.Forms.MenuStrip();
			this.TSMI_file = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_file_open = new System.Windows.Forms.ToolStripMenuItem();
			this.TSMI_file_saveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.OFD_dialog = new System.Windows.Forms.OpenFileDialog();
			this.SFD_dialog = new System.Windows.Forms.SaveFileDialog();
			this.Pnl_tools = new System.Windows.Forms.Panel();
			this.PB_BWConvertProgress = new System.Windows.Forms.ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.Pnl_stdSetsOfBrightnessFactors = new System.Windows.Forms.Panel();
			this.RB_oldStdSetOfBrightnessFactors = new System.Windows.Forms.RadioButton();
			this.RB_newStdSetOfBrightnessFactors = new System.Windows.Forms.RadioButton();
			this.Btn_BlackWhite = new System.Windows.Forms.Button();
			this.CP_canvasArea.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PB_canvas)).BeginInit();
			this.MS_menu.SuspendLayout();
			this.Pnl_tools.SuspendLayout();
			this.Pnl_stdSetsOfBrightnessFactors.SuspendLayout();
			this.SuspendLayout();
			// 
			// CP_canvasArea
			// 
			this.CP_canvasArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CP_canvasArea.AutoScroll = true;
			this.CP_canvasArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CP_canvasArea.Controls.Add(this.PB_canvas);
			this.CP_canvasArea.Location = new System.Drawing.Point(12, 27);
			this.CP_canvasArea.Name = "CP_canvasArea";
			this.CP_canvasArea.Size = new System.Drawing.Size(723, 476);
			this.CP_canvasArea.TabIndex = 0;
			// 
			// PB_canvas
			// 
			this.PB_canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PB_canvas.Location = new System.Drawing.Point(3, 3);
			this.PB_canvas.Name = "PB_canvas";
			this.PB_canvas.Size = new System.Drawing.Size(477, 215);
			this.PB_canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PB_canvas.TabIndex = 0;
			this.PB_canvas.TabStop = false;
			// 
			// MS_menu
			// 
			this.MS_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_file});
			this.MS_menu.Location = new System.Drawing.Point(0, 0);
			this.MS_menu.Name = "MS_menu";
			this.MS_menu.Size = new System.Drawing.Size(1047, 24);
			this.MS_menu.TabIndex = 1;
			this.MS_menu.Text = "menuStrip1";
			// 
			// TSMI_file
			// 
			this.TSMI_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_file_open,
            this.TSMI_file_saveAs});
			this.TSMI_file.Name = "TSMI_file";
			this.TSMI_file.Size = new System.Drawing.Size(48, 20);
			this.TSMI_file.Text = "Файл";
			// 
			// TSMI_file_open
			// 
			this.TSMI_file_open.Name = "TSMI_file_open";
			this.TSMI_file_open.Size = new System.Drawing.Size(155, 22);
			this.TSMI_file_open.Text = "Открыть";
			this.TSMI_file_open.Click += new System.EventHandler(this.TSMI_file_open_Click);
			// 
			// TSMI_file_saveAs
			// 
			this.TSMI_file_saveAs.Enabled = false;
			this.TSMI_file_saveAs.Name = "TSMI_file_saveAs";
			this.TSMI_file_saveAs.Size = new System.Drawing.Size(180, 22);
			this.TSMI_file_saveAs.Text = "Сохранить Как";
			this.TSMI_file_saveAs.Click += new System.EventHandler(this.TSMI_file_saveAs_Click);
			// 
			// OFD_dialog
			// 
			this.OFD_dialog.Filter = "PNG (*.png)|*png|JPEG (*.jpeg)|*.jpeg|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
			this.OFD_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_dialog_FileOk);
			// 
			// SFD_dialog
			// 
			this.SFD_dialog.Filter = "PNG (*.png)|*png|JPEG (*.jpeg)|*.jpeg|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
			this.SFD_dialog.DefaultExt = ".png";
			this.SFD_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SFD_dialog_FileOk);
			// 
			// Pnl_tools
			// 
			this.Pnl_tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Pnl_tools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pnl_tools.Controls.Add(this.PB_BWConvertProgress);
			this.Pnl_tools.Controls.Add(this.label1);
			this.Pnl_tools.Controls.Add(this.Pnl_stdSetsOfBrightnessFactors);
			this.Pnl_tools.Controls.Add(this.Btn_BlackWhite);
			this.Pnl_tools.Location = new System.Drawing.Point(743, 27);
			this.Pnl_tools.Name = "Pnl_tools";
			this.Pnl_tools.Size = new System.Drawing.Size(294, 219);
			this.Pnl_tools.TabIndex = 2;
			// 
			// PB_BWConvertProgress
			// 
			this.PB_BWConvertProgress.Location = new System.Drawing.Point(150, 130);
			this.PB_BWConvertProgress.MarqueeAnimationSpeed = 10;
			this.PB_BWConvertProgress.Name = "PB_BWConvertProgress";
			this.PB_BWConvertProgress.Size = new System.Drawing.Size(124, 30);
			this.PB_BWConvertProgress.Step = 1;
			this.PB_BWConvertProgress.TabIndex = 3;
			this.PB_BWConvertProgress.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(243, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Стандартные наборы коэффициентов яркости";
			// 
			// Pnl_stdSetsOfBrightnessFactors
			// 
			this.Pnl_stdSetsOfBrightnessFactors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pnl_stdSetsOfBrightnessFactors.Controls.Add(this.RB_oldStdSetOfBrightnessFactors);
			this.Pnl_stdSetsOfBrightnessFactors.Controls.Add(this.RB_newStdSetOfBrightnessFactors);
			this.Pnl_stdSetsOfBrightnessFactors.Location = new System.Drawing.Point(13, 34);
			this.Pnl_stdSetsOfBrightnessFactors.Name = "Pnl_stdSetsOfBrightnessFactors";
			this.Pnl_stdSetsOfBrightnessFactors.Size = new System.Drawing.Size(261, 73);
			this.Pnl_stdSetsOfBrightnessFactors.TabIndex = 3;
			// 
			// RB_oldStdSetOfBrightnessFactors
			// 
			this.RB_oldStdSetOfBrightnessFactors.AutoSize = true;
			this.RB_oldStdSetOfBrightnessFactors.Location = new System.Drawing.Point(3, 14);
			this.RB_oldStdSetOfBrightnessFactors.Name = "RB_oldStdSetOfBrightnessFactors";
			this.RB_oldStdSetOfBrightnessFactors.Size = new System.Drawing.Size(203, 17);
			this.RB_oldStdSetOfBrightnessFactors.TabIndex = 1;
			this.RB_oldStdSetOfBrightnessFactors.Text = "Старый набор {0,299; 0,587; 0,114} ";
			this.RB_oldStdSetOfBrightnessFactors.UseVisualStyleBackColor = true;
			// 
			// RB_newStdSetOfBrightnessFactors
			// 
			this.RB_newStdSetOfBrightnessFactors.AutoSize = true;
			this.RB_newStdSetOfBrightnessFactors.Checked = true;
			this.RB_newStdSetOfBrightnessFactors.Location = new System.Drawing.Point(3, 37);
			this.RB_newStdSetOfBrightnessFactors.Name = "RB_newStdSetOfBrightnessFactors";
			this.RB_newStdSetOfBrightnessFactors.Size = new System.Drawing.Size(214, 17);
			this.RB_newStdSetOfBrightnessFactors.TabIndex = 2;
			this.RB_newStdSetOfBrightnessFactors.TabStop = true;
			this.RB_newStdSetOfBrightnessFactors.Text = "Новый набор {0,2126; 0,7152; 0,0722}";
			this.RB_newStdSetOfBrightnessFactors.UseVisualStyleBackColor = true;
			// 
			// Btn_BlackWhite
			// 
			this.Btn_BlackWhite.Location = new System.Drawing.Point(13, 130);
			this.Btn_BlackWhite.Name = "Btn_BlackWhite";
			this.Btn_BlackWhite.Size = new System.Drawing.Size(131, 30);
			this.Btn_BlackWhite.TabIndex = 0;
			this.Btn_BlackWhite.Text = "Чёрно-белое";
			this.Btn_BlackWhite.UseVisualStyleBackColor = true;
			this.Btn_BlackWhite.Click += new System.EventHandler(this.Btn_blackWhite_Click);
			// 
			// Lab6Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1047, 515);
			this.Controls.Add(this.Pnl_tools);
			this.Controls.Add(this.CP_canvasArea);
			this.Controls.Add(this.MS_menu);
			this.MainMenuStrip = this.MS_menu;
			this.Name = "Lab6Form";
			this.Text = "Lab-6: Grayscaler";
			this.Load += new System.EventHandler(this.Lab6Form_Load);
			this.CP_canvasArea.ResumeLayout(false);
			this.CP_canvasArea.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.PB_canvas)).EndInit();
			this.MS_menu.ResumeLayout(false);
			this.MS_menu.PerformLayout();
			this.Pnl_tools.ResumeLayout(false);
			this.Pnl_tools.PerformLayout();
			this.Pnl_stdSetsOfBrightnessFactors.ResumeLayout(false);
			this.Pnl_stdSetsOfBrightnessFactors.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CustomPanel CP_canvasArea;
		private System.Windows.Forms.PictureBox PB_canvas;
		private System.Windows.Forms.MenuStrip MS_menu;
		private System.Windows.Forms.ToolStripMenuItem TSMI_file;
		private System.Windows.Forms.ToolStripMenuItem TSMI_file_open;
		private System.Windows.Forms.ToolStripMenuItem TSMI_file_saveAs;
		private System.Windows.Forms.OpenFileDialog OFD_dialog;
		private System.Windows.Forms.SaveFileDialog SFD_dialog;
		private System.Windows.Forms.Panel Pnl_tools;
		private System.Windows.Forms.RadioButton RB_oldStdSetOfBrightnessFactors;
		private System.Windows.Forms.Button Btn_BlackWhite;
		private System.Windows.Forms.Panel Pnl_stdSetsOfBrightnessFactors;
		private System.Windows.Forms.RadioButton RB_newStdSetOfBrightnessFactors;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ProgressBar PB_BWConvertProgress;
	}
}