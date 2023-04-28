using Application.Interfaces.Models;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;


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
