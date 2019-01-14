using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Boolean UsuarioAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
