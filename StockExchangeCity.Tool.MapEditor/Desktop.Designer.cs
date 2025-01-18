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
			TabAreaEditor = new TabPage();
			AplitContainerArea = new SplitContainer();
			TabbarAreaProperties = new TabControl();
			TabAreaImagesList = new TabPage();
			tabPage2 = new TabPage();
			SplitContainerAreaImages = new SplitContainer();
			TabbarEditor.SuspendLayout();
			TabAreaEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)AplitContainerArea).BeginInit();
			AplitContainerArea.Panel2.SuspendLayout();
			AplitContainerArea.SuspendLayout();
			TabbarAreaProperties.SuspendLayout();
			TabAreaImagesList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainerAreaImages).BeginInit();
			SplitContainerAreaImages.SuspendLayout();
			SuspendLayout();
			// 
			// TabbarEditor
			// 
			TabbarEditor.Appearance = TabAppearance.FlatButtons;
			TabbarEditor.Controls.Add(TabMapEditor);
			TabbarEditor.Controls.Add(TabAreaEditor);
			TabbarEditor.Dock = DockStyle.Fill;
			TabbarEditor.Location = new Point(0, 0);
			TabbarEditor.Name = "TabbarEditor";
			TabbarEditor.SelectedIndex = 0;
			TabbarEditor.Size = new Size(1417, 686);
			TabbarEditor.TabIndex = 1;
			// 
			// TabMapEditor
			// 
			TabMapEditor.Location = new Point(4, 32);
			TabMapEditor.Name = "TabMapEditor";
			TabMapEditor.Padding = new Padding(3);
			TabMapEditor.Size = new Size(1409, 650);
			TabMapEditor.TabIndex = 0;
			TabMapEditor.Text = "Карта";
			TabMapEditor.UseVisualStyleBackColor = true;
			// 
			// TabAreaEditor
			// 
			TabAreaEditor.Controls.Add(AplitContainerArea);
			TabAreaEditor.Location = new Point(4, 32);
			TabAreaEditor.Name = "TabAreaEditor";
			TabAreaEditor.Padding = new Padding(3);
			TabAreaEditor.Size = new Size(1409, 650);
			TabAreaEditor.TabIndex = 1;
			TabAreaEditor.Text = "Область";
			TabAreaEditor.UseVisualStyleBackColor = true;
			// 
			// AplitContainerArea
			// 
			AplitContainerArea.Dock = DockStyle.Fill;
			AplitContainerArea.Location = new Point(3, 3);
			AplitContainerArea.Name = "AplitContainerArea";
			// 
			// AplitContainerArea.Panel2
			// 
			AplitContainerArea.Panel2.Controls.Add(TabbarAreaProperties);
			AplitContainerArea.Size = new Size(1403, 644);
			AplitContainerArea.SplitterDistance = 938;
			AplitContainerArea.SplitterWidth = 6;
			AplitContainerArea.TabIndex = 0;
			// 
			// TabbarAreaProperties
			// 
			TabbarAreaProperties.Appearance = TabAppearance.FlatButtons;
			TabbarAreaProperties.Controls.Add(TabAreaImagesList);
			TabbarAreaProperties.Controls.Add(tabPage2);
			TabbarAreaProperties.Dock = DockStyle.Fill;
			TabbarAreaProperties.Location = new Point(0, 0);
			TabbarAreaProperties.Name = "TabbarAreaProperties";
			TabbarAreaProperties.SelectedIndex = 0;
			TabbarAreaProperties.Size = new Size(459, 644);
			TabbarAreaProperties.TabIndex = 0;
			// 
			// TabAreaImagesList
			// 
			TabAreaImagesList.Controls.Add(SplitContainerAreaImages);
			TabAreaImagesList.Location = new Point(4, 32);
			TabAreaImagesList.Name = "TabAreaImagesList";
			TabAreaImagesList.Padding = new Padding(3);
			TabAreaImagesList.Size = new Size(451, 608);
			TabAreaImagesList.TabIndex = 0;
			TabAreaImagesList.Text = "Картинки";
			TabAreaImagesList.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			tabPage2.Location = new Point(4, 32);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new Padding(3);
			tabPage2.Size = new Size(312, 608);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "tabPage2";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// SplitContainerAreaImages
			// 
			SplitContainerAreaImages.Dock = DockStyle.Fill;
			SplitContainerAreaImages.Location = new Point(3, 3);
			SplitContainerAreaImages.Name = "SplitContainerAreaImages";
			SplitContainerAreaImages.Orientation = Orientation.Horizontal;
			SplitContainerAreaImages.Size = new Size(445, 602);
			SplitContainerAreaImages.SplitterDistance = 361;
			SplitContainerAreaImages.SplitterWidth = 6;
			SplitContainerAreaImages.TabIndex = 0;
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
			TabAreaEditor.ResumeLayout(false);
			AplitContainerArea.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)AplitContainerArea).EndInit();
			AplitContainerArea.ResumeLayout(false);
			TabbarAreaProperties.ResumeLayout(false);
			TabAreaImagesList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainerAreaImages).EndInit();
			SplitContainerAreaImages.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl TabbarEditor;
		private TabPage TabMapEditor;
		private TabPage TabAreaEditor;
		private SplitContainer AplitContainerArea;
		private TabControl TabbarAreaProperties;
		private TabPage TabAreaImagesList;
		private TabPage tabPage2;
		private SplitContainer SplitContainerAreaImages;
	}
}
