using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public string AssuntoComentario { get; set; }
        public string DescricaoComentario { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
