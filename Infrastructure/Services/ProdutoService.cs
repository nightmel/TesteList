using Application.Interfaces.Models;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;

namespace Infrastructure.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IMapper mapper, IProdutoRepository produtoRepository)
        {
            _mapper = mapper;
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<ProdutoViewModel> GetAll()
        {
            var produtos = _produtoRepository.GetAll();
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
        }

        public ProdutoViewModel GetById(int id)
        {
            var produto = _produtoRepository.GetById(id);
            return _mapper.Map<ProdutoViewModel>(produto);
        }
    }
}
