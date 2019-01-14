using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Avaliacao
    {
        public int IdAvaliacao { get; set; }
        public string Assunto { get; set; }
        public string Descricao { get; set; }
        public int NumeroRecomendacoesPositivas { get; set; }
        public int NumeroRecomendacoesNegativas { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }        
    }
}
