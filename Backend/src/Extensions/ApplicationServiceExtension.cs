using Backend.Data;
using Backend.Models.Interfaces;
using Backend.Data.Repositories;
using Backend.Services;
using Microsoft.EntityFrameworkCore;

namespace Backend.Extensions;

public static class ApplicationServiceExtension
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddDbContext<DataContext>(opt =>
        {
            var connectionString =
                Environment.GetEnvironmentVariable("ConnectionStrings:DefaultConnection")
                ?? configuration["ConnectionStrings:DefaultConnection"];
            opt.UseNpgsql(connectionString);
        });
        services.AddCors();
        services.AddScoped<IAccountRepository, AccountRepository>();
        services.AddScoped<ITokenService, TokenService>();
        services.AddScoped<IShiftRepository, ShiftRepository>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        return services;
    }
}
