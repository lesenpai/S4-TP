using System;
using System.Drawing;
using System.Windows.Forms;
using calculator; 

namespace s4_tp
{
	public partial class Lab1Form : Form
	{
		private Calculator Calc = new Calculator();
		public Lab1Form()
		{
			InitializeComponent();
		}
		private void OnGotFocus(object sender, EventArgs e)
		{

		}
		private void F1_form_Load(object sender, EventArgs e)
		{
			KeyPreview = true;
			Color bg_color = Color.FromArgb(40, 41, 35);
			Color font_color = Color.FromArgb(192, 192, 192);
			Color mouse_hover_color = Color.FromArgb(45, 45, 48);
			Color mouse_down_color = Color.FromArgb(52, 52, 55);
			BackColor = bg_color;
			ForeColor = font_color;
			foreach (Control c in Controls)
			{
				c.BackColor = BackColor;
				if (c is TextBox)
				{
					(c as TextBox).BorderStyle = BorderStyle.None;
					(c as TextBox).ForeColor = font_color;
				}
			}
			foreach (Button b in Buttons_tlp.Controls)
			{
				b.BackColor = BackColor;
				b.FlatAppearance.BorderColor = Color.Red;
				b.FlatAppearance.MouseDownBackColor = mouse_down_color;
				b.FlatAppearance.MouseOverBackColor = mouse_hover_color;
				b.FlatStyle = FlatStyle.Flat;
				b.FlatAppearance.BorderSize = 0;
				b.TabStop = false;
				b.UseVisualStyleBackColor = false;
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys key_data)
		{
			switch (key_data)
			{
				case Keys.Enter:
					Btn_equal.PerformClick();
					return true;
			}
			return base.ProcessCmdKey(ref msg, key_data);
		}

		private void Lab1Form_KeyDown(object sender, KeyEventArgs e)
		{
			Keys kc = e.KeyCode;
			switch (e.KeyCode)
			{
				case Keys.D0:
				case Keys.NumPad0:
					if (e.Shift)
						Btn_closeBracket.PerformClick();
					else
						Btn_0.PerformClick();
					break;
				case Keys.D1:
				case Keys.NumPad1:
					Btn_1.PerformClick();
					break;
				case Keys.D2:
				case Keys.NumPad2:
					Btn_2.PerformClick();
					break;
				case Keys.D3:
				case Keys.NumPad3:
					Btn_3.PerformClick();
					break;
				case Keys.D4:
				case Keys.NumPad4:
					Btn_4.PerformClick();
					break;
				case Keys.D5:
				case Keys.NumPad5:
					Btn_5.PerformClick();
					break;
				/* "^" */
				case Keys.D6:
				case Keys.NumPad6:
					if (e.Shift)
						Btn_power.PerformClick();
					else
						Btn_6.PerformClick();
					break;
				case Keys.D7:
				case Keys.NumPad7:
					Btn_7.PerformClick();
					break;
				case Keys.D8:
				case Keys.NumPad8:
					Btn_8.PerformClick();
					break;
				case Keys.D9:
				case Keys.NumPad9:
					if (e.Shift)
						Btn_openBracket.PerformClick();
					else
						Btn_9.PerformClick();
					break;
				case Keys.Escape:
					Btn_clear.PerformClick();
					break;
				case Keys.Enter:
					Btn_equal.PerformClick();
					break;
				case Keys.Add:
					Btn_plus.PerformClick();
					break;
				case Keys.Subtract:
					Btn_minus.PerformClick();
					break;
				case Keys.Multiply:
					Btn_mul.PerformClick();
					break;
				case Keys.Divide:
					Btn_div.PerformClick();
					break;
				case Keys.Back:
					Btn_backspace.PerformClick();
					var expr = Expression_tb;
					var result = Result_tb;
					string prep_expr = Calc.Prepare(expr.Text);
					if (Calc.TryExecute(prep_expr, out double res))
						result.Text = res.ToString();
					else
						result.Text = "";
					break;
			}
			if (e.Shift && kc == Keys.Oemplus)
				Btn_plus.PerformClick();
			else if (e.Shift && kc == Keys.OemMinus)
				Btn_minus.PerformClick();
		}

		/*
			выражение = Calculator.prepare(выражение)
			если выражение верно: записать его результат в выражение
			иначе: записать ошибку в результат
		*/
		private void Btn_equal_Click(object sender, EventArgs e)
		{
			var expr = Expression_tb;
			double res;
			if (Calc.TryExecute(Calc.Prepare(expr.Text), out res))
			{
				expr.Text = res.ToString();
				Result_tb.Text = "";
			}
			else
				Result_tb.Text = "Invalid input";
		}

		private void SyncTexts()
		{
			var expr = Expression_tb;
			var result = Result_tb;
			string prep_expr = Calc.Prepare(expr.Text);
			if (Calc.TryExecute(prep_expr, out double res))
				result.Text = res.ToString();
			else
				result.Text = "";
		}

		/* добавляет символ в строку выражения */
		/* 
			выражение = Calculator.prepare(выражение)
			если выражение верно: записать его в результат
		*/
		private void WriteToExpr(char ch)
		{
			var expr = Expression_tb;
			expr.Text += ch;
			SyncTexts();
		}

		private void Clear()
		{
			Expression_tb.Text = "";
			Result_tb.Text = "";
		}

		private void BackSpace()
		{
			var t = Expression_tb.Text;
			if (t.Length > 0)
			{
				t = t.Substring(0, t.Length - 1);
				Expression_tb.Text = t;
				SyncTexts();
			}
		}

		private void Btn_backspace_Click(object sender, EventArgs e)
		{
			BackSpace();
		}

		private void InsertionButton_Click(object sender, EventArgs e)
		{
			WriteToExpr((sender as Button).Text[0]);
		}
	}
}
