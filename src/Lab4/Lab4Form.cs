using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using System.IO;
using S4_TP.Lab4.Data;
using Utils.Calculator;

namespace S4_TP.Lab4
{
	public partial class Lab4Form : Form
	{
		public const string _REPLACEABLE_CHARACTER = "x";
		private readonly Calculator _calc = new Calculator(_REPLACEABLE_CHARACTER[0]);
		private const string _WARNING_DIALOG_CAPTION = "Внимание";

		public Lab4Form()
		{
			InitializeComponent();
			table.ColumnCount = 3;
			table.Columns[0].HeaderText = "ID"; // ID column
			table.Columns[1].HeaderText = "X"; // X column
			table.Columns[2].HeaderText = "Function"; // Function column
			var series0 = chart.Series[0];
			series0.IsVisibleInLegend = false;
			series0.ChartType = SeriesChartType.Line;
			series0.Color = Color.FromArgb(0, 120, 215);
			series0.BorderWidth = 2;
			chart.ChartAreas[0].AxisX.LabelStyle.Format = "0.00";
			chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.000";
		}

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			ClearUIOutput();
			// Валидировать input'ы
			var result = ValidateInput();
			if(result.Success)
			{
				/* Введенные данные корректны */
				double x_step = (result.XMax - result.XMin) / result.XStepsNumber;
				int id = 0;
				// UI
				lblXStepValue.Text = x_step.ToString("N2");
				for(double x = result.XMin; x <= result.XMax; x += x_step, id++)
				{
					double value;
					if(_calc.TryExecute(result.Function.Replace(_REPLACEABLE_CHARACTER, x.ToString()), out value)
						&& IsNormalDouble(value))
					{
						table.Rows.Add(id, x.ToString("0.00"), value.ToString("0.000"));
						chart.Series[0].Points.AddXY(x, value);
					}
					// Запишем в таблицу null, в график - ничего
					else
					{
						table.Rows.Add(id, x, null);
					}
				}
			}
			else
			{
				MessageBox.Show("Введены некорректные данные", _WARNING_DIALOG_CAPTION, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private bool IsNormalDouble(double value)
		{
			return !double.IsNaN(value) && !double.IsInfinity(value);
		}

		ValidationResult ValidateInput()
		{
			ValidationResult result = new ValidationResult();
			try
			{
				result.Function = tbFunction.Text;
				result.XMin = double.Parse(tbXMin.Text);
				result.XMax = double.Parse(tbXMax.Text);
				result.XStepsNumber = int.Parse(tbXStepsNumber.Text);
				/* Проверка функции */
				_calc.CheckEx(result.Function);
				/* Проверка x_min, x_max, x_steps_number */
				if(result.XMin >= result.XMax
					|| result.XStepsNumber <= 0)
				{
					throw new Exception();
				}
				result.Success = true;
			}
			catch(Exception) 
			{
				result.Success = false;
			}

			return result;
		}

		private void SetData(Lab4Data data)
		{
			ClearUIOutput();
			for(int i = 0; i < data.Points.Count; i++)
			{
				table.Rows.Add(i, data.Points[i].X.ToString("0.00"), data.Points[i].F.ToString("0.000"));
				chart.Series[0].Points.AddXY(data.Points[i].X, data.Points[i].F);
			}
		}

		private void BtnClear_Click(object sender, EventArgs e)
		{
			ClearUIOutput();	
		}

		private void ClearUIOutput()
		{
			table.Rows.Clear();
			chart.Series[0].Points.Clear();
			lblXStepValue.Text = "...";
		}

		private void ChbChartSmoothing_CheckedChanged(object sender, EventArgs e)
		{
			if((sender as CheckBox).Checked)
			{
				chart.Series[0].ChartType = SeriesChartType.Spline;
			}
			else
			{
				chart.Series[0].ChartType = SeriesChartType.Line;
			}
		}

		private void TsmiLoad_Click(object sender, EventArgs e)
		{
			ofd.ShowDialog(); // --> Ofd_FileOk()
		}

		private void Ofd_FileOk(object sender, CancelEventArgs e)
		{
			// Прочитать набор точек из файла (.lab4xml)
			try
			{
				Lab4Data data;
				using (var reader = File.OpenText(ofd.FileName))
				{
					data = (Lab4Data)new XmlSerializer(typeof(Lab4Data)).Deserialize(reader);
				}
				SetData(data);
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void TsmiExport_Click(object sender, EventArgs e)
		{
			sfd.ShowDialog(); // --> Sfd_FileOk()
		}

		/* Записать массив точек и ID в xml файл (.lab4xml) */
		private void Sfd_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				using (var writer = new StreamWriter(sfd.FileName)) 
				{
					var data = new Lab4Data();
					const int x_col_index = 1, f_col_index = 2;

					foreach(DataGridViewRow row in table.Rows) 
					{
						data.Add(
							double.Parse(row.Cells[x_col_index].Value.ToString()),
							double.Parse(row.Cells[f_col_index].Value.ToString())
							);
					}

					new XmlSerializer(data.GetType()).Serialize(writer, data);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Не удалось сохранить файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
