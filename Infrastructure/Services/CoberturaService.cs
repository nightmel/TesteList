using Application.Interfaces.Models;
using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using AutoMapper;
using Domain.Entities;

namespace Infrastructure.Services
{
    public class CoberturaService : ICoberturaService
    {
        private readonly IMapper _mapper;
        private readonly ICoberturaRepository _coberturaRepository;

        public CoberturaService(IMapper mapper, ICoberturaRepository coberturaRepository)
        {
            _mapper = mapper;
            _coberturaRepository = coberturaRepository;
        }

        public IEnumerable<CoberturaViewModel> GetCoberturasByProdutoId(int produtoId)
        {
            var coberturas = _coberturaRepository.GetCoberturasByProdutoId(produtoId);
            return _mapper.Map<IEnumerable<Cobertura>, IEnumerable<CoberturaViewModel>>(coberturas);
        }
    }
}
