using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class FormaPagamentoRepository : IFormaPagamentoRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public FormaPagamentoRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task<IEnumerable<FormaPagamento>> SearchByEstabelecimentoIdAsync(int idEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public Task<FormaPagamento> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
