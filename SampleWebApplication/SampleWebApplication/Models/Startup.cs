using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SampleWebApplication.Models;

public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(System.Configuration.GetConnectionString("DefaultConnection")));
}
