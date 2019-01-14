using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class TipoTelefoneRepository : ITipoTelefoneRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public TipoTelefoneRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<IEnumerable<TipoTelefone>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
