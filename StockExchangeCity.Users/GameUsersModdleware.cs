﻿using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.GameUsers.Repositories;

namespace StockExchangeCity.GameUsers
{
	public static class GameUsersModdleware
	{
		public static IServiceCollection UseGameUsers(this IServiceCollection services)
		{
			services.AddSingleton<IGameUsersRepository, GameUsersRepositoryInMemory>();
			return services;
		}
	}
}
