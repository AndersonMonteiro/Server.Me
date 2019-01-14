using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
