using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using S4_TP.About;

/* 
	*** Key Bindings ***
	--------------------
	RMB	                            : eraser (draw in white color)
	Ctrl + Z / Ctrl + Shift + Z	    : Undo/Redo
	LMB	                            : draw
	LMB + Ctrl                      : drag image
	Mouse Wheel	                    : vertical scroll
	Mouse Wheel + Shift	            : horisontal scroll
*/

namespace S4_TP.Lab5
{
	public partial class Lab5Form : Form
	{
		private const string APP_NAME = "Photosoup",
							 CAPTURE_RIGHT_SIDE = " - " + APP_NAME,
							 DEFAULT_FILE_NAME = "untitled";
		// Flags
		private bool isFileOpen = false,
					 isFileSaved = true;

		private const int WM_KEYDOWN = 0x100,
						  WM_CLOSE = 0x0010;

		private const int THICKNESS_MAX = 600,
						  THICKNESS_DELTA = 10;

		private Point canvas_lmbDownPos,
			          canvas_prevLmbDownPos,
			          canvas_mouseMovePos;

		private Pen pen;
		// Координаты и размеры кисти
		private Rectangle penRect;
		private int thickness;
		private bool canvas_prevLmbDownPos_isActive = false;
		// Буфер для Undo/Redo
		private List<Bitmap> _buffer = new List<Bitmap>();
		// Индекс элемента в буфере
		private int _bufferIndex = -1;
		private AboutForm aboutForm;

		private string _filename;
		SizeSetterForm sizeSetterForm;

		public Lab5Form()
		{
			InitializeComponent();
			canvas.SizeMode = PictureBoxSizeMode.AutoSize;
			colorDialog.Color = btnColor.BackColor;
			pen = new Pen(btnColor.BackColor);
			thickness = int.Parse(tbThickness.Text);
			penRect = new Rectangle(-thickness / 2, -thickness / 2, thickness, thickness);
		}
		private void Lab5Form_Load(object sender, EventArgs e)
		{
			if (canvas.Image == null)
			{
				canvas.Enabled = false;
			}
			Text = DEFAULT_FILE_NAME + CAPTURE_RIGHT_SIDE;
		}

		/*
			Panel with horisontal scroll on (Shift + Mouse Wheel)
		*/
		public class CustomPanel : Panel
		{
			protected override void OnMouseWheel(MouseEventArgs e)
			{
				if (VScroll && IsShiftDown())
				{
					VScroll = false;
					base.OnMouseWheel(e);
					VScroll = true;
				}
				else if (IsCtrlDown())
				{
					var parent = Parent as Lab5Form;

					if (e.Delta > 0 && parent.thickness < 10)
					{
						parent.thickness++;
					}
					else if (e.Delta > 0 && parent.thickness <= THICKNESS_MAX - THICKNESS_DELTA)
					{
						parent.thickness += THICKNESS_DELTA;
					}
					else if (e.Delta < 0 && parent.thickness > 10) 
					{
						parent.thickness -= THICKNESS_DELTA;
					}
					else if (e.Delta < 0 && parent.thickness > 1) 
					{
						parent.thickness--;
					}

					parent.tbThickness.Text = Convert.ToString(parent.thickness);
#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
					parent.penRect.Width = parent.penRect.Height = parent.thickness;
					parent.penRect.X = e.X - parent.canvas.Location.X - parent.thickness / 2;
					parent.penRect.Y = e.Y - parent.canvas.Location.Y - parent.thickness / 2;
#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
					parent.Refresh();
				}
				else
				{
					base.OnMouseWheel(e);
				}
			}
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_CLOSE)
			{
				if (isFileSaved)
				{
					base.WndProc(ref m);
					return;
				}

				var dlg_result = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				switch (dlg_result)
				{
					case DialogResult.Yes:
						if (SaveAs())
						{
							isFileSaved = true;
						}
						break;

					case DialogResult.No:
						break;

					case DialogResult.Cancel:
						return;

					// If messagebox was closed
					default:
						return;
				}
			}

