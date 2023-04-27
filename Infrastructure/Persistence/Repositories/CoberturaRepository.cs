using Application.Interfaces.Repositories;
using Domain.Entities;

namespace Infrastructure.Persistence.Repositories
{
    public class CoberturaRepository : ICoberturaRepository
    {
        private readonly ApplicationDbContext _context;

        public CoberturaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Cobertura cobertura)
        {
            _context.Coberturas.Add(cobertura);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cobertura = GetById(id);
            _context.Coberturas.Remove(cobertura);
            _context.SaveChanges();
        }

        public IEnumerable<Cobertura> GetAllByProdutoId(int produtoId)
        {
            return _context.Coberturas
                .Where(c => c.ProdutoId == produtoId)
                .ToList();
        }

        public Cobertura GetById(int id)
        {
            return _context.Coberturas.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Cobertura cobertura)
        {
            _context.Coberturas.Update(cobertura);
            _context.SaveChanges();
        }
    }
}
