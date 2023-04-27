
using Application.Interfaces.Models;

namespace Application.Interfaces.Services
{
    public interface IProdutoService
    {
        IEnumerable<ProdutoViewModel> GetAll();
        ProdutoViewModel GetById(int id);
    }
}
