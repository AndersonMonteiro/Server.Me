using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public EnderecoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        public Task<Endereco> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Endereco endereco)
        {
            throw new NotImplementedException();
        }
    }
}
