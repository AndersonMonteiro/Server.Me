using Microsoft.Extensions.DependencyInjection;
using ServeMe.Main.Domain.Repositories;
using ServeMe.Main.Domain.Services;
using ServeMe.Main.Repositories;
using ServeMe.Main.Services;
using System;
using System.Collections.Generic;
using System.Text;
using ServeMe.Infrastructure.DatabaseHelper;

namespace ServeMe.Infrastructure.DI
{
    public static class MainModule
    {
        public static IServiceCollection RegisterServices(
            this IServiceCollection services)
        {
            // Main Services
            services.AddTransient<ITestCoreServ, TestCoreServ>();

            // Main Repositories
            services.AddTransient<ITestCoreRepo, TestCoreRepo>();

            // DatabaseHelper
            services.AddTransient<IPostgreSqlConnectionFactory, PostgreSqlConnectionFactory>();

            // Security Services

            // Security Repositories
            
            return services;
        }
    }
}
