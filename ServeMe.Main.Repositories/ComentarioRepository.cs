using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class ComentarioRepository : IComentarioRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public ComentarioRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Comentario comentario)
        {
            throw new NotImplementedException();
        }

        public Task<Comentario> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comentario>> SearchByPromocaoIdAsync(int idPromocao)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Comentario comentario)
        {
            throw new NotImplementedException();
        }
    }
}
