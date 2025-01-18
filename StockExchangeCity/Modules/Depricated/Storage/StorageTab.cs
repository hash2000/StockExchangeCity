using StockExchangeCity.Modules.Depricated.Objects;

namespace StockExchangeCity.Modules.Depricated.Storage
{
    internal class StorageTab : TabPage
    {
        private StoragePanel _storagePanel;
        private Panel _splitPanel;
        private ObjectInfoPanel _objectInfoPanel;

        public StorageTab(string name)
        {
            DoubleBuffered = true;
            Text = name;

            _storagePanel = new StoragePanel();
            _storagePanel.Size = new Size(_storagePanel.GridSize, _storagePanel.GridSize);
            _storagePanel.Location = new Point(0, 0);
            _storagePanel.Dock = DockStyle.Left;

            _splitPanel = new Panel();
            _splitPanel.Size = new Size(10, Size.Height);
            _splitPanel.Location = new Point(_storagePanel.GridSize, 0);
            _splitPanel.BackColor = SystemColors.Info;
            _splitPanel.Dock = DockStyle.Left;

            _objectInfoPanel = new ObjectInfoPanel();
            _objectInfoPanel.BackColor = SystemColors.Info;
            _objectInfoPanel.Dock = DockStyle.Fill;

            Controls.Add(_objectInfoPanel);
            Controls.Add(_splitPanel);
            Controls.Add(_storagePanel);
        }



    }
}
