using System.Collections.Generic;
using TesteList.Application.ViewModels;


namespace TesteList.Application.Services
{
    public interface ICoberturaService
    {
        IEnumerable<CoberturaViewModel> GetCoberturasByProdutoId(int produtoId);
    }
}
