using Microsoft.EntityFrameworkCore;
using Todo.infrastructure.Persistance.Entities;
namespace Todo.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<TodoAppDbContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }
    }
}
