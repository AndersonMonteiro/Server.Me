using System;
using System.Collections.Generic;
using System.Text;

namespace ServeMe.Main.Domain.Entities
{
    public class Promocao
    {
        public int IdPromocao { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public Boolean PromocaoAtiva { get; set; }
        public int QuantidadeLimiteCompra { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFinalVigencia { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
