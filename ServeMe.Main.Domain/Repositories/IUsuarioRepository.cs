using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> SearchByIdAsync(int id);
        Task InsertAsync(Usuario usuario);
        Task UpdateAsync(Usuario usuario);
    }
}
