using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Estabelecimento
    {
        public int IdEstabelecimento { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
