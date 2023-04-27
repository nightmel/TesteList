using System.Collections.Generic;
using ListarCoberturas.Application.Services;
using ListarCoberturas.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TesteList.Application.Services;
using TesteList.Application.ViewModels;

namespace Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IProdutoService _produtoService;

        public IndexModel(ILogger<IndexModel> logger, IProdutoService produtoService)
        {
            _logger = logger;
            _produtoService = produtoService;
        }

        public IEnumerable<ProdutoViewModel> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = _produtoService.GetAll();
        }
    }
}