			base.WndProc(ref m);
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys key_data)
		{
			switch (msg.Msg)
			{
				case WM_KEYDOWN:
					// Ctrl + Shift + Z
					if (IsCtrlDown() && IsShiftDown() && IsKeyDown(System.Windows.Input.Key.Z))
					{
						if (_bufferIndex < _buffer.Count - 1 && _buffer.Count > 0)
						{
							_bufferIndex++;
							canvas.Image = _buffer[_bufferIndex];
							lblBufferIndexValue.Text = _bufferIndex.ToString();
						}

						return true;
					}
					// Ctrl + Z
					else if (IsCtrlDown() && IsKeyDown(System.Windows.Input.Key.Z))
					{
						if (_bufferIndex > 0 && _buffer.Count > 1)
						{
							_bufferIndex--;
							canvas.Image = _buffer[_bufferIndex];
							lblBufferIndexValue.Text = _bufferIndex.ToString();
						}

						return true;
					}

					return base.ProcessCmdKey(ref msg, key_data);

				default:
					return base.ProcessCmdKey(ref msg, key_data);
			}
		}

		private static bool IsKeyDown(System.Windows.Input.Key key) => System.Windows.Input.Keyboard.IsKeyDown(key);
		
		private static bool IsShiftDown() => (ModifierKeys & Keys.Shift) == Keys.Shift;
		
		private static bool IsCtrlDown() => (ModifierKeys & Keys.Control) == Keys.Control;
		
		private static bool IsLMBDown() => (MouseButtons & MouseButtons.Left) == MouseButtons.Left;
		
		private bool Any(params RadioButton[] list)
		{
			foreach (var item in list)
			{
				if (item.Checked)
				{
					return true;
				}
			}

			return false;
		}

		private void TsmiOpen_Click(object sender, EventArgs e)
		{
			ofd.ShowDialog();
		}

