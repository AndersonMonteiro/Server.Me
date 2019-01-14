using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Imagem
    {
        public int IdImagem { get; set; }
        public string NomeArquivo { get; set; }
        public string NomeImagem { get; set; }
        public string DescricaoChaveImagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
