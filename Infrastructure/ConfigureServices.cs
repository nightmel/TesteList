using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Infrastructure
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
