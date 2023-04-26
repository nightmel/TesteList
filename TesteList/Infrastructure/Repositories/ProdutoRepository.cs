using System.Collections.Generic;
using System.Linq;
using TesteList.Domain.Entities;
using TesteList.Domain.Repositories;
using TesteList.Infrastructure.Data;

namespace TesteList.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProdutoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var produto = GetById(id);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public Produto GetById(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id);
        }

        public void Update(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }
}
