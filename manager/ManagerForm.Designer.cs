namespace s4_tp
{
	partial class ManagerForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.ShowL1_btn = new System.Windows.Forms.Button();
			this.ShowL2_btn = new System.Windows.Forms.Button();
			this.ShowFTest_btn = new System.Windows.Forms.Button();
			this.ShowL3_btn = new System.Windows.Forms.Button();
			this.ShowL4_btn = new System.Windows.Forms.Button();
			this.ShowL5_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ShowL1_btn
			// 
			this.ShowL1_btn.Location = new System.Drawing.Point(13, 13);
			this.ShowL1_btn.Name = "ShowL1_btn";
			this.ShowL1_btn.Size = new System.Drawing.Size(110, 48);
			this.ShowL1_btn.TabIndex = 0;
			this.ShowL1_btn.Text = "Lab 1";
			this.ShowL1_btn.UseVisualStyleBackColor = true;
			this.ShowL1_btn.Click += new System.EventHandler(this.ShowFormX_btn_Click);
			// 
			// ShowL2_btn
			// 
			this.ShowL2_btn.Location = new System.Drawing.Point(129, 13);
			this.ShowL2_btn.Name = "ShowL2_btn";
			this.ShowL2_btn.Size = new System.Drawing.Size(110, 48);
			this.ShowL2_btn.TabIndex = 1;
			this.ShowL2_btn.Text = "Lab 2";
			this.ShowL2_btn.UseVisualStyleBackColor = true;
			this.ShowL2_btn.Click += new System.EventHandler(this.ShowFormX_btn_Click);
			// 
			// ShowFTest_btn
			// 
			this.ShowFTest_btn.Location = new System.Drawing.Point(328, 13);
			this.ShowFTest_btn.Name = "ShowFTest_btn";
			this.ShowFTest_btn.Size = new System.Drawing.Size(110, 48);
			this.ShowFTest_btn.TabIndex = 2;
			this.ShowFTest_btn.Text = "Test";
			this.ShowFTest_btn.UseVisualStyleBackColor = true;
			this.ShowFTest_btn.Click += new System.EventHandler(this.ShowFormX_btn_Click);
			// 
			// ShowL3_btn
			// 
			this.ShowL3_btn.Location = new System.Drawing.Point(13, 67);
			this.ShowL3_btn.Name = "ShowL3_btn";
			this.ShowL3_btn.Size = new System.Drawing.Size(110, 48);
			this.ShowL3_btn.TabIndex = 3;
			this.ShowL3_btn.Text = "Lab 3";
			this.ShowL3_btn.UseVisualStyleBackColor = true;
			this.ShowL3_btn.Click += new System.EventHandler(this.ShowFormX_btn_Click);
			// 
			// ShowL4_btn
			// 
			this.ShowL4_btn.Enabled = false;
			this.ShowL4_btn.Location = new System.Drawing.Point(129, 67);
			this.ShowL4_btn.Name = "ShowL4_btn";
			this.ShowL4_btn.Size = new System.Drawing.Size(110, 48);
			this.ShowL4_btn.TabIndex = 4;
			this.ShowL4_btn.Text = "Lab 4";
			this.ShowL4_btn.UseVisualStyleBackColor = true;
			this.ShowL4_btn.Click += new System.EventHandler(this.ShowFormX_btn_Click);
			// 
			// ShowL5_btn
			// 
			this.ShowL5_btn.Location = new System.Drawing.Point(13, 121);
			this.ShowL5_btn.Name = "ShowL5_btn";
			this.ShowL5_btn.Size = new System.Drawing.Size(110, 48);
			this.ShowL5_btn.TabIndex = 5;
			this.ShowL5_btn.Text = "Lab 5";
			this.ShowL5_btn.UseVisualStyleBackColor = true;
			this.ShowL5_btn.Click += new System.EventHandler(this.ShowFormX_btn_Click);
			// 
			// ManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(465, 278);
			this.Controls.Add(this.ShowL5_btn);
			this.Controls.Add(this.ShowL4_btn);
			this.Controls.Add(this.ShowL3_btn);
			this.Controls.Add(this.ShowFTest_btn);
			this.Controls.Add(this.ShowL2_btn);
			this.Controls.Add(this.ShowL1_btn);
			this.Name = "ManagerForm";
			this.Text = "S4. TP. All";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ShowL1_btn;
		private System.Windows.Forms.Button ShowL2_btn;
		private System.Windows.Forms.Button ShowFTest_btn;
		private System.Windows.Forms.Button ShowL3_btn;
		private System.Windows.Forms.Button ShowL4_btn;
		private System.Windows.Forms.Button ShowL5_btn;
	}
}

