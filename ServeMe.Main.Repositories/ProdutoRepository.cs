using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public ProdutoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public ProdutoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<Produto> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
