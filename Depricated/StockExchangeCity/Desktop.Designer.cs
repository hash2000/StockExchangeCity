namespace StockExchangeCity
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Desktop));
			PanelStatusbar = new Panel();
			BtLog = new Button();
			button1 = new Button();
			PanelApplication = new Panel();
			SplitContainerChar = new SplitContainer();
			TabbarGame = new TabControl();
			TabGameMap = new TabPage();
			TabGameChar = new TabPage();
			SplitContainerCharEquip = new SplitContainer();
			TreeCharProperties = new TreeView();
			PanelCharEquipTop = new Panel();
			ЫplitContainerCharDevices = new SplitContainer();
			groupBox1 = new GroupBox();
			ListCharDevices = new ListView();
			PanelChar2 = new Panel();
			PanelCharInfo = new Panel();
			PicChar = new PictureBox();
			TabGameStorage = new TabPage();
			treeInventory = new TreeView();
			PanelMainStoreInfo = new Panel();
			textInventory = new TextBox();
			PanelStatusbar.SuspendLayout();
			PanelApplication.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainerChar).BeginInit();
			SplitContainerChar.Panel1.SuspendLayout();
			SplitContainerChar.Panel2.SuspendLayout();
			SplitContainerChar.SuspendLayout();
			TabbarGame.SuspendLayout();
			TabGameChar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)SplitContainerCharEquip).BeginInit();
			SplitContainerCharEquip.Panel1.SuspendLayout();
			SplitContainerCharEquip.Panel2.SuspendLayout();
			SplitContainerCharEquip.SuspendLayout();
			PanelCharEquipTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)ЫplitContainerCharDevices).BeginInit();
			ЫplitContainerCharDevices.Panel1.SuspendLayout();
			ЫplitContainerCharDevices.Panel2.SuspendLayout();
			ЫplitContainerCharDevices.SuspendLayout();
			groupBox1.SuspendLayout();
			PanelCharInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)PicChar).BeginInit();
			PanelMainStoreInfo.SuspendLayout();
			SuspendLayout();
			// 
			// PanelStatusbar
			// 
			PanelStatusbar.BackColor = SystemColors.Control;
			PanelStatusbar.Controls.Add(BtLog);
			PanelStatusbar.Controls.Add(button1);
			PanelStatusbar.Dock = DockStyle.Bottom;
			PanelStatusbar.Font = new Font("Segoe UI", 6F);
			PanelStatusbar.Location = new Point(0, 724);
			PanelStatusbar.Name = "PanelStatusbar";
			PanelStatusbar.Padding = new Padding(3);
			PanelStatusbar.Size = new Size(1277, 31);
			PanelStatusbar.TabIndex = 0;
			// 
			// BtLog
			// 
			BtLog.Dock = DockStyle.Right;
			BtLog.FlatStyle = FlatStyle.Flat;
			BtLog.Location = new Point(1178, 3);
			BtLog.Name = "BtLog";
			BtLog.Size = new Size(96, 25);
			BtLog.TabIndex = 1;
			BtLog.Text = "Log";
			BtLog.UseVisualStyleBackColor = true;
			BtLog.Click += BtLog_Click;
			// 
			// button1
			// 
			button1.Dock = DockStyle.Left;
			button1.FlatStyle = FlatStyle.Flat;
			button1.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
			button1.Location = new Point(3, 3);
			button1.Name = "button1";
			button1.Size = new Size(92, 25);
			button1.TabIndex = 0;
			button1.Text = "Подключиться";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// PanelApplication
			// 
			PanelApplication.Controls.Add(SplitContainerChar);
			PanelApplication.Dock = DockStyle.Fill;
			PanelApplication.Location = new Point(0, 0);
			PanelApplication.Name = "PanelApplication";
			PanelApplication.Size = new Size(1277, 724);
			PanelApplication.TabIndex = 4;
			// 
			// SplitContainerChar
			// 
			SplitContainerChar.BackColor = SystemColors.Control;
			SplitContainerChar.Dock = DockStyle.Fill;
			SplitContainerChar.Location = new Point(0, 0);
			SplitContainerChar.Name = "SplitContainerChar";
			// 
			// SplitContainerChar.Panel1
			// 
			SplitContainerChar.Panel1.Controls.Add(TabbarGame);
			// 
			// SplitContainerChar.Panel2
			// 
			SplitContainerChar.Panel2.Controls.Add(treeInventory);
			SplitContainerChar.Panel2.Controls.Add(PanelMainStoreInfo);
			SplitContainerChar.Size = new Size(1277, 724);
			SplitContainerChar.SplitterDistance = 944;
			SplitContainerChar.SplitterWidth = 6;
			SplitContainerChar.TabIndex = 0;
			// 
			// TabbarGame
			// 
			TabbarGame.Appearance = TabAppearance.FlatButtons;
			TabbarGame.Controls.Add(TabGameMap);
			TabbarGame.Controls.Add(TabGameChar);
			TabbarGame.Controls.Add(TabGameStorage);
			TabbarGame.Dock = DockStyle.Fill;
			TabbarGame.Location = new Point(0, 0);
			TabbarGame.Name = "TabbarGame";
			TabbarGame.SelectedIndex = 0;
			TabbarGame.Size = new Size(944, 724);
			TabbarGame.TabIndex = 3;
			// 
			// TabGameMap
			// 
			TabGameMap.BackColor = SystemColors.Control;
			TabGameMap.Location = new Point(4, 32);
			TabGameMap.Name = "TabGameMap";
			TabGameMap.Padding = new Padding(3);
			TabGameMap.Size = new Size(936, 688);
			TabGameMap.TabIndex = 0;
			TabGameMap.Text = "Карта";
			// 
			// TabGameChar
			// 
			TabGameChar.Controls.Add(SplitContainerCharEquip);
			TabGameChar.Controls.Add(PanelCharInfo);
			TabGameChar.Location = new Point(4, 32);
			TabGameChar.Name = "TabGameChar";
			TabGameChar.Size = new Size(936, 688);
			TabGameChar.TabIndex = 1;
			TabGameChar.Text = "Перс";
			TabGameChar.UseVisualStyleBackColor = true;
			// 
			// SplitContainerCharEquip
			// 
			SplitContainerCharEquip.BackColor = SystemColors.Control;
			SplitContainerCharEquip.BorderStyle = BorderStyle.FixedSingle;
			SplitContainerCharEquip.Dock = DockStyle.Fill;
			SplitContainerCharEquip.Location = new Point(255, 0);
			SplitContainerCharEquip.Name = "SplitContainerCharEquip";
			// 
			// SplitContainerCharEquip.Panel1
			// 
			SplitContainerCharEquip.Panel1.Controls.Add(TreeCharProperties);
			// 
			// SplitContainerCharEquip.Panel2
			// 
			SplitContainerCharEquip.Panel2.Controls.Add(PanelCharEquipTop);
			SplitContainerCharEquip.Size = new Size(681, 688);
			SplitContainerCharEquip.SplitterDistance = 355;
			SplitContainerCharEquip.TabIndex = 6;
			// 
			// TreeCharProperties
			// 
			TreeCharProperties.BackColor = SystemColors.Control;
			TreeCharProperties.Dock = DockStyle.Fill;
			TreeCharProperties.Location = new Point(0, 0);
			TreeCharProperties.Name = "TreeCharProperties";
			TreeCharProperties.Size = new Size(353, 686);
			TreeCharProperties.TabIndex = 5;
			// 
			// PanelCharEquipTop
			// 
			PanelCharEquipTop.BackColor = SystemColors.Control;
			PanelCharEquipTop.Controls.Add(ЫplitContainerCharDevices);
			PanelCharEquipTop.Dock = DockStyle.Fill;
			PanelCharEquipTop.Location = new Point(0, 0);
			PanelCharEquipTop.Name = "PanelCharEquipTop";
			PanelCharEquipTop.Size = new Size(320, 686);
			PanelCharEquipTop.TabIndex = 6;
			// 
			// ЫplitContainerCharDevices
			// 
			ЫplitContainerCharDevices.BackColor = SystemColors.Control;
			ЫplitContainerCharDevices.BorderStyle = BorderStyle.FixedSingle;
			ЫplitContainerCharDevices.Dock = DockStyle.Fill;
			ЫplitContainerCharDevices.Location = new Point(0, 0);
			ЫplitContainerCharDevices.Name = "ЫplitContainerCharDevices";
			ЫplitContainerCharDevices.Orientation = Orientation.Horizontal;
			// 
			// ЫplitContainerCharDevices.Panel1
			// 
			ЫplitContainerCharDevices.Panel1.Controls.Add(groupBox1);
			// 
			// ЫplitContainerCharDevices.Panel2
			// 
			ЫplitContainerCharDevices.Panel2.Controls.Add(PanelChar2);
			ЫplitContainerCharDevices.Size = new Size(320, 686);
			ЫplitContainerCharDevices.SplitterDistance = 315;
			ЫplitContainerCharDevices.SplitterWidth = 6;
			ЫplitContainerCharDevices.TabIndex = 0;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(ListCharDevices);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(318, 313);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Устройства";
			// 
			// ListCharDevices
			// 
			ListCharDevices.BackColor = SystemColors.Control;
			ListCharDevices.BorderStyle = BorderStyle.None;
			ListCharDevices.Dock = DockStyle.Fill;
			ListCharDevices.Location = new Point(3, 23);
			ListCharDevices.Name = "ListCharDevices";
			ListCharDevices.Size = new Size(312, 287);
			ListCharDevices.TabIndex = 0;
			ListCharDevices.UseCompatibleStateImageBehavior = false;
			// 
			// PanelChar2
			// 
			PanelChar2.BackColor = SystemColors.Control;
			PanelChar2.Dock = DockStyle.Top;
			PanelChar2.Location = new Point(0, 0);
			PanelChar2.Name = "PanelChar2";
			PanelChar2.Size = new Size(318, 169);
			PanelChar2.TabIndex = 0;
			// 
			// PanelCharInfo
			// 
			PanelCharInfo.Controls.Add(PicChar);
			PanelCharInfo.Dock = DockStyle.Left;
			PanelCharInfo.Location = new Point(0, 0);
			PanelCharInfo.Name = "PanelCharInfo";
			PanelCharInfo.Size = new Size(255, 688);
			PanelCharInfo.TabIndex = 1;
			// 
			// PicChar
			// 
			PicChar.Image = (Image)resources.GetObject("PicChar.Image");
			PicChar.Location = new Point(8, 13);
			PicChar.Name = "PicChar";
			PicChar.Size = new Size(94, 264);
			PicChar.TabIndex = 1;
			PicChar.TabStop = false;
			// 
			// TabGameStorage
			// 
			TabGameStorage.Location = new Point(4, 32);
			TabGameStorage.Name = "TabGameStorage";
			TabGameStorage.Size = new Size(936, 688);
			TabGameStorage.TabIndex = 2;
			TabGameStorage.Text = "Склад";
			TabGameStorage.UseVisualStyleBackColor = true;
			// 
			// treeInventory
			// 
			treeInventory.BackColor = SystemColors.Control;
			treeInventory.Dock = DockStyle.Fill;
			treeInventory.Location = new Point(0, 147);
			treeInventory.Name = "treeInventory";
			treeInventory.Size = new Size(327, 577);
			treeInventory.TabIndex = 2;
			// 
			// PanelMainStoreInfo
			// 
			PanelMainStoreInfo.Controls.Add(textInventory);
			PanelMainStoreInfo.Dock = DockStyle.Top;
			PanelMainStoreInfo.Location = new Point(0, 0);
			PanelMainStoreInfo.Name = "PanelMainStoreInfo";
			PanelMainStoreInfo.Size = new Size(327, 147);
			PanelMainStoreInfo.TabIndex = 1;
			// 
			// textInventory
			// 
			textInventory.BackColor = SystemColors.Control;
			textInventory.BorderStyle = BorderStyle.None;
			textInventory.Dock = DockStyle.Fill;
			textInventory.Location = new Point(0, 0);
			textInventory.Multiline = true;
			textInventory.Name = "textInventory";
			textInventory.ReadOnly = true;
			textInventory.Size = new Size(327, 147);
			textInventory.TabIndex = 0;
			// 
			// Descktop
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(1277, 755);
			Controls.Add(PanelApplication);
			Controls.Add(PanelStatusbar);
			DoubleBuffered = true;
			Name = "Descktop";
			Text = "Stock Exchange City";
			Load += Descktop_Load;
			PanelStatusbar.ResumeLayout(false);
			PanelApplication.ResumeLayout(false);
			SplitContainerChar.Panel1.ResumeLayout(false);
			SplitContainerChar.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainerChar).EndInit();
			SplitContainerChar.ResumeLayout(false);
			TabbarGame.ResumeLayout(false);
			TabGameChar.ResumeLayout(false);
			SplitContainerCharEquip.Panel1.ResumeLayout(false);
			SplitContainerCharEquip.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)SplitContainerCharEquip).EndInit();
			SplitContainerCharEquip.ResumeLayout(false);
			PanelCharEquipTop.ResumeLayout(false);
			ЫplitContainerCharDevices.Panel1.ResumeLayout(false);
			ЫplitContainerCharDevices.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)ЫplitContainerCharDevices).EndInit();
			ЫplitContainerCharDevices.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			PanelCharInfo.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)PicChar).EndInit();
			PanelMainStoreInfo.ResumeLayout(false);
			PanelMainStoreInfo.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel PanelStatusbar;
		private Panel PanelApplication;
		private SplitContainer SplitContainerChar;
		private TabControl TabbarGame;
		private TabPage TabGameMap;
		private TabPage TabGameChar;
		private SplitContainer SplitContainerCharEquip;
		private TreeView TreeCharProperties;
		private Panel PanelCharEquipTop;
		private SplitContainer ЫplitContainerCharDevices;
		private GroupBox groupBox1;
		private ListView ListCharDevices;
		private Panel PanelChar2;
		private Panel PanelCharInfo;
		private PictureBox PicChar;
		private TabPage TabGameStorage;
		private TreeView treeInventory;
		private Panel PanelMainStoreInfo;
		private TextBox textInventory;
		private Button button1;
		private Button BtLog;
	}
}
