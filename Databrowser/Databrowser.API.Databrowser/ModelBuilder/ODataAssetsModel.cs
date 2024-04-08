using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Databrowser.Domain.Entities.Assets;
using Databrowser.Domain.Entities.Databrowser;
using Databrowser.Infrastructure.Helpers;
using System.Reflection;

namespace Databrowser.API.Databrowser.ModelBuilder
{
    public static class ODataAssetsModel
    {
        private static readonly List<string> AssetNames = new List<string>()
        {
            nameof(Capacity_By_Company_Int_Databrowser),
            nameof(Capacity_By_Shareholder_Int_Databrowser)
        };

        public static void AddAssetModels(this ODataModelBuilder modelBuilder)
        {
            modelBuilder.EntitySet<Capacity_By_Company_Int_Databrowser>(nameof(Capacity_By_Company_Int_Databrowser)).HasCountRestrictions().IsCountable(true);
            modelBuilder.EntitySet<Capacity_By_Shareholder_Int_Databrowser>(nameof(Capacity_By_Shareholder_Int_Databrowser)).HasCountRestrictions().IsCountable(true);
        }

        public static void AddAssetNavigationLinks(this IEdmModel edmModel)
        {
            edmModel.AddNavigationLinks(AssetNames);
        }
    }
}
