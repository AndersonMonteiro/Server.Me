using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public UsuarioRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
