using Dapper;
using Dapper.Contrib.Extensions;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using ServeMe.Infrastructure.DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Npgsql;

namespace ServeMe.Main.Repositories
{
    public class TestCoreRepo : ITestCoreRepo
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public TestCoreRepo(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public async Task<TestCore> TestCore()
        {
            using (NpgsqlConnection conn = connectionFactory.CreateConnection(ConnectionName.SERVEME))
            {

                string query = @"SELECT cd_tipo_atendimento as TestId
                                    ,nm_atendimento as TesteCore
                                    FROM tb_tipo_atendimento";

                var dapperResult = await conn.QueryAsync(query);

                var mappedResult = Slapper.AutoMapper.MapDynamic<TestCore>(dapperResult).ToList().FirstOrDefault();

                return mappedResult;
            }
        }
    }
}
