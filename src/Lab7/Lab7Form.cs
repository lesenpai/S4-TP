using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace S4_TP.Lab7
{
	public partial class Lab7Form : Form
	{
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
		// Flags
		private bool isFileOpen = false,
					 isFileSaved = true;

		// UI constants
		private const string APP_NAME = "Lab 7: Brightness";

		private Bitmap sourceImage;
		private double currentBrightCoeff = 1;
		
		public Lab7Form()
		{
			InitializeComponent();
		}

		private static bool IsShiftDown()
		{
			return (ModifierKeys & Keys.Shift) == Keys.Shift;
		}

		private void Lab7Form_Load(object sender, EventArgs e)
		{
			PB_Canvas.Enabled = false;
			Btn_ApplyBright.Enabled = false;
		}

		private void TSMI_File_Open_Click(object sender, EventArgs e)
		{
			// Если есть не сохранённые изменения
			if (isFileOpen && !isFileSaved)
			{
				var question_save_result = MessageBox.Show("Есть не сохранённые изменения. Сохранить?", APP_NAME,
								MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
				if (question_save_result == DialogResult.OK)
				{
					SaveAs();
				}
			}
			OFD_Dialog.ShowDialog();
		}

		private void SaveAs()
		{
			SFD_Dialog.ShowDialog();
		}

		private void TSMI_File_SaveAs_Click(object sender, EventArgs e)
		{
			SFD_Dialog.FileName = SFD_Dialog.DefaultExt;
			SaveAs();
		}

		private void SFD_Dialog_FileOk(object sender, CancelEventArgs e)
		{
			if(!PB_Canvas.Enabled)
			{
				return;
			}

			string ext = Path.GetExtension(SFD_Dialog.FileName);
			ImageFormat ft;
			switch(ext)
			{
				case ".png":
					ft = ImageFormat.Png;
					break;
				case ".jpeg":
					ft = ImageFormat.Jpeg;
					break;
				case ".bmp":
					ft = ImageFormat.Bmp;
					break;
				default:
					MessageBox.Show("Неизвестный формат изображения", APP_NAME,
									MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
			}

			PB_Canvas.Image.Save(SFD_Dialog.FileName, ft);
			// Flags
			isFileSaved = true;
		}

		private void OFD_Dialog_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				/* Data, UI */
				sourceImage	= new Bitmap(OFD_Dialog.FileName);
				PB_Canvas.Image = sourceImage;
			}
			catch (Exception ex)
			{
				isFileOpen = false;
				MessageBox.Show(ex.Message);
				return;
			}

			/* UI */
			PB_Canvas.Enabled = true;
			Btn_ApplyBright.Enabled = true;
			TSMI_File_SaveAs.Enabled = true;
			/* Flags */
			isFileOpen = true;
			isFileSaved = true;
		}

		private void Btn_ApplyBright_Click(object sender, EventArgs e)
		{
			if(!PB_Canvas.Enabled)
			{
				return;
			}

			double k;
			if (!(double.TryParse(TB_BrightCoeff.Text, out k)
				  && k > 0))
			{
				MessageBox.Show("Неверно задан коэффициент яркости.", APP_NAME,
					            MessageBoxButtons.OK, MessageBoxIcon.Error);
				TB_BrightCoeff.Text = currentBrightCoeff.ToString();
				return;
			}

			currentBrightCoeff = double.Parse(TB_BrightCoeff.Text);
			PB_Canvas.Image = BrightnessProcess(sourceImage, k);
			// Flags
			isFileSaved = false;
		}

		private Bitmap BrightnessProcess(Bitmap src, double k)
		{
			if(k == 1)
			{
				return src;
			}

			var res = new Bitmap(src.Width, src.Height);
			Color pixel_clr;
			// UI, Data
			PB_BrightConvertProgress.Maximum = res.Height;
			PB_BrightConvertProgress.Value = 0;
			PB_BrightConvertProgress.Visible = true;

			if (k <= 1)
			{
				for(int row = 0; row < res.Height; row++)
				{
					for(int col = 0; col < res.Width; col++)
					{
						pixel_clr = src.GetPixel(col, row);
						res.SetPixel(col, row, 
							         Color.FromArgb((int)(pixel_clr.R * k), (int)(pixel_clr.G * k), (int)(pixel_clr.B * k)));
					}
					// UI
					PB_BrightConvertProgress.Increment(1);
				}
			}
			else
			{
				for (int row = 0; row < res.Height; row++) 
				{
					for (int col = 0; col < res.Width; col++) 
					{
						pixel_clr = src.GetPixel(col, row);
						var q_m = (new []{ pixel_clr.R, pixel_clr.G, pixel_clr.B}).Max();
						var q_m1 = k * q_m;
						var k_tmp = k;
						if(q_m1 > 255) 
						{
							k_tmp = 255d / q_m;
						}
						res.SetPixel(col, row, 
							         Color.FromArgb((int)(pixel_clr.R * k_tmp), (int)(pixel_clr.G * k_tmp), (int)(pixel_clr.B * k_tmp)));
					}
					// UI
					PB_BrightConvertProgress.Increment(1);
				}
			}
			// UI
			PB_BrightConvertProgress.Hide();

			return res;
		}
	}
}
