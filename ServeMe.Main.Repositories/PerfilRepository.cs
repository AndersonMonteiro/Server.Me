using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class PerfilRepository : IPerfilRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public PerfilRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<Perfil> SearchByUsuarioIdAsync(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
