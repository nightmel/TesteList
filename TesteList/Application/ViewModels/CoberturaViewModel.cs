using System;

namespace TesteList.Application.ViewModels
{
    public class CoberturaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal CapitalSegurado { get; set; }
        public decimal Premio { get; set; }
        public string FaixaEtaria { get; set; }
        public bool CoberturaMorte { get; set; }
        public bool CoberturaInvalidez { get; set; }
        public bool CoberturaDoencasGraves { get; set; }
        public int ProdutoId { get; set; }
    }
}
