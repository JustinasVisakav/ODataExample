using Microsoft.Extensions.DependencyInjection;
using Databrowser.Domain.Entities.Assets;
using Databrowser.Service.Databrowser.Service;
using System.Diagnostics.CodeAnalysis;

namespace Databrowser.API.Databrowser.WebAppBuilder
{
    [ExcludeFromCodeCoverage]
    public static class AssetsWebAppBuilder
    {
        public static void AddAssetsServices(this IServiceCollection service)
        {
            service.AddScoped<Capacity_By_Company_Int_DatabrowserService>();
            service.AddScoped<Capacity_By_Shareholder_Int_Databrowser>();
        }
    }
}
