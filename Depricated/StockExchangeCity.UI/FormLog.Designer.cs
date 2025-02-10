namespace StockExchangeCity.UI
{
	partial class FormLog
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
			panel2 = new Panel();
			TextLog = new TextBox();
			panel1 = new Panel();
			BtClear = new Button();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.Controls.Add(TextLog);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 0);
			panel2.Name = "panel2";
			panel2.Padding = new Padding(10);
			panel2.Size = new Size(897, 591);
			panel2.TabIndex = 3;
			// 
			// TextLog
			// 
			TextLog.BackColor = SystemColors.Info;
			TextLog.Dock = DockStyle.Fill;
			TextLog.Location = new Point(10, 10);
			TextLog.Multiline = true;
			TextLog.Name = "TextLog";
			TextLog.ReadOnly = true;
			TextLog.ScrollBars = ScrollBars.Vertical;
			TextLog.Size = new Size(877, 571);
			TextLog.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(BtClear);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 591);
			panel1.Name = "panel1";
			panel1.Size = new Size(897, 39);
			panel1.TabIndex = 2;
			// 
			// BtClear
			// 
			BtClear.Location = new Point(12, 6);
			BtClear.Name = "BtClear";
			BtClear.Size = new Size(94, 29);
			BtClear.TabIndex = 0;
			BtClear.Text = "Очистить";
			BtClear.UseVisualStyleBackColor = true;
			BtClear.Click += BtClear_Click;
			// 
			// FormLog
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(897, 630);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FormLog";
			Text = "Лог";
			FormClosing += FormLog_FormClosing;
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private TextBox TextLog;
		private Panel panel1;
		private Button BtClear;
	}
}