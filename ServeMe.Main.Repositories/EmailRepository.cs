using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class EmailRepository : IEmailRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public EmailRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Email email)
        {
            throw new NotImplementedException();
        }

        public Task<Email> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Email>> SearchByUserIdAsync(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
