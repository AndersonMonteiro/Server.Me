using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class EstabelecimentoRepository : IEstabelecimentoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public EstabelecimentoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<IEnumerable<Estabelecimento>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Estabelecimento> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
