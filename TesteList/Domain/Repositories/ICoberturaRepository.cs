using System.Collections.Generic;
using TesteList.Domain.Entities;

namespace TesteList.Domain.Repositories
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
