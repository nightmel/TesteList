using TesteList.Application.Services;
using TesteList.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TesteList.Infrastructure.Data;
using TesteList.Domain.Repositories;

namespace TesteList.Infrastructure
{
    public static class ConfigureServices
    {
        public static void AddInfrastructureServices(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(connectionString));

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ICoberturaRepository, CoberturaRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<ICoberturaService, CoberturaService>();
        }
    }
}
