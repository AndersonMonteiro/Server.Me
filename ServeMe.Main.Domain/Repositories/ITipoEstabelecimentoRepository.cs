﻿using ServeMe.Main.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServeMe.Main.Domain.Repositories
{
    public interface ITipoEstabelecimentoRepository
    {
        Task<IEnumerable<TipoEstabelecimento>> SearchAllAsync();
    }
}
