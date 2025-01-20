namespace StockExchangeCity.Tool.MapEditor
{
	partial class Desktop
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			TabbarEditor = new TabControl();
			TabMapEditor = new TabPage();
			SplitContainerMapGen = new SplitContainer();
			ListBiomes = new ListBox();
			panel1 = new Panel();
			PanelBiomeColor = new Panel();
			TxtColor = new TextBox();
			TxtHumedityMax = new TextBox();
			TxtHumedityMin = new TextBox();
			TxtTempMax = new TextBox();
			TxtTempMin = new TextBox();
			TxtHeightMax = new TextBox();
			TxtHeightMin = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			ColorBiome = new ColorDialog();
			TabbarEditor.SuspendLayout();
			TabMapEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainerMapGen).BeginInit();
			SplitContainerMapGen.Panel2.SuspendLayout();
			SplitContainerMapGen.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// TabbarEditor
			// 
			TabbarEditor.Appearance = TabAppearance.FlatButtons;
			TabbarEditor.Controls.Add(TabMapEditor);
			TabbarEditor.Dock = DockStyle.Fill;
			TabbarEditor.Location = new Point(0, 0);
			TabbarEditor.Name = "TabbarEditor";
			TabbarEditor.SelectedIndex = 0;
			TabbarEditor.Size = new Size(1417, 686);
			TabbarEditor.TabIndex = 1;
			// 
			// TabMapEditor
			// 
			TabMapEditor.Controls.Add(SplitContainerMapGen);
			TabMapEditor.Location = new Point(4, 32);
			TabMapEditor.Name = "TabMapEditor";
			TabMapEditor.Padding = new Padding(3);
			TabMapEditor.Size = new Size(1409, 650);
			TabMapEditor.TabIndex = 0;
			TabMapEditor.Text = "Карта";
			TabMapEditor.UseVisualStyleBackColor = true;
			// 
			// SplitContainerMapGen
			// 
			SplitContainerMapGen.Dock = DockStyle.Fill;
			SplitContainerMapGen.Location = new Point(3, 3);
			SplitContainerMapGen.Name = "SplitContainerMapGen";
			// 
			// SplitContainerMapGen.Panel2
			// 
			SplitContainerMapGen.Panel2.Controls.Add(ListBiomes);
			SplitContainerMapGen.Panel2.Controls.Add(panel1);
			SplitContainerMapGen.Size = new Size(1403, 644);
			SplitContainerMapGen.SplitterDistance = 1053;
			SplitContainerMapGen.SplitterWidth = 6;
			SplitContainerMapGen.TabIndex = 0;
			// 
			// ListBiomes
			// 
			ListBiomes.BackColor = SystemColors.Control;
			ListBiomes.Dock = DockStyle.Fill;
			ListBiomes.FormattingEnabled = true;
			ListBiomes.Location = new Point(0, 139);
			ListBiomes.Name = "ListBiomes";
			ListBiomes.Size = new Size(344, 505);
			ListBiomes.TabIndex = 2;
			ListBiomes.SelectedIndexChanged += ListBiomes_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.Controls.Add(PanelBiomeColor);
			panel1.Controls.Add(TxtColor);
			panel1.Controls.Add(TxtHumedityMax);
			panel1.Controls.Add(TxtHumedityMin);
			panel1.Controls.Add(TxtTempMax);
			panel1.Controls.Add(TxtTempMin);
			panel1.Controls.Add(TxtHeightMax);
			panel1.Controls.Add(TxtHeightMin);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(344, 139);
			panel1.TabIndex = 1;
			// 
			// PanelBiomeColor
			// 
			PanelBiomeColor.BorderStyle = BorderStyle.FixedSingle;
			PanelBiomeColor.Location = new Point(224, 102);
			PanelBiomeColor.Name = "PanelBiomeColor";
			PanelBiomeColor.Size = new Size(27, 27);
			PanelBiomeColor.TabIndex = 11;
			PanelBiomeColor.MouseDoubleClick += PanelBiomeColor_MouseDoubleClick;
			// 
			// TxtColor
			// 
			TxtColor.Location = new Point(109, 102);
			TxtColor.Name = "TxtColor";
			TxtColor.Size = new Size(109, 27);
			TxtColor.TabIndex = 10;
			// 
			// TxtHumedityMax
			// 
			TxtHumedityMax.Location = new Point(224, 69);
			TxtHumedityMax.Name = "TxtHumedityMax";
			TxtHumedityMax.Size = new Size(109, 27);
			TxtHumedityMax.TabIndex = 9;
			// 
			// TxtHumedityMin
			// 
			TxtHumedityMin.Location = new Point(109, 69);
			TxtHumedityMin.Name = "TxtHumedityMin";
			TxtHumedityMin.Size = new Size(109, 27);
			TxtHumedityMin.TabIndex = 8;
			// 
			// TxtTempMax
			// 
			TxtTempMax.Location = new Point(224, 36);
			TxtTempMax.Name = "TxtTempMax";
			TxtTempMax.Size = new Size(109, 27);
			TxtTempMax.TabIndex = 7;
			// 
			// TxtTempMin
			// 
			TxtTempMin.Location = new Point(109, 36);
			TxtTempMin.Name = "TxtTempMin";
			TxtTempMin.Size = new Size(109, 27);
			TxtTempMin.TabIndex = 6;
			// 
			// TxtHeightMax
			// 
			TxtHeightMax.Location = new Point(224, 3);
			TxtHeightMax.Name = "TxtHeightMax";
			TxtHeightMax.Size = new Size(109, 27);
			TxtHeightMax.TabIndex = 5;
			// 
			// TxtHeightMin
			// 
			TxtHeightMin.Location = new Point(109, 3);
			TxtHeightMin.Name = "TxtHeightMin";
			TxtHeightMin.Size = new Size(109, 27);
			TxtHeightMin.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(61, 105);
			label4.Name = "label4";
			label4.Size = new Size(42, 20);
			label4.TabIndex = 3;
			label4.Text = "Цвет";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(19, 72);
			label3.Name = "label3";
			label3.Size = new Size(84, 20);
			label3.TabIndex = 2;
			label3.Text = "Влажность";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 39);
			label2.Name = "label2";
			label2.Size = new Size(100, 20);
			label2.TabIndex = 1;
			label2.Text = "Температура";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(44, 6);
			label1.Name = "label1";
			label1.Size = new Size(59, 20);
			label1.TabIndex = 0;
			label1.Text = "Высота";
			// 
			// Desktop
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1417, 686);
			Controls.Add(TabbarEditor);
			Name = "Desktop";
			Text = "Редактор карт";
			Load += Desktop_Load;
			TabbarEditor.ResumeLayout(false);
			TabMapEditor.ResumeLayout(false);
			SplitContainerMapGen.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainerMapGen).EndInit();
			SplitContainerMapGen.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TabControl TabbarEditor;
		private TabPage TabMapEditor;
		private SplitContainer SplitContainerMapGen;
		private Panel panel1;
		private ListBox ListBiomes;
		private Label label1;
		private Label label3;
		private Label label2;
		private Label label4;
		private TextBox TxtColor;
		private TextBox TxtHumedityMax;
		private TextBox TxtHumedityMin;
		private TextBox TxtTempMax;
		private TextBox TxtTempMin;
		private TextBox TxtHeightMax;
		private TextBox TxtHeightMin;
		private ColorDialog ColorBiome;
		private Panel PanelBiomeColor;
	}
}
