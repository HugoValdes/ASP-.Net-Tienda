using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SistemaVentas.DAO.DBContext;

namespace SistemaVentas.IOC
{
    public static class Dependencia
    {
        public static void DependencyInyect(this IServiceCollection services, IConfiguration configuration)
        {
             services.AddDbContext<DbventaContext>(options =>
             {
                 options.UseSqlServer(configuration.GetConnectionString("CadenaSQL"));
             });
        }
    }
}
