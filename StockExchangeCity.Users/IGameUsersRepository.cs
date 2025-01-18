namespace StockExchangeCity.GameUsers
{
	public interface IGameUsersRepository
	{
		Task<bool> ConnectAsync(string token);

		User? User { get; }
	}
}
