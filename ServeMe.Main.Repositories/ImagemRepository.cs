using ServeMe.Infrastructure.DatabaseHelper;
using ServeMe.Main.Domain.Entities;
using ServeMe.Main.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Repositories
{
    public class ImagemRepository : IImagemRepository
    {
        protected readonly IPostgreSqlConnectionFactory connectionFactory;

        public ImagemRepository(IPostgreSqlConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;
        }

        public Task InsertAsync(Imagem imagem)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Imagem>> SearchByEstabelecimentoIdAsync(int idEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public Task<Imagem> SearchByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Imagem>> SearchByProdutoAsync(int idProduto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Imagem>> SearchByPromocaoIdAsync(int idPromocao)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Imagem imagem)
        {
            throw new NotImplementedException();
        }
    }
}
