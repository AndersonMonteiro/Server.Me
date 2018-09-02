using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace ServeMe.Infrastructure.DatabaseHelper
{
    public interface IPostgreSqlConnectionFactory
    {
        NpgsqlConnection CreateConnection(string name);
    }

    public class PostgreSqlConnectionFactory : IPostgreSqlConnectionFactory
    {
        private readonly IConfiguration configuration;

        public PostgreSqlConnectionFactory(IConfiguration config)
        {
            this.configuration = config;
        }

        public NpgsqlConnection CreateConnection(string connectionName)
        {
            var teste = new NpgsqlConnection(configuration.GetConnectionString(connectionName));

            return new NpgsqlConnection(configuration.GetConnectionString(connectionName));
        }
    }
}
