namespace StockExchangeCity
{
	partial class FormConnect
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
			panel1 = new Panel();
			BtConnect = new Button();
			TextToken = new TextBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(BtConnect);
			panel1.Controls.Add(TextToken);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(10, 10);
			panel1.Name = "panel1";
			panel1.Size = new Size(631, 230);
			panel1.TabIndex = 2;
			// 
			// BtConnect
			// 
			BtConnect.Location = new Point(423, 39);
			BtConnect.Name = "BtConnect";
			BtConnect.Size = new Size(144, 29);
			BtConnect.TabIndex = 3;
			BtConnect.Text = "Подключиться";
			BtConnect.UseVisualStyleBackColor = true;
			BtConnect.Click += BtConnect_Click;
			// 
			// TextToken
			// 
			TextToken.Location = new Point(78, 40);
			TextToken.Name = "TextToken";
			TextToken.Size = new Size(323, 27);
			TextToken.TabIndex = 2;
			TextToken.Text = "hash";
			// 
			// FormConnect
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(651, 253);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "FormConnect";
			Padding = new Padding(10);
			StartPosition = FormStartPosition.CenterParent;
			Text = "Подключение";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button BtConnect;
		private TextBox TextToken;
	}
}