using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface IAvaliacaoRepository
    {
        Task<Avaliacao> SearchByIdAsync(int idAvaliacao);
        Task<IEnumerable<Avaliacao>> SearchByUsuarioIdAsync(int idUsuario);
        Task<IEnumerable<Avaliacao>> SearchByEstabelecimentoIdAsync(int idEstabelecimeto);
        Task<IEnumerable<Avaliacao>> SearchByPromocaoIdAsync(int idPromocao);
        Task InsertAsync(Avaliacao avaliacao);
        Task UpdateAsync(Avaliacao avaliacao);
    }
}
