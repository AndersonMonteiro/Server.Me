using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public CategoriaRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<IEnumerable<Categoria>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
