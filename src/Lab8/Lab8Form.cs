using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace S4_TP.Lab8
{
	public partial class Lab8Form : Form
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
		private const string APP_NAME = "Lab 8: Contrast";

		private Bitmap sourceImage;
		private double currentContrastCoeff = 1;

		public Lab8Form()
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
			Btn_ApplyContrast.Enabled = false;
		}

		private void TSMI_File_Open_Click(object sender, EventArgs e)
		{
			// Если есть не сохранённые изменения
			if (isFileOpen && !isFileSaved)
			{
				var question_save_result = MessageBox.Show(
					"Есть не сохранённые изменения. Сохранить?",
					APP_NAME,
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
			if (!PB_Canvas.Enabled)
			{
				return;
			}

			string ext = Path.GetExtension(SFD_Dialog.FileName);
			ImageFormat ft;
			switch (ext)
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
				sourceImage = new Bitmap(OFD_Dialog.FileName);
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
			Btn_ApplyContrast.Enabled = true;
			TSMI_File_SaveAs.Enabled = true;
			/* Flags */
			isFileOpen = true;
			isFileSaved = true;
		}

		private void Btn_ApplyContrast_Click(object sender, EventArgs e)
		{
			if (!PB_Canvas.Enabled)
			{
				return;
			}

			float k;
			if (!float.TryParse(TB_ContrastCoeff.Text, out k)) 
			{
				MessageBox.Show("Неверно задан коэффициент контрастности.", APP_NAME,
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				TB_ContrastCoeff.Text = currentContrastCoeff.ToString();
				return;
			}

			currentContrastCoeff = double.Parse(TB_ContrastCoeff.Text);
			PB_Canvas.Image = ContrastProcess(sourceImage, k);
			// Flags
			isFileSaved = false;
		}

		public Bitmap ContrastProcess(Bitmap src, float k)
		{
			void BalanceRgbComponent(ref int component)
			{
				if (component < 0)
				{
					component = 0;
				}
				else if (component > 255)
				{
					component = 255;
				}
			}

			void ProcessRgbComponent(ref byte component)
			{
				float f_c = component / 255f;
				f_c = (((f_c - 0.5f) * k) + 0.5f) * 255f;
				int i_c = (int)f_c;
				BalanceRgbComponent(ref i_c);

				component = (byte)i_c;
			}

			Bitmap res = (Bitmap)src.Clone();
			
			if (k == 1)
			{ 
				return res;
			}

			k = (100f + k) / 100f;
			k *= k;

			BitmapData data = res.LockBits(
				new Rectangle(0, 0, res.Width, res.Height),
				ImageLockMode.ReadWrite,
				PixelFormat.Format32bppArgb);

			IntPtr ptr = data.Scan0;
			int bytes_count = Math.Abs(data.Stride) * data.Height;
			byte[] rgb_values = new byte[bytes_count];
			// UI, Data
			PB_ContrastProcessProgress.Maximum = res.Height;
			PB_ContrastProcessProgress.Value = 0;
			PB_ContrastProcessProgress.Visible = true;

			System.Runtime.InteropServices.Marshal.Copy(ptr, rgb_values, 0, bytes_count);
			
			/* Processing start */

			// ARGB = bytes [B, G, R, A]
			for (int offset = 0; offset < rgb_values.Length; offset += 4)
			{
				ProcessRgbComponent(ref rgb_values[offset + 2]); // R
				ProcessRgbComponent(ref rgb_values[offset + 1]); // G
				ProcessRgbComponent(ref rgb_values[offset]); // B

				if (offset != 0 && offset % data.Stride == 0)
				{
					PB_ContrastProcessProgress.Increment(1);
				}
			}

			/* Processing end */

			System.Runtime.InteropServices.Marshal.Copy(rgb_values, 0, ptr, bytes_count);

			res.UnlockBits(data);
			// UI
			PB_ContrastProcessProgress.Hide();

			return res;
		}
	}
}
