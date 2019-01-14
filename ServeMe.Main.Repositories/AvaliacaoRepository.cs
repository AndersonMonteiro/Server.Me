using Dapper;
using Npgsql;
using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class AvaliacaoRepository : IAvaliacaoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public AvaliacaoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Avaliacao avaliacao)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Avaliacao>> SearchByEstabelecimentoIdAsync(int idEstabelecimeto)
        {
            using (NpgsqlConnection conn = connectionFactory.CreateConnection(ConnectionName.SERVEME))
            {
                string query = @"";

                var dapperResult = await conn.QueryAsync(query);

                var mappedResult = Slapper.AutoMapper.MapDynamic<Avaliacao>(dapperResult).ToList();

                return mappedResult;
            }
        }

        public Task<Avaliacao> SearchByIdAsync(int idAvaliacao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Avaliacao>> SearchByPromocaoIdAsync(int idPromocao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Avaliacao>> SearchByUsuarioIdAsync(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Avaliacao avaliacao)
        {
            throw new NotImplementedException();
        }
    }
}
