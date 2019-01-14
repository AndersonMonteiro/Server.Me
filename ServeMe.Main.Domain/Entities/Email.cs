using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Email
    {
        public int IdEmail { get; set; }
        public string EnderecoEmail { get; set; }
        public Boolean EmailAtiva{ get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
