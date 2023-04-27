using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface ICoberturaRepository
    {
        IEnumerable<Cobertura> GetAllByProdutoId(int produtoId);
        Cobertura GetById(int id);
        void Add(Cobertura cobertura);
        void Update(Cobertura cobertura);
        void Delete(int id);
    }
}
