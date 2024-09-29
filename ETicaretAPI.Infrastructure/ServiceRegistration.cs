using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Application.Services;
using ETicaretAPI.Infrastructure.Services;
using ETicaretAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IFileService, FileService > ();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        }
    }
}
