using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Telefone
    {
        public int IdTelefone { get; set; }
        public string NumeroTelefone { get; set; }
        public Boolean TelefoneAtivo { get; set; }
        public int MyProperty { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
