using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface ITelefoneRepository
    {
        Task<Telefone> SearchByIdAsync(int id);
        Task UpdateAsync(Telefone telefone);
        Task InsertAsync(Telefone telefone);
    }
}