		/* OpenFileDialog.ShowDialog() --> */
		private void Ofd_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				// Data
				_filename = ofd.FileName;
				canvas.Image = new Bitmap(_filename);
				// Buffer
				_buffer.Clear();
				_bufferIndex = 0;
				_buffer.Add(canvas.Image.Clone() as Bitmap);
				// UI
				canvas.Enabled = true;
				Text = _filename + CAPTURE_RIGHT_SIDE;
				// Flags
				isFileOpen = true;
				isFileSaved = true;
			}
			catch (Exception ex)
			{
				isFileOpen = false;
				Text = DEFAULT_FILE_NAME + CAPTURE_RIGHT_SIDE;
				MessageBox.Show(ex.Message);
			}
		}

		/*
			Используется при относительно толстой кисти
		*/
		private void CustomDrawLine(Point start, Point end)
		{
			int dist = Math.Max(Math.Abs(start.X - end.X), Math.Abs(start.Y - end.Y));

			if (dist <= 0)
			{
				return;
			}

			int semi_size = (int)Math.Round(thickness / 2f);
			var g = Graphics.FromImage(canvas.Image);
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			if (dist == 1)
			{
				g.FillEllipse(pen.Brush, start.X - semi_size, start.Y - semi_size, thickness, thickness);
			}
			else if (dist == 2)
			{
				g.FillEllipse(pen.Brush, start.X - semi_size, start.Y - semi_size, thickness, thickness);
				g.FillEllipse(pen.Brush, end.X - semi_size, end.Y - semi_size, thickness, thickness);
			}
			else
			{
				// В середине - линия с толщиной круга
				Point p1 = new Point(), p2 = new Point();
				if (start.X < end.X)
				{
					p1.X = start.X + 1;
					p2.X = end.X - 1;
				}
				else if (start.X == end.X)
				{
					p1.X = start.X;
					p2.X = end.X;
				}
				else if (start.X > end.X)
				{
					p1.X = start.X - 1;
					p2.X = end.X + 1;
				}

				if (start.Y < end.Y)
				{
					p1.Y = start.Y + 1;
					p2.Y = end.Y - 1;
				}
				else if (start.Y == end.Y)
				{
					p1.Y = start.Y;
					p2.Y = end.Y;
				}
				else if (start.Y > end.Y)
				{
					p1.Y = start.Y - 1;
					p2.Y = end.Y + 1;
				}
				g.DrawLine(pen, p1, p2);
				// В конце - круг
				g.FillEllipse(pen.Brush, end.X - semi_size, end.Y - semi_size, thickness, thickness);
			}
		}

		private void TbThickness_TextChanged(object sender, EventArgs e)
		{
			ValidateChildren(ValidationConstraints.Enabled);
		}

		private void TbThickness_Validating(object sender, CancelEventArgs e)
		{
			if (int.TryParse(tbThickness.Text, out int value) && value > 0 && value <= THICKNESS_MAX)
			{
				e.Cancel = false;
				errorProvider.SetError(tbThickness, null);
				thickness = int.Parse(tbThickness.Text);
				penRect.Width = penRect.Height = thickness;
				pnlCanvas.Enabled = true;
			}
			else
			{
				e.Cancel = true;
				errorProvider.SetError(tbThickness, "Thickness should be between 1 and " + thickness);
				pnlCanvas.Enabled = false;
			}
		}

		/*
			On Mouse Wheel.
			@details Ctrl + Mouse Wheel = change %thichkness
		*/
		private void Panel_MouseWheel(object sender, MouseEventArgs e)
		{
			if (IsCtrlDown())
			{
				if (e.Delta > 0 && thickness < THICKNESS_MAX - 1)
				{
					thickness++;
				}
				else if (thickness > 2)
				{
					thickness--;
				}
			}
		}

		private void BtnColor_Click(object sender, EventArgs e)
		{
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				pen.Color = btnColor.BackColor = colorDialog.Color;
			}
		}

		private void Sfd_FileOk(object sender, CancelEventArgs e)
		{
			if (canvas.Image != null)
			{
				canvas.Image.Save(sfd.FileName);
			}
		}

		/*
			Заливка
			*/
		private void FloodFill(Bitmap bm, Point pt, Color replacement_color)
		{
			var target_color = bm.GetPixel(pt.X, pt.Y);
			if (target_color.ToArgb().Equals(replacement_color.ToArgb()))
			{
				return;
			}
			Stack<Point> pixels = new Stack<Point>();
			pixels.Push(pt);

			while (pixels.Count != 0)
			{
				Point temp = pixels.Pop();
				int y1 = temp.Y;

				while (y1 >= 0 && bm.GetPixel(temp.X, y1) == target_color)
				{
					y1--;
				}

				y1++;
				bool span_left = false, span_right = false;

				while (y1 < bm.Height && bm.GetPixel(temp.X, y1) == target_color)
				{
					bm.SetPixel(temp.X, y1, replacement_color);
					if (!span_left && temp.X > 0 && bm.GetPixel(temp.X - 1, y1) == target_color)
					{
						pixels.Push(new Point(temp.X - 1, y1));
						span_left = true;
					}
					else if (span_left && temp.X - 1 == 0 && bm.GetPixel(temp.X - 1, y1) != target_color)
					{
						span_left = false;
					}

					if (!span_right && temp.X < bm.Width - 1 && bm.GetPixel(temp.X + 1, y1) == target_color)
					{
						pixels.Push(new Point(temp.X + 1, y1));
						span_right = true;
					}
					else if (span_right && temp.X < bm.Width - 1 && bm.GetPixel(temp.X + 1, y1) != target_color)
					{
						span_right = false;
					}
					y1++;
				}
			}

			canvas.Image = bm;
		}

		/*
			On %form Key Up
		*/
		private void Lab5Form_KeyUp(object s, KeyEventArgs e)
		{
		}

		private bool SaveAs()
		{
			if (!canvas.Enabled)
			{
				return false;
			}
			var cur_time = DateTime.Now.ToString("hh-mm-ss");
			var dot_pos = _filename.IndexOf('.');
			if (dot_pos != -1)
			{
				sfd.FileName = _filename.Insert(dot_pos, cur_time);
			}
			else
			{
				sfd.FileName = "image.png";
			}
			
			if(sfd.ShowDialog() == DialogResult.OK)
			{
				_filename = sfd.FileName;
				dot_pos = _filename.IndexOf('.');
				string ext;
				if (dot_pos != -1)
				{
					ext = _filename.Substring(dot_pos).ToLower();
				}
				else
				{
					ext = null;
				}

				ImageFormat img_ft;
				switch(ext) 
				{
					case ".png":
						img_ft = ImageFormat.Png;
						break;
					case ".jpeg":
						img_ft = ImageFormat.Jpeg;
						break;
					default:
						img_ft = ImageFormat.Bmp;
						break;
				}

				canvas.Image.Save(_filename, img_ft);
				return true;
			}
			return false;
		}

		private void TsmiSaveAs_Click(object sender, EventArgs e)
		{
			SaveAs();
			if(!isFileSaved)
			{
				isFileSaved = true;
				Text = Text.Substring(1);
			}
		}

		private void TsmiAbout_Click(object sender, EventArgs e)
		{
			if (aboutForm == null || aboutForm.IsDisposed)
			{ 
				aboutForm = new AboutForm();
			}
			aboutForm.SetLabNumber("5").ShowDialog();
		}

		//
		// # RADIO BUTTONS
		//

		private void RbCustomColor_CheckedChanged(object sender, EventArgs e)
		{
			pen.Color = colorDialog.Color;
		}

		private void RbEraserColor_CheckedChanged(object sender, EventArgs e)
		{
			pen.Color = Color.White;
		}

		private void TbThickness_MouseLeave(object sender, EventArgs e)
		{
			if (tbThickness.Focused)
			{
				tbFocusCap.Focus();
			}
		}

		private void ResetBuffer()
		{
			_buffer.Clear();
			_bufferIndex = -1;
		}

		/*
			Создать новый файл
			*/
		private void TsmiNew_Click(object sender, EventArgs e)
		{
			if(isFileOpen && !isFileSaved)
			{
				var dlg_res = MessageBox.Show("Save file?", APP_NAME, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if(dlg_res == DialogResult.Yes)
				{
					// Если сохранили файл
					if(SaveAs())
					{
						// Set image
						if (sizeSetterForm == null)
						{
							sizeSetterForm = new SizeSetterForm();
						}
						var size_dlg_res = sizeSetterForm.Result;
						sizeSetterForm.ShowDialog();
						if (size_dlg_res.State == DialogResult.Yes)
						{
							SetCanvas(size_dlg_res);
						}
					}
				}
				else if(dlg_res == DialogResult.No)
				{
					// Set image
					if (sizeSetterForm == null)
					{
						sizeSetterForm = new SizeSetterForm();
					}

					var size_dlg_res = sizeSetterForm.Result;
					sizeSetterForm.ShowDialog();

					if (size_dlg_res.State == DialogResult.Yes)
					{
						SetCanvas(size_dlg_res);
					}
				}
			}
			else
			{
				if (sizeSetterForm == null) 
				{ 
					sizeSetterForm = new SizeSetterForm();
				}
				do 
				{
					var size_dlg_res = sizeSetterForm.Result;
					sizeSetterForm.ShowDialog();

					switch(size_dlg_res.State) 
					{
						case DialogResult.Yes:
							SetCanvas(size_dlg_res);
							//break;
							return;

						case DialogResult.Cancel:
						case DialogResult.None:
							//return;
							break;
					}
				}
				while (MessageBox.Show("Были введен недопустымый размер.\nПовторить ввод?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
			}
		}

		private void SetCanvas(SizeSetterResult size_setter_res)
		{
			ResetBuffer();
			canvas.Image = new Bitmap(size_setter_res.Width, size_setter_res.Heigth);
			Graphics g = Graphics.FromImage(canvas.Image);
			canvas.Enabled = true;
			g.Clear(Color.White);
			// Buffer stuff
			_buffer.Add(canvas.Image as Bitmap);
			_bufferIndex = 0;
			// UI
			_filename = DEFAULT_FILE_NAME;
			Text = _filename + CAPTURE_RIGHT_SIDE;
			lblBufferSizeValue.Text = _buffer.Count.ToString();
			lblBufferIndexValue.Text = _bufferIndex.ToString();
			// Flags
			isFileSaved = true;
		}

		//
		// # CANVAS
		//

		/*
			On %canvas Paint
		*/
		private void Canvas_Paint(object sender, PaintEventArgs e)
		{
			if (cbSmooth.Checked)
			{
				e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			}

			e.Graphics.DrawEllipse(Pens.Black, penRect.X, penRect.Y, penRect.Width, penRect.Height);

			if (Any(rbRectangle, rbEllipse) && IsLMBDown())
			{
				pen.Width = thickness;
				var rect = new Rectangle(
					Math.Min(canvas_lmbDownPos.X, canvas_mouseMovePos.X),
					Math.Min(canvas_lmbDownPos.Y, canvas_mouseMovePos.Y),
					Math.Abs(canvas_lmbDownPos.X - canvas_mouseMovePos.X),
					Math.Abs(canvas_lmbDownPos.Y - canvas_mouseMovePos.Y));

				if (rbRectangle.Checked)
				{
					e.Graphics.DrawRectangle(pen, rect);
				}
				else if (rbEllipse.Checked)
				{
					e.Graphics.DrawEllipse(pen, rect);
				}
			}
		}

		/*
			On %canvas Mouse Down
		*/
		private void Canvas_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				canvas_lmbDownPos.X = e.X;
				canvas_lmbDownPos.Y = e.Y;
			}
		}

		/*
			On %canvas Mouse Move
		*/
		private void Canvas_MouseMove(object sender, MouseEventArgs e)
		{
			penRect.X = e.X - thickness / 2;
			penRect.Y = e.Y - thickness / 2;
			canvas_mouseMovePos.X = e.X;
			canvas_mouseMovePos.Y = e.Y;

			if (e.Button == MouseButtons.Left)
			{
				// -- Drag
				if (IsCtrlDown())
				{
					canvas.Location = new Point(
						canvas.Location.X + e.X - canvas_lmbDownPos.X, 
						canvas.Location.Y + e.Y - canvas_lmbDownPos.Y);
				}
				// -- Draw
				else if (rbBrush.Checked)
				{
					pen.Width = thickness;
					var g = Graphics.FromImage(canvas.Image);

					if (cbSmooth.Checked)
					{
						g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
					}

					if (thickness > 4)
					{
						CustomDrawLine(canvas_prevLmbDownPos_isActive ? canvas_prevLmbDownPos : new Point(e.X, e.Y), new Point(e.X, e.Y));
					}
					else
					{
						g.DrawLine(pen, canvas_prevLmbDownPos_isActive ? canvas_prevLmbDownPos : new Point(e.X, e.Y), new Point(e.X, e.Y));
					}

					canvas_prevLmbDownPos = new Point(e.X, e.Y);

					if (!canvas_prevLmbDownPos_isActive)
					{
						canvas_prevLmbDownPos_isActive = true;
					}
				}
			}

			canvas.Invalidate();
		}

		private void Canvas_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && !IsCtrlDown())
			{
				canvas_prevLmbDownPos_isActive = false;
				var g = Graphics.FromImage(canvas.Image);
				if (cbSmooth.Checked)
				{
					g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
				}

				// -- Draw
				// Brush
				if (rbBrush.Checked)
				{
					g.FillEllipse(pen.Brush, penRect);
				}
				else if (rbFloodFill.Checked)
				{
					FloodFill(_buffer.Last(), new Point(e.X, e.Y), pen.Color);
				}
				else if (Any(rbRectangle, rbEllipse))
				{
					var rect = new Rectangle(Math.Min(canvas_lmbDownPos.X, canvas_mouseMovePos.X),
						Math.Min(canvas_lmbDownPos.Y, canvas_mouseMovePos.Y),
						Math.Abs(canvas_lmbDownPos.X - canvas_mouseMovePos.X),
						Math.Abs(canvas_lmbDownPos.Y - canvas_mouseMovePos.Y));
					// Rectangle
					if (rbRectangle.Checked)
					{
						if (cbFill.Checked)
						{
							g.FillRectangle(pen.Brush, rect);
						}
						else
						{
							g.DrawRectangle(pen, rect);
						}
					}
					// Ellipse
					else if (rbEllipse.Checked)
					{
						if (cbFill.Checked)
						{
							g.FillEllipse(pen.Brush, rect);
						}
						else
						{
							g.DrawEllipse(pen, rect);
						}
					}
				}

				// Buffer's stuff
				if (_bufferIndex < _buffer.Count - 1 && _buffer.Count > 1)
				{
					_buffer.RemoveRange(_bufferIndex + 1, _buffer.Count - _bufferIndex - 1);
				}

				_buffer.Add(new Bitmap(canvas.Image));
				_bufferIndex++;
				lblBufferSizeValue.Text = _buffer.Count.ToString();
				lblBufferIndexValue.Text = _bufferIndex.ToString();
			}
		}

		/*
			Предотвращает выход картинки за границы панели
			*/
		private void Canvas_LocationChanged(object s, EventArgs e)
		{
			const int limit = 50;
			// Left
			if (canvas.Location.X < limit - canvas.Width)
			{
				canvas.Location = new Point(limit - canvas.Width, canvas.Location.Y);
			}
			// Right
			else if (canvas.Location.X > pnlCanvas.Width - limit)
			{
				canvas.Location = new Point(pnlCanvas.Width - limit, canvas.Location.Y);
			}

			// Top
			if (canvas.Location.Y < limit - canvas.Height)
			{
				canvas.Location = new Point(canvas.Location.X, limit - canvas.Height);
			}
			// Bottom
			else if (canvas.Location.Y > pnlCanvas.Height - limit)
			{
				canvas.Location = new Point(canvas.Location.X, pnlCanvas.Height - limit);
			}
		}
	}
	public static class ListExtension
	{
		public static T Last<T>(this List<T> list) => list[list.Count - 1];
	}
}
