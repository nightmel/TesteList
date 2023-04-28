using Application.Interfaces.Models;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Web.Pages
{
    public class ListarCoberturasModel : PageModel
    {
        private readonly ILogger<ListarCoberturasModel> _logger;
        private readonly ICoberturaService _coberturaService;

        public ListarCoberturasModel(ILogger<ListarCoberturasModel> logger, ICoberturaService coberturaService)
        {
            _logger = logger;
            _coberturaService = coberturaService;
        }

        [BindProperty(SupportsGet = true)]
        public int ProdutoId { get; set; }

        public IEnumerable<CoberturaViewModel> Coberturas { get; set; }

        public IActionResult OnGet(int id)
        {
            ProdutoId = id;
            Coberturas = _coberturaService.GetCoberturasByProdutoId(ProdutoId);
            if (Coberturas == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
