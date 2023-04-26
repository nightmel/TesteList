using System.Collections.Generic;
using TesteList.Application.ViewModels;

namespace TesteList.Application.Services
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoViewModel> GetAll();
        ProdutoViewModel GetById(int id);
    }
}
