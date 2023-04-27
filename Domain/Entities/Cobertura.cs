namespace Domain.Entities
{
    public class Cobertura
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

        // Chave estrangeira para a entidade Produto
        public int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
