namespace Application.Interfaces.Models
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }
        public string CodigoSUSEP { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicioVigencia { get; set; }
        public DateTime DataFimVigencia { get; set; }
        public bool Ativo { get; set; }
    }
}
