namespace Domain.Entities
{
    public class Produto
    {
        public int Id { get; set; }
        public string CodigoSUSEP { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFimVigencia { get; set; }
        public bool Ativo { get; set; }

        // Relacionamento com a entidade Cobertura
        public virtual ICollection<Cobertura> Coberturas { get; set; }
    }
}
