namespace StockExchangeCity.Modules.Depricated.Storage
{
    internal class StoragePanel : Panel
    {
        public StoragePanel()
        {
            BackColor = SystemColors.Info;
            DoubleBuffered = true;
            Paint += StoragePanel_OnPaint;
        }

        public int CellSize => 32;

        public int CellsCount => 20;

        public int GridSize => CellSize * CellsCount;

        private void StoragePanel_OnPaint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            DrawGrid(g);
            DrawItems(g);
        }

        private void DrawGrid(Graphics g)
        {
            for (int i = 0; i <= CellsCount; i++)
            {
                g.DrawLine(Pens.DarkBlue,
                      new Point(0, i * CellSize),
                      new Point(CellSize * CellsCount, i * CellSize));
            }

            for (int i = 0; i <= CellsCount; i++)
            {
                g.DrawLine(Pens.DarkBlue,
                      new Point(i * CellSize, 0),
                      new Point(i * CellSize, CellSize * CellsCount));
            }
        }

        private void DrawItems(Graphics g)
        {

        }

    }
}
