

using Application.Interfaces.Models;

namespace Application.Interfaces.Services
{
    public interface ICoberturaService
    {
        IEnumerable<CoberturaViewModel> GetCoberturasByProdutoId(int produtoId);
    }
}
