using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace S4_TP.Lab6
{
	/* 
		--- Key Bindings ---

		...
	*/
	public partial class Lab6Form : Form
	{
		/* Flags */
		private bool isFileOpen = false,
					 isFileSaved = true;

		//private string fileName;

		/* UI constants */
		private const string APP_NAME = "Lab-6: Grayscaler";

		private const double R_FACTOR_OLD = 0.299,
			                 G_FACTOR_OLD = 0.587,
			                 B_FACTOR_OLD = 0.114,

							 R_FACTOR_NEW = 0.2126,
							 G_FACTOR_NEW = 0.7152,
							 B_FACTOR_NEW = 0.0722;

		public Lab6Form()
		{
			InitializeComponent();
		}

		private void Lab6Form_Load(object sender, EventArgs e)
		{
			PB_canvas.Enabled = false;
			Btn_BlackWhite.Enabled = false;
		}

		private static bool IsShiftDown()
		{
			return (ModifierKeys & Keys.Shift) == Keys.Shift;
		}

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
				else
				{
					base.OnMouseWheel(e);
				}
			}
		}

		private void Btn_blackWhite_Click(object sender, EventArgs e)
		{
			if(!PB_canvas.Enabled)
			{
				return;
			}
			/* Если нужно сохранить полученный файл *//*
			if(isFileOpen && !isFileSaved) 
			{
				var question_save_result = MessageBox.Show("Есть не сохранённые изменения. Сохранить?", APP_NAME,
					            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if(question_save_result == DialogResult.OK) 
				{
					SaveAs();
				}
			}*/
			PB_canvas.Image = BlackWhiteBitmap((Bitmap)PB_canvas.Image);
		}

		private Bitmap BlackWhiteBitmap(Bitmap src)
		{
			Bitmap res = new Bitmap(src.Width, src.Height);
			// Множители компонентов
			double rk = default, gk = default, bk = default;
			if(RB_oldStdSetOfBrightnessFactors.Checked)
			{
				rk = R_FACTOR_OLD;
				gk = G_FACTOR_OLD;
				bk = B_FACTOR_OLD;
			}
			else if (RB_newStdSetOfBrightnessFactors.Checked)
			{
				rk = R_FACTOR_NEW;
				gk = G_FACTOR_NEW;
				bk = B_FACTOR_NEW;
			}
			int y;
			Color pixel_clr;
			PB_BWConvertProgress.Maximum = res.Height;
			PB_BWConvertProgress.Value = 0;
			// UI
			PB_BWConvertProgress.Visible = true;

			for(int row_i = 0; row_i < res.Height; row_i++)
			{
				for(int col_i = 0; col_i < res.Width; col_i++)
				{
					pixel_clr = src.GetPixel(col_i, row_i);
					y = (int)Math.Round(rk * pixel_clr.R + gk * pixel_clr.G + bk * pixel_clr.B);
					res.SetPixel(col_i, row_i, Color.FromArgb(y, y, y));
				}
				PB_BWConvertProgress.Increment(1);
			}
			PB_BWConvertProgress.Hide();
			return res;
		}

		private void SaveAs() 
		{
			SFD_dialog.ShowDialog();
		}

		
		private void SFD_dialog_FileOk(object sender, CancelEventArgs e)
		{
			if(!PB_canvas.Enabled) 
			{
				return;
			}

			string file_ext;
			file_ext = Path.GetExtension(SFD_dialog.FileName);
			ImageFormat img_ft;
			switch(file_ext) 
			{
				case ".png":
					img_ft = ImageFormat.Png;
					break;
				case ".jpeg":
					img_ft = ImageFormat.Jpeg;
					break;
				case ".bmp":
					img_ft = ImageFormat.Bmp;
					break;
				default:
					MessageBox.Show("Неизвестный формат изображения", APP_NAME,
						            MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}

			PB_canvas.Image.Save(SFD_dialog.FileName, img_ft);
			/* Flags */
			isFileSaved = true;
		}

		private void TSMI_file_open_Click(object sender, EventArgs e)
		{
			OFD_dialog.ShowDialog();
		}

		
		private void OFD_dialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				/* Data */
				PB_canvas.Image = new Bitmap(OFD_dialog.FileName);
			}
			catch (Exception ex)
			{
				isFileOpen = false;
				MessageBox.Show(ex.Message);
				return;
			}

			/* UI */
			PB_canvas.Enabled = true;
			Btn_BlackWhite.Enabled = true;
			TSMI_file_saveAs.Enabled = true;
			/* Flags */
			isFileOpen = true;
			isFileSaved = true;
		}

		private void TSMI_file_saveAs_Click(object sender, EventArgs e)
		{
			SFD_dialog.FileName = SFD_dialog.DefaultExt;
			SaveAs();
		}
	}

	
}

