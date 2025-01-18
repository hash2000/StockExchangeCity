using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.UI;

namespace StockExchangeCity.Tool.MapEditor
{
	public partial class Desktop : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public Desktop(IServiceProvider serviceProvider)
		{
			InitializeComponent();

			_serviceProvider = serviceProvider;
		}

		private void Desktop_Load(object sender, EventArgs e)
		{
			TabbarEditor.SelectedTab = TabAreaEditor;

			var imageView = _serviceProvider.GetRequiredService<PanelImagesView>();
			imageView.LoadImages();
			SplitContainerAreaImages.Panel1.Controls.Add(imageView);
		}
	}
}
