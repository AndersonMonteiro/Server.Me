using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class TipoEstabelecimentoRepository : ITipoEstabelecimentoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public TipoEstabelecimentoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<IEnumerable<TipoEstabelecimento>> SearchAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
