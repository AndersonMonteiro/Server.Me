using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface IEmailRepository
    {
        Task<IEnumerable<Email>> SearchByUserIdAsync(int idUsuario);
        Task<Email> SearchByIdAsync(int id);
        Task InsertAsync(Email email);
        Task UpdateAsync(Email email);
    }
}
