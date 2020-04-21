using System;
using System.Windows.Forms;
namespace s4_tp
{
	partial class Lab5Form
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
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.canvas = new System.Windows.Forms.PictureBox();
			this.pnlCanvas = new s4_tp.Lab5Form.CustomPanel();
			this.pnlTools = new System.Windows.Forms.Panel();
			this.gbModes = new System.Windows.Forms.GroupBox();
			this.cbSmooth = new System.Windows.Forms.CheckBox();
			this.cbFill = new System.Windows.Forms.CheckBox();
			this.gbColors = new System.Windows.Forms.GroupBox();
			this.rbCustomColor = new System.Windows.Forms.RadioButton();
			this.rbEraserColor = new System.Windows.Forms.RadioButton();
			this.btnColor = new System.Windows.Forms.Button();
			this.gbTools = new System.Windows.Forms.GroupBox();
			this.rbFloodFill = new System.Windows.Forms.RadioButton();
			this.rbBrush = new System.Windows.Forms.RadioButton();
			this.rbEllipse = new System.Windows.Forms.RadioButton();
			this.rbRectangle = new System.Windows.Forms.RadioButton();
			this.tbThickness = new System.Windows.Forms.TextBox();
			this.lblThickness = new System.Windows.Forms.Label();
			this.tbFocusCap = new System.Windows.Forms.TextBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.lblUndoRedoTip = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblThicknessTip = new System.Windows.Forms.Label();
			this.lblBufferIndexValue = new System.Windows.Forms.Label();
			this.lblBufferIndex = new System.Windows.Forms.Label();
			this.lblDragTip = new System.Windows.Forms.Label();
			this.lblBufferSizeValue = new System.Windows.Forms.Label();
			this.lblBufferSize = new System.Windows.Forms.Label();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
			this.pnlCanvas.SuspendLayout();
			this.pnlTools.SuspendLayout();
			this.gbModes.SuspendLayout();
			this.gbColors.SuspendLayout();
			this.gbTools.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ofd
			// 
			this.ofd.FileName = "image.png";
			this.ofd.Filter = "PNG (*.png)|*png|JPG (*.jpg)|*.jpg|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
			this.ofd.FileOk += new System.ComponentModel.CancelEventHandler(this.Ofd_FileOk);
			// 
			// sfd
			// 
			this.sfd.Filter = "PNG (*.png)|*png|JPG (*.jpg)|*.jpg|BMP (*.bmp)|*.bmp|All files (*.*)|*.*";
			this.sfd.InitialDirectory = "d:\\";
			this.sfd.FileOk += new System.ComponentModel.CancelEventHandler(this.Sfd_FileOk);
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiAbout});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(1253, 24);
			this.menu.TabIndex = 1;
			// 
			// tsmiFile
			// 
			this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiExit});
			this.tsmiFile.Name = "tsmiFile";
			this.tsmiFile.Size = new System.Drawing.Size(37, 20);
			this.tsmiFile.Text = "File";
			// 
			// tsmiNew
			// 
			this.tsmiNew.Name = "tsmiNew";
			this.tsmiNew.Size = new System.Drawing.Size(180, 22);
			this.tsmiNew.Text = "New";
			this.tsmiNew.Click += new System.EventHandler(this.TsmiNew_Click);
			// 
			// tsmiOpen
			// 
			this.tsmiOpen.Name = "tsmiOpen";
			this.tsmiOpen.Size = new System.Drawing.Size(180, 22);
			this.tsmiOpen.Text = "Open";
			this.tsmiOpen.Click += new System.EventHandler(this.TsmiOpen_Click);
			// 
			// tsmiSave
			// 
			this.tsmiSave.Name = "tsmiSave";
			this.tsmiSave.Size = new System.Drawing.Size(180, 22);
			this.tsmiSave.Text = "Save";
			this.tsmiSave.Click += new System.EventHandler(this.TsmiSave_Click);
			// 
			// tsmiExit
			// 
			this.tsmiExit.Name = "tsmiExit";
			this.tsmiExit.Size = new System.Drawing.Size(180, 22);
			this.tsmiExit.Text = "Exit";
			// 
			// tsmiAbout
			// 
			this.tsmiAbout.Name = "tsmiAbout";
			this.tsmiAbout.Size = new System.Drawing.Size(52, 20);
			this.tsmiAbout.Text = "About";
			this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
			// 
			// canvas
			// 
			this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.canvas.Location = new System.Drawing.Point(29, 15);
			this.canvas.Name = "canvas";
			this.canvas.Size = new System.Drawing.Size(158, 105);
			this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.canvas.TabIndex = 0;
			this.canvas.TabStop = false;
			this.canvas.LocationChanged += new System.EventHandler(this.Canvas_LocationChanged);
			this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
			this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
			this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
			this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
			// 
			// pnlCanvas
			// 
			this.pnlCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCanvas.AutoScroll = true;
			this.pnlCanvas.BackColor = System.Drawing.Color.Black;
			this.pnlCanvas.Controls.Add(this.canvas);
			this.pnlCanvas.Location = new System.Drawing.Point(193, 24);
			this.pnlCanvas.Margin = new System.Windows.Forms.Padding(0);
			this.pnlCanvas.Name = "pnlCanvas";
			this.pnlCanvas.Size = new System.Drawing.Size(1055, 507);
			this.pnlCanvas.TabIndex = 2;
			this.pnlCanvas.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Panel_MouseWheel);
			// 
			// pnlTools
			// 
			this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTools.Controls.Add(this.gbModes);
			this.pnlTools.Controls.Add(this.gbColors);
			this.pnlTools.Controls.Add(this.gbTools);
			this.pnlTools.Controls.Add(this.tbThickness);
			this.pnlTools.Controls.Add(this.lblThickness);
			this.pnlTools.Location = new System.Drawing.Point(0, 24);
			this.pnlTools.Name = "pnlTools";
			this.pnlTools.Size = new System.Drawing.Size(190, 467);
			this.pnlTools.TabIndex = 3;
			// 
			// gbModes
			// 
			this.gbModes.Controls.Add(this.cbSmooth);
			this.gbModes.Controls.Add(this.cbFill);
			this.gbModes.Location = new System.Drawing.Point(12, 261);
			this.gbModes.Name = "gbModes";
			this.gbModes.Size = new System.Drawing.Size(164, 100);
			this.gbModes.TabIndex = 10;
			this.gbModes.TabStop = false;
			this.gbModes.Text = "Modes";
			// 
			// cbSmooth
			// 
			this.cbSmooth.AutoSize = true;
			this.cbSmooth.Checked = true;
			this.cbSmooth.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSmooth.Location = new System.Drawing.Point(6, 42);
			this.cbSmooth.Name = "cbSmooth";
			this.cbSmooth.Size = new System.Drawing.Size(62, 17);
			this.cbSmooth.TabIndex = 10;
			this.cbSmooth.Text = "Smooth";
			this.cbSmooth.UseVisualStyleBackColor = true;
			// 
			// cbFill
			// 
			this.cbFill.AutoSize = true;
			this.cbFill.Checked = true;
			this.cbFill.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbFill.Location = new System.Drawing.Point(6, 19);
			this.cbFill.Name = "cbFill";
			this.cbFill.Size = new System.Drawing.Size(38, 17);
			this.cbFill.TabIndex = 9;
			this.cbFill.Text = "Fill";
			this.cbFill.UseVisualStyleBackColor = true;
			// 
			// gbColors
			// 
			this.gbColors.Controls.Add(this.rbCustomColor);
			this.gbColors.Controls.Add(this.rbEraserColor);
			this.gbColors.Controls.Add(this.btnColor);
			this.gbColors.Location = new System.Drawing.Point(12, 41);
			this.gbColors.Name = "gbColors";
			this.gbColors.Size = new System.Drawing.Size(164, 79);
			this.gbColors.TabIndex = 7;
			this.gbColors.TabStop = false;
			this.gbColors.Text = "Colors";
			// 
			// rbCustomColor
			// 
			this.rbCustomColor.AutoSize = true;
			this.rbCustomColor.Checked = true;
			this.rbCustomColor.Location = new System.Drawing.Point(6, 19);
			this.rbCustomColor.Name = "rbCustomColor";
			this.rbCustomColor.Size = new System.Drawing.Size(60, 17);
			this.rbCustomColor.TabIndex = 4;
			this.rbCustomColor.TabStop = true;
			this.rbCustomColor.Text = "Custom";
			this.rbCustomColor.UseVisualStyleBackColor = true;
			this.rbCustomColor.CheckedChanged += new System.EventHandler(this.RbCustomColor_CheckedChanged);
			// 
			// rbEraserColor
			// 
			this.rbEraserColor.AutoSize = true;
			this.rbEraserColor.Location = new System.Drawing.Point(6, 42);
			this.rbEraserColor.Name = "rbEraserColor";
			this.rbEraserColor.Size = new System.Drawing.Size(55, 17);
			this.rbEraserColor.TabIndex = 5;
			this.rbEraserColor.Text = "Eraser";
			this.rbEraserColor.UseVisualStyleBackColor = true;
			this.rbEraserColor.CheckedChanged += new System.EventHandler(this.RbEraserColor_CheckedChanged);
			// 
			// btnColor
			// 
			this.btnColor.BackColor = System.Drawing.Color.Black;
			this.btnColor.Location = new System.Drawing.Point(72, 15);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(46, 25);
			this.btnColor.TabIndex = 3;
			this.btnColor.UseVisualStyleBackColor = false;
			this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
			// 
			// gbTools
			// 
			this.gbTools.Controls.Add(this.rbFloodFill);
			this.gbTools.Controls.Add(this.rbBrush);
			this.gbTools.Controls.Add(this.rbEllipse);
			this.gbTools.Controls.Add(this.rbRectangle);
			this.gbTools.Location = new System.Drawing.Point(12, 126);
			this.gbTools.Name = "gbTools";
			this.gbTools.Size = new System.Drawing.Size(164, 129);
			this.gbTools.TabIndex = 6;
			this.gbTools.TabStop = false;
			this.gbTools.Text = "Tools";
			// 
			// rbFloodFill
			// 
			this.rbFloodFill.AutoSize = true;
			this.rbFloodFill.Location = new System.Drawing.Point(6, 88);
			this.rbFloodFill.Name = "rbFloodFill";
			this.rbFloodFill.Size = new System.Drawing.Size(66, 17);
			this.rbFloodFill.TabIndex = 11;
			this.rbFloodFill.Text = "Flood Fill";
			this.rbFloodFill.UseVisualStyleBackColor = true;
			// 
			// rbBrush
			// 
			this.rbBrush.AutoSize = true;
			this.rbBrush.Checked = true;
			this.rbBrush.Location = new System.Drawing.Point(6, 19);
			this.rbBrush.Name = "rbBrush";
			this.rbBrush.Size = new System.Drawing.Size(52, 17);
			this.rbBrush.TabIndex = 10;
			this.rbBrush.TabStop = true;
			this.rbBrush.Text = "Brush";
			this.rbBrush.UseVisualStyleBackColor = true;
			// 
			// rbEllipse
			// 
			this.rbEllipse.AutoSize = true;
			this.rbEllipse.Location = new System.Drawing.Point(6, 65);
			this.rbEllipse.Name = "rbEllipse";
			this.rbEllipse.Size = new System.Drawing.Size(55, 17);
			this.rbEllipse.TabIndex = 8;
			this.rbEllipse.Text = "Ellipse";
			this.rbEllipse.UseVisualStyleBackColor = true;
			// 
			// rbRectangle
			// 
			this.rbRectangle.AutoSize = true;
			this.rbRectangle.Location = new System.Drawing.Point(6, 42);
			this.rbRectangle.Name = "rbRectangle";
			this.rbRectangle.Size = new System.Drawing.Size(74, 17);
			this.rbRectangle.TabIndex = 7;
			this.rbRectangle.Text = "Rectangle";
			this.rbRectangle.UseVisualStyleBackColor = true;
			// 
			// tbThickness
			// 
			this.tbThickness.Location = new System.Drawing.Point(71, 15);
			this.tbThickness.Name = "tbThickness";
			this.tbThickness.Size = new System.Drawing.Size(59, 20);
			this.tbThickness.TabIndex = 1;
			this.tbThickness.Text = "10";
			this.tbThickness.MouseLeave += new System.EventHandler(this.TbThickness_MouseLeave);
			this.tbThickness.Validating += new System.ComponentModel.CancelEventHandler(this.TbThickness_Validating);
			// 
			// lblThickness
			// 
			this.lblThickness.AutoSize = true;
			this.lblThickness.Location = new System.Drawing.Point(9, 18);
			this.lblThickness.Name = "lblThickness";
			this.lblThickness.Size = new System.Drawing.Size(56, 13);
			this.lblThickness.TabIndex = 0;
			this.lblThickness.Text = "Thickness";
			// 
			// tbFocusCap
			// 
			this.tbFocusCap.Location = new System.Drawing.Point(-20, -20);
			this.tbFocusCap.Name = "tbFocusCap";
			this.tbFocusCap.ReadOnly = true;
			this.tbFocusCap.Size = new System.Drawing.Size(10, 20);
			this.tbFocusCap.TabIndex = 1;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			// 
			// lblUndoRedoTip
			// 
			this.lblUndoRedoTip.AutoSize = true;
			this.lblUndoRedoTip.Location = new System.Drawing.Point(3, 11);
			this.lblUndoRedoTip.Name = "lblUndoRedoTip";
			this.lblUndoRedoTip.Size = new System.Drawing.Size(194, 13);
			this.lblUndoRedoTip.TabIndex = 4;
			this.lblUndoRedoTip.Text = "Undo / Redo = Ctrl + Z / Ctrl + Shift + Z";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.panel1.Controls.Add(this.lblThicknessTip);
			this.panel1.Controls.Add(this.lblBufferIndexValue);
			this.panel1.Controls.Add(this.lblBufferIndex);
			this.panel1.Controls.Add(this.lblDragTip);
			this.panel1.Controls.Add(this.lblBufferSizeValue);
			this.panel1.Controls.Add(this.lblBufferSize);
			this.panel1.Controls.Add(this.lblUndoRedoTip);
			this.panel1.Location = new System.Drawing.Point(193, 534);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1055, 36);
			this.panel1.TabIndex = 4;
			// 
			// lblThicknessTip
			// 
			this.lblThicknessTip.AutoSize = true;
			this.lblThicknessTip.Location = new System.Drawing.Point(338, 11);
			this.lblThicknessTip.Name = "lblThicknessTip";
			this.lblThicknessTip.Size = new System.Drawing.Size(167, 13);
			this.lblThicknessTip.TabIndex = 10;
			this.lblThicknessTip.Text = "Thickness = Shift + Mouse Wheel";
			// 
			// lblBufferIndexValue
			// 
			this.lblBufferIndexValue.AutoSize = true;
			this.lblBufferIndexValue.Location = new System.Drawing.Point(737, 11);
			this.lblBufferIndexValue.Name = "lblBufferIndexValue";
			this.lblBufferIndexValue.Size = new System.Drawing.Size(16, 13);
			this.lblBufferIndexValue.TabIndex = 9;
			this.lblBufferIndexValue.Text = "-1";
			// 
			// lblBufferIndex
			// 
			this.lblBufferIndex.AutoSize = true;
			this.lblBufferIndex.Location = new System.Drawing.Point(668, 11);
			this.lblBufferIndex.Name = "lblBufferIndex";
			this.lblBufferIndex.Size = new System.Drawing.Size(73, 13);
			this.lblBufferIndex.TabIndex = 8;
			this.lblBufferIndex.Text = "Buffer Index =";
			// 
			// lblDragTip
			// 
			this.lblDragTip.AutoSize = true;
			this.lblDragTip.Location = new System.Drawing.Point(225, 11);
			this.lblDragTip.Name = "lblDragTip";
			this.lblDragTip.Size = new System.Drawing.Size(91, 13);
			this.lblDragTip.TabIndex = 7;
			this.lblDragTip.Text = "Drag = Ctrl + LMB";
			// 
			// lblBufferSizeValue
			// 
			this.lblBufferSizeValue.AutoSize = true;
			this.lblBufferSizeValue.Location = new System.Drawing.Point(649, 11);
			this.lblBufferSizeValue.Name = "lblBufferSizeValue";
			this.lblBufferSizeValue.Size = new System.Drawing.Size(13, 13);
			this.lblBufferSizeValue.TabIndex = 6;
			this.lblBufferSizeValue.Text = "0";
			// 
			// lblBufferSize
			// 
			this.lblBufferSize.AutoSize = true;
			this.lblBufferSize.Location = new System.Drawing.Point(585, 11);
			this.lblBufferSize.Name = "lblBufferSize";
			this.lblBufferSize.Size = new System.Drawing.Size(67, 13);
			this.lblBufferSize.TabIndex = 5;
			this.lblBufferSize.Text = "Buffer Size =";
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// Lab5Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1253, 569);
			this.Controls.Add(this.tbFocusCap);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlTools);
			this.Controls.Add(this.pnlCanvas);
			this.Controls.Add(this.menu);
			this.MainMenuStrip = this.menu;
			this.Name = "Lab5Form";
			this.Text = "Image Editor";
			this.Load += new System.EventHandler(this.Lab5Form_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Lab5Form_KeyUp);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
			this.pnlCanvas.ResumeLayout(false);
			this.pnlCanvas.PerformLayout();
			this.pnlTools.ResumeLayout(false);
			this.pnlTools.PerformLayout();
			this.gbModes.ResumeLayout(false);
			this.gbModes.PerformLayout();
			this.gbColors.ResumeLayout(false);
			this.gbColors.PerformLayout();
			this.gbTools.ResumeLayout(false);
			this.gbTools.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile;
		private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
		private System.Windows.Forms.PictureBox canvas;
		private System.Windows.Forms.ToolStripMenuItem tsmiNew;
		private System.Windows.Forms.ToolStripMenuItem tsmiSave;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
		private CustomPanel pnlCanvas;
		private System.Windows.Forms.Panel pnlTools;
		private TextBox tbThickness;
		private System.Windows.Forms.Label lblThickness;
		private ErrorProvider errorProvider;
		private Button btnColor;
		private ColorDialog colorDialog;
		private RadioButton rbEraserColor;
		private RadioButton rbCustomColor;
		private GroupBox gbTools;
		private RadioButton rbEllipse;
		private RadioButton rbRectangle;
		private CheckBox cbFill;
		private GroupBox gbColors;
		private RadioButton rbBrush;
		private GroupBox gbModes;
		private CheckBox cbSmooth;
		private Label lblUndoRedoTip;
		private Panel panel1;
		private Label lblBufferSizeValue;
		private Label lblBufferSize;
		private Label lblDragTip;
		private Label lblBufferIndexValue;
		private Label lblBufferIndex;
		private TextBox tbFocusCap;
		private ContextMenuStrip contextMenuStrip1;
		private Label lblThicknessTip;
		private RadioButton rbFloodFill;
	}
}