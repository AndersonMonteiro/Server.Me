using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class PromocaoRepository : IPromocaoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public PromocaoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<IEnumerable<Promocao>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Promocao> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
