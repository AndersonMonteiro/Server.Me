using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class TelefoneRepository : ITelefoneRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public TelefoneRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Telefone telefone)
        {
            throw new NotImplementedException();
        }

        public Task<Telefone> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Telefone telefone)
        {
            throw new NotImplementedException();
        }
    }
}
