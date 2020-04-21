using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using LiveCharts;
using LiveCharts.Wpf;
using calculator;

namespace s4_tp
{
	public partial class Lab4Form : Form
	{
		public Lab4Form()
		{
			InitializeComponent();
		}
		private void F4Form_Load(object sender, EventArgs e)
		{
			// Init elements
			var table = dgvTable;
			table.ColumnCount = 3;
			table.Columns[0].HeaderText = "ID"; // ID column
			table.Columns[1].HeaderText = "X"; // X column
			table.Columns[2].HeaderText = "Function"; // Function column
			var chart = XFChart;
			// Поле с точками кривой
			chart.Series = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Function = ",
					PointGeometrySize = 30
				}
			};
			// Ось Х
			chart.AxisX.Add(new Axis()
			{
				Title = "X",
				Separator = new Separator
				{
					Step = 1
				}
			});
			// Ось Y
			chart.AxisY.Add(new Axis()
			{
				Title = "Function"
			});

			// START PLACEHOLDERS
			Function_TB.Text = "x^5";
			XStart_TB.Text = "-10";
			XEnd_TB.Text = "10";
			XStep_TB.Text = "1";
		}

		// Go
		private void Go_btn_Click(object sender, EventArgs e)
		{
			dgvTable.Rows.Clear();
			var calc = new Calculator(new char[] { 'x' });
			string func = calc.Prepare(Function_TB.Text);
			double xStart, xEnd, xStep;
			// проверка ввода
			try
			{
				calc.CheckEx(func);
				(xStart, xEnd, xStep) = MinMaxStepToDoubleEx(XStart_TB.Text, XEnd_TB.Text, XStep_TB.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
			// Итеративно заполняем таблицу
			// и рисуем граф по данным таблицы
			var chart = XFChart;
			var func_values = new ChartValues<double>();
			int id = 1;
			string func_prepared; // Строка функции с замещенным "x" и подготовленная для выполнения
			double value; // Вычесленное значение функции
			object pre_value; // Предварительное %value (служит для проверки return'а CalcOrNull() на null)
			for (double x = xStart; x <= xEnd; x += xStep, id++)
			{
				func_prepared = calc.Prepare(func.Replace("x", x.ToString()));
				pre_value = CalcOrNull(func_prepared, calc);
				if(pre_value != null)
				{
					value = (double)pre_value;
					dgvTable.Rows.Add(id, x, value);
					func_values.Add(value);
				}
			}
			chart.Series[0].Values = func_values;
		}

		// возвращает кортеж или бросает исключение
		private (double, double, double) MinMaxStepToDoubleEx(string start_s, string end_s, string step_s)
		{
			double start = double.Parse(start_s),
				end = double.Parse(end_s),
				step = double.Parse(step_s);
			string ex_str = "Bad left-right-step touple";
			if (start == end)
				throw new Exception(ex_str);
			// left to right movement
			if (start < end && step <= 0)
				throw new Exception(ex_str);
			// right to left movement
			if (start > end && step >= 0)
				throw new Exception(ex_str);
			return (start, end, step);
		}

		private object CalcOrNull(string function, Calculator calc)
		{
			if (calc.Check(function))
			{
				try
				{
					var result = calc.Execute(function);
					return result;
				}
				catch (Exception)
				{
					return null;
				}
			}
			else
				return null;
		}

		// сохранить данные в XML файле
		private void SaveData_btn_Click(object sender, EventArgs e)
		{
			SaveFD.ShowDialog();
		}

		// SAVE FILE
		private void SaveFD_FileOk(object sender, CancelEventArgs e)
		{
			using (var writer = new System.IO.StreamWriter(SaveFD.FileName))
			{
				var data = new Lab4Data(
					Function_TB.Text,
					XStart_TB.Text,
					XEnd_TB.Text,
					XStep_TB.Text,
					GetDataFrom(dgvTable),
					GetDataFrom(XFChart));
				new XmlSerializer(data.GetType()).Serialize(writer, data);
			}
		}

		private void OpenFD_FileOk(object sender, CancelEventArgs e)
		{
			try
			{
				Lab4Data data;
				using (var reader = File.OpenText(OpenFD.FileName))
				{
					data = (Lab4Data)new XmlSerializer(typeof(Lab4Data)).Deserialize(reader);
				}
				SetData(data);
			}
			catch (Exception)
			{
				MessageBox.Show($"Failed to get data from file {OpenFD.FileName}");
			}
		}

		// LOAD FILE
		// Взять данные (объект) из XML файла
		// с помощью полученного объекта (F4Data) инициализирует соответсвтвующие свойства элементов формы
		private void LoadData_btn_Click(object sender, EventArgs e)
		{
			OpenFD.ShowDialog();
		}

		private void SetData(Lab4Data data)
		{
			ClearOutput();
			Function_TB.Text = data.Function;
			XStart_TB.Text = data.XStart;
			XEnd_TB.Text = data.XEnd;
			XStep_TB.Text = data.XStep;
			foreach (var row in data.Rows)
				dgvTable.Rows.Add(row);
			foreach (var value in data.Series)
				XFChart.Series[0].Values.Add(value);
		}

		// Очистить данные формы (кроме полей ввода)
		private void ClearOutput()
		{
			dgvTable.Rows.Clear();
			XFChart.Series[0].Values.Clear();
		}

		private string[][] GetDataFrom(DataGridView table)
		{
			string[][] ret = new string[table.Rows.Count][];
			for (int row = 0; row < table.Rows.Count; row++)
			{
				ret[row] = new string[3];
				for (int col = 0; col < table.Columns.Count; col++)
					ret[row][col] = table.Rows[row].Cells[col].Value.ToString();
			}
			return ret;
		}
		private double[] GetDataFrom(CartesianChart chart)
		{
			double[] ret = new double[chart.Series[0].Values.Count];
			for (int i = 0; i < chart.Series[0].Values.Count; i++)
				ret[i] = (double)chart.Series[0].Values[i];
			return ret;
		}

		private void Clear_btn_Click(object sender, EventArgs e)
		{
			ClearOutput();
		}
	}

	[Serializable]
	public class Lab4Data
	{
		// Поля ввода
		public string Function;
		public string XStart;
		public string XEnd;
		public string XStep;
		// Таблица
		public string[][] Rows;
		// График
		public double[] Series;
		public Lab4Data()
		{ }

		public Lab4Data(
			string function, 
			string x_start, 
			string x_end, 
			string x_step, 
			string[][] rows, 
			double[] series)
		{
			Function = function;
			XStart = x_start;
			XEnd = x_end;
			XStep = x_step;
			Rows = rows;
			Series = series;
		}
	}
}
