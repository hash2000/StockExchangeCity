namespace StockExchangeCity.Modules.Depricated.Objects
{
    internal class ObjectInfoPanel : Panel
    {
        public ObjectInfoPanel()
        {
            BackColor = SystemColors.Info;
            DoubleBuffered = true;
            Paint += ObjectInfoPanel_OnPaint;
        }

        private void ObjectInfoPanel_OnPaint(object? sender, PaintEventArgs e)
        {

        }
    }
}
