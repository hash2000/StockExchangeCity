﻿namespace StockExchangeCity.Tool.MapEditor
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
			panel3 = new Panel();
			BtnClearMap = new Button();
			BtnGenerateMap = new Button();
			TabbarMapProperties = new TabControl();
			TabGenerator = new TabPage();
			WorldMapProperties = new PropertyGrid();
			TabBiomes = new TabPage();
			ListBiomes = new ListBox();
			panel1 = new Panel();
			label5 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			PanelBiomeColor = new Panel();
			TxtColor = new TextBox();
			TxtHumidityMax = new TextBox();
			TxtHumidityMin = new TextBox();
			TxtTempMax = new TextBox();
			TxtTempMin = new TextBox();
			TxtHeightMax = new TextBox();
			TxtHeightMin = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			panel2 = new Panel();
			BtnLoadBiomes = new Button();
			BtnSaveBiomes = new Button();
			ColorBiome = new ColorDialog();
			PanelWorldMapZone = new Panel();
			TabbarEditor.SuspendLayout();
			TabMapEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainerMapGen).BeginInit();
			SplitContainerMapGen.Panel1.SuspendLayout();
			SplitContainerMapGen.Panel2.SuspendLayout();
			SplitContainerMapGen.SuspendLayout();
			panel3.SuspendLayout();
			TabbarMapProperties.SuspendLayout();
			TabGenerator.SuspendLayout();
			TabBiomes.SuspendLayout();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// TabbarEditor
			// 
			TabbarEditor.Appearance = TabAppearance.FlatButtons;
			TabbarEditor.Controls.Add(TabMapEditor);
			TabbarEditor.Dock = DockStyle.Fill;
			TabbarEditor.Location = new Point(0, 0);
			TabbarEditor.Margin = new Padding(3, 2, 3, 2);
			TabbarEditor.Name = "TabbarEditor";
			TabbarEditor.SelectedIndex = 0;
			TabbarEditor.Size = new Size(794, 514);
			TabbarEditor.TabIndex = 1;
			// 
			// TabMapEditor
			// 
			TabMapEditor.Controls.Add(SplitContainerMapGen);
			TabMapEditor.Location = new Point(4, 27);
			TabMapEditor.Margin = new Padding(3, 2, 3, 2);
			TabMapEditor.Name = "TabMapEditor";
			TabMapEditor.Padding = new Padding(3, 2, 3, 2);
			TabMapEditor.Size = new Size(786, 483);
			TabMapEditor.TabIndex = 0;
			TabMapEditor.Text = "Карта";
			TabMapEditor.UseVisualStyleBackColor = true;
			// 
			// SplitContainerMapGen
			// 
			SplitContainerMapGen.Dock = DockStyle.Fill;
			SplitContainerMapGen.Location = new Point(3, 2);
			SplitContainerMapGen.Margin = new Padding(3, 2, 3, 2);
			SplitContainerMapGen.Name = "SplitContainerMapGen";
			// 
			// SplitContainerMapGen.Panel1
			// 
			SplitContainerMapGen.Panel1.Controls.Add(PanelWorldMapZone);
			SplitContainerMapGen.Panel1.Controls.Add(panel3);
			// 
			// SplitContainerMapGen.Panel2
			// 
			SplitContainerMapGen.Panel2.Controls.Add(TabbarMapProperties);
			SplitContainerMapGen.Size = new Size(780, 479);
			SplitContainerMapGen.SplitterDistance = 427;
			SplitContainerMapGen.SplitterWidth = 5;
			SplitContainerMapGen.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.Controls.Add(BtnClearMap);
			panel3.Controls.Add(BtnGenerateMap);
			panel3.Dock = DockStyle.Top;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(427, 35);
			panel3.TabIndex = 0;
			// 
			// BtnClearMap
			// 
			BtnClearMap.Location = new Point(121, 4);
			BtnClearMap.Name = "BtnClearMap";
			BtnClearMap.Size = new Size(110, 26);
			BtnClearMap.TabIndex = 3;
			BtnClearMap.Text = "Очистить";
			BtnClearMap.UseVisualStyleBackColor = true;
			BtnClearMap.Click += BtnClearMap_Click;
			// 
			// BtnGenerateMap
			// 
			BtnGenerateMap.Location = new Point(5, 4);
			BtnGenerateMap.Name = "BtnGenerateMap";
			BtnGenerateMap.Size = new Size(110, 26);
			BtnGenerateMap.TabIndex = 2;
			BtnGenerateMap.Text = "Генерировать";
			BtnGenerateMap.UseVisualStyleBackColor = true;
			BtnGenerateMap.Click += BtnGenerateMap_Click;
			// 
			// TabbarMapProperties
			// 
			TabbarMapProperties.Appearance = TabAppearance.FlatButtons;
			TabbarMapProperties.Controls.Add(TabGenerator);
			TabbarMapProperties.Controls.Add(TabBiomes);
			TabbarMapProperties.Dock = DockStyle.Fill;
			TabbarMapProperties.Location = new Point(0, 0);
			TabbarMapProperties.Name = "TabbarMapProperties";
			TabbarMapProperties.SelectedIndex = 0;
			TabbarMapProperties.Size = new Size(348, 479);
			TabbarMapProperties.TabIndex = 5;
			// 
			// TabGenerator
			// 
			TabGenerator.Controls.Add(WorldMapProperties);
			TabGenerator.Location = new Point(4, 27);
			TabGenerator.Name = "TabGenerator";
			TabGenerator.Padding = new Padding(3);
			TabGenerator.Size = new Size(340, 448);
			TabGenerator.TabIndex = 1;
			TabGenerator.Text = "Генератор";
			TabGenerator.UseVisualStyleBackColor = true;
			// 
			// WorldMapProperties
			// 
			WorldMapProperties.Dock = DockStyle.Fill;
			WorldMapProperties.Location = new Point(3, 3);
			WorldMapProperties.Name = "WorldMapProperties";
			WorldMapProperties.Size = new Size(334, 442);
			WorldMapProperties.TabIndex = 2;
			// 
			// TabBiomes
			// 
			TabBiomes.Controls.Add(ListBiomes);
			TabBiomes.Controls.Add(panel1);
			TabBiomes.Controls.Add(panel2);
			TabBiomes.Location = new Point(4, 27);
			TabBiomes.Name = "TabBiomes";
			TabBiomes.Padding = new Padding(3);
			TabBiomes.Size = new Size(340, 448);
			TabBiomes.TabIndex = 0;
			TabBiomes.Text = "Биомы";
			TabBiomes.UseVisualStyleBackColor = true;
			// 
			// ListBiomes
			// 
			ListBiomes.BackColor = SystemColors.Control;
			ListBiomes.Dock = DockStyle.Fill;
			ListBiomes.FormattingEnabled = true;
			ListBiomes.ItemHeight = 15;
			ListBiomes.Location = new Point(3, 141);
			ListBiomes.Margin = new Padding(3, 2, 3, 2);
			ListBiomes.Name = "ListBiomes";
			ListBiomes.ScrollAlwaysVisible = true;
			ListBiomes.Size = new Size(334, 267);
			ListBiomes.TabIndex = 4;
			ListBiomes.SelectedIndexChanged += ListBiomes_SelectedIndexChanged;
			// 
			// panel1
			// 
			panel1.Controls.Add(label5);
			panel1.Controls.Add(textBox1);
			panel1.Controls.Add(textBox2);
			panel1.Controls.Add(PanelBiomeColor);
			panel1.Controls.Add(TxtColor);
			panel1.Controls.Add(TxtHumidityMax);
			panel1.Controls.Add(TxtHumidityMin);
			panel1.Controls.Add(TxtTempMax);
			panel1.Controls.Add(TxtTempMin);
			panel1.Controls.Add(TxtHeightMax);
			panel1.Controls.Add(TxtHeightMin);
			panel1.Controls.Add(label4);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(3, 3);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(334, 138);
			panel1.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(17, 109);
			label5.Name = "label5";
			label5.Size = new Size(66, 15);
			label5.TabIndex = 14;
			label5.Text = "Мин/Макс";
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.ControlLight;
			textBox1.Location = new Point(208, 106);
			textBox1.Margin = new Padding(3, 2, 3, 2);
			textBox1.Name = "textBox1";
			textBox1.ReadOnly = true;
			textBox1.Size = new Size(110, 23);
			textBox1.TabIndex = 13;
			textBox1.Text = "3,4028235E+38";
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.ControlLight;
			textBox2.ForeColor = SystemColors.WindowText;
			textBox2.Location = new Point(95, 106);
			textBox2.Margin = new Padding(3, 2, 3, 2);
			textBox2.Name = "textBox2";
			textBox2.ReadOnly = true;
			textBox2.Size = new Size(110, 23);
			textBox2.TabIndex = 12;
			textBox2.Text = "-3,4028235E+38";
			// 
			// PanelBiomeColor
			// 
			PanelBiomeColor.BorderStyle = BorderStyle.FixedSingle;
			PanelBiomeColor.Location = new Point(208, 79);
			PanelBiomeColor.Margin = new Padding(3, 2, 3, 2);
			PanelBiomeColor.Name = "PanelBiomeColor";
			PanelBiomeColor.Size = new Size(24, 21);
			PanelBiomeColor.TabIndex = 11;
			PanelBiomeColor.MouseDoubleClick += PanelBiomeColor_MouseDoubleClick;
			// 
			// TxtColor
			// 
			TxtColor.BackColor = SystemColors.ControlLight;
			TxtColor.Location = new Point(95, 79);
			TxtColor.Margin = new Padding(3, 2, 3, 2);
			TxtColor.Name = "TxtColor";
			TxtColor.Size = new Size(110, 23);
			TxtColor.TabIndex = 10;
			TxtColor.TextChanged += TxtColor_TextChanged;
			// 
			// TxtHumidityMax
			// 
			TxtHumidityMax.BackColor = SystemColors.ControlLight;
			TxtHumidityMax.Location = new Point(208, 52);
			TxtHumidityMax.Margin = new Padding(3, 2, 3, 2);
			TxtHumidityMax.Name = "TxtHumidityMax";
			TxtHumidityMax.Size = new Size(110, 23);
			TxtHumidityMax.TabIndex = 9;
			TxtHumidityMax.TextChanged += TxtHumidityMax_TextChanged;
			// 
			// TxtHumidityMin
			// 
			TxtHumidityMin.BackColor = SystemColors.ControlLight;
			TxtHumidityMin.Location = new Point(95, 52);
			TxtHumidityMin.Margin = new Padding(3, 2, 3, 2);
			TxtHumidityMin.Name = "TxtHumidityMin";
			TxtHumidityMin.Size = new Size(110, 23);
			TxtHumidityMin.TabIndex = 8;
			TxtHumidityMin.TextChanged += TxtHumidityMin_TextChanged;
			// 
			// TxtTempMax
			// 
			TxtTempMax.BackColor = SystemColors.ControlLight;
			TxtTempMax.Location = new Point(208, 27);
			TxtTempMax.Margin = new Padding(3, 2, 3, 2);
			TxtTempMax.Name = "TxtTempMax";
			TxtTempMax.Size = new Size(110, 23);
			TxtTempMax.TabIndex = 7;
			TxtTempMax.TextChanged += TxtTempMax_TextChanged;
			// 
			// TxtTempMin
			// 
			TxtTempMin.BackColor = SystemColors.ControlLight;
			TxtTempMin.Location = new Point(95, 27);
			TxtTempMin.Margin = new Padding(3, 2, 3, 2);
			TxtTempMin.Name = "TxtTempMin";
			TxtTempMin.Size = new Size(110, 23);
			TxtTempMin.TabIndex = 6;
			TxtTempMin.TextChanged += TxtTempMin_TextChanged;
			// 
			// TxtHeightMax
			// 
			TxtHeightMax.BackColor = SystemColors.ControlLight;
			TxtHeightMax.Location = new Point(208, 2);
			TxtHeightMax.Margin = new Padding(3, 2, 3, 2);
			TxtHeightMax.Name = "TxtHeightMax";
			TxtHeightMax.Size = new Size(110, 23);
			TxtHeightMax.TabIndex = 5;
			TxtHeightMax.TextChanged += TxtHeightMax_TextChanged;
			// 
			// TxtHeightMin
			// 
			TxtHeightMin.BackColor = SystemColors.ControlLight;
			TxtHeightMin.ForeColor = SystemColors.WindowText;
			TxtHeightMin.Location = new Point(95, 2);
			TxtHeightMin.Margin = new Padding(3, 2, 3, 2);
			TxtHeightMin.Name = "TxtHeightMin";
			TxtHeightMin.Size = new Size(110, 23);
			TxtHeightMin.TabIndex = 4;
			TxtHeightMin.TextChanged += TxtHeightMin_TextChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(52, 82);
			label4.Name = "label4";
			label4.Size = new Size(33, 15);
			label4.TabIndex = 3;
			label4.Text = "Цвет";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(17, 54);
			label3.Name = "label3";
			label3.Size = new Size(67, 15);
			label3.TabIndex = 2;
			label3.Text = "Влажность";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 29);
			label2.Name = "label2";
			label2.Size = new Size(78, 15);
			label2.TabIndex = 1;
			label2.Text = "Температура";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(38, 4);
			label1.Name = "label1";
			label1.Size = new Size(47, 15);
			label1.TabIndex = 0;
			label1.Text = "Высота";
			// 
			// panel2
			// 
			panel2.Controls.Add(BtnLoadBiomes);
			panel2.Controls.Add(BtnSaveBiomes);
			panel2.Dock = DockStyle.Bottom;
			panel2.Location = new Point(3, 408);
			panel2.Name = "panel2";
			panel2.Size = new Size(334, 37);
			panel2.TabIndex = 3;
			// 
			// BtnLoadBiomes
			// 
			BtnLoadBiomes.Dock = DockStyle.Right;
			BtnLoadBiomes.Location = new Point(140, 0);
			BtnLoadBiomes.Name = "BtnLoadBiomes";
			BtnLoadBiomes.Size = new Size(97, 37);
			BtnLoadBiomes.TabIndex = 1;
			BtnLoadBiomes.Text = "Загрузить";
			BtnLoadBiomes.UseVisualStyleBackColor = true;
			BtnLoadBiomes.Click += BtnLoadBiomes_Click;
			// 
			// BtnSaveBiomes
			// 
			BtnSaveBiomes.Dock = DockStyle.Right;
			BtnSaveBiomes.Location = new Point(237, 0);
			BtnSaveBiomes.Name = "BtnSaveBiomes";
			BtnSaveBiomes.Size = new Size(97, 37);
			BtnSaveBiomes.TabIndex = 0;
			BtnSaveBiomes.Text = "Сохранить";
			BtnSaveBiomes.UseVisualStyleBackColor = true;
			BtnSaveBiomes.Click += BtnSaveBiomes_Click;
			// 
			// PanelWorldMapZone
			// 
			PanelWorldMapZone.Dock = DockStyle.Fill;
			PanelWorldMapZone.Location = new Point(0, 35);
			PanelWorldMapZone.Name = "PanelWorldMapZone";
			PanelWorldMapZone.Size = new Size(427, 444);
			PanelWorldMapZone.TabIndex = 1;
			// 
			// Desktop
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(794, 514);
			Controls.Add(TabbarEditor);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Desktop";
			Text = "Редактор карт";
			Load += Desktop_Load;
			TabbarEditor.ResumeLayout(false);
			TabMapEditor.ResumeLayout(false);
			SplitContainerMapGen.Panel1.ResumeLayout(false);
			SplitContainerMapGen.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainerMapGen).EndInit();
			SplitContainerMapGen.ResumeLayout(false);
			panel3.ResumeLayout(false);
			TabbarMapProperties.ResumeLayout(false);
			TabGenerator.ResumeLayout(false);
			TabBiomes.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl TabbarEditor;
		private TabPage TabMapEditor;
		private SplitContainer SplitContainerMapGen;
		private ColorDialog ColorBiome;
		private Panel panel3;
		private Button BtnGenerateMap;
		private Button BtnClearMap;
		private TabControl TabbarMapProperties;
		private TabPage TabBiomes;
		private ListBox ListBiomes;
		private Panel panel1;
		private Label label5;
		private TextBox textBox1;
		private TextBox textBox2;
		private Panel PanelBiomeColor;
		private TextBox TxtColor;
		private TextBox TxtHumidityMax;
		private TextBox TxtHumidityMin;
		private TextBox TxtTempMax;
		private TextBox TxtTempMin;
		private TextBox TxtHeightMax;
		private TextBox TxtHeightMin;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private Panel panel2;
		private Button BtnLoadBiomes;
		private Button BtnSaveBiomes;
		private TabPage TabGenerator;
		private PropertyGrid WorldMapProperties;
		private Panel PanelWorldMapZone;
	}
}
