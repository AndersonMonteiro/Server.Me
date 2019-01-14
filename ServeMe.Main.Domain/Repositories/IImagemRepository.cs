using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface IImagemRepository
    {
        Task<IEnumerable<Imagem>> SearchByEstabelecimentoIdAsync(int idEstabelecimento);
        Task<IEnumerable<Imagem>> SearchByPromocaoIdAsync(int idPromocao);
        Task<IEnumerable<Imagem>> SearchByProdutoAsync(int idProduto);
        Task<Imagem> SearchByIdAsync(int id);
        Task InsertAsync(Imagem imagem);
        Task UpdateAsync(Imagem imagem);
    }
}
