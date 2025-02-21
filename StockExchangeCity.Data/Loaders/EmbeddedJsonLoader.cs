using System.Reflection;

namespace StockExchangeCity.Data.Loaders
{
	public static class EmbeddedJsonLoader
	{
		public static async Task<string> GetPrefabsSource(string resourceName)
		{
			var assembly = Assembly.GetExecutingAssembly();
			var fullName = $"{assembly.GetName().Name}.Resources.Prefabs.{resourceName.Replace("/", ".")}";
			using var stream = assembly.GetManifestResourceStream(fullName);
			using var reader = new StreamReader(stream);
			return await reader.ReadToEndAsync();
		}
	}
}
