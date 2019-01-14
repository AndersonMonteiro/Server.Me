using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface IComentarioRepository
    {
        Task<Comentario> SearchByIdAsync(int id);
        Task<IEnumerable<Comentario>> SearchByPromocaoIdAsync(int idPromocao);
        Task UpdateAsync(Comentario comentario);
        Task InsertAsync(Comentario comentario);
    }
}
