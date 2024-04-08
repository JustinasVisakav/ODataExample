using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Batch;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Query.Expressions;
using Microsoft.AspNetCore.OData.Query.Validator;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder;
using Databrowser.API.Databrowser.ModelBuilder;
using Databrowser.Configuration.Constants;
using Databrowser.Infrastructure.SearchBinder;

namespace Databrowser.API.ODataModel
{
    public static class ODataModel
    {
        private static EdmModel? _edmModel;
        private static EdmModel EdmModel => _edmModel ?? CreateEdmModel();
        public static ODataOptions AddODataModel(this ODataOptions? options)
        {
            options ??= new ODataOptions();
            options.EnableQueryFeatures(3000);
            options.SkipToken().AddRouteComponents(routePrefix: ODataConfiguration.RoutePrefix, model: EdmModel, services =>
            {
                services.AddSingleton<ISearchBinder, SearchBinder>();
                services.AddSingleton<ODataBatchHandler>(GetBatchHandler());
                services.AddSingleton<IODataQueryValidator, CustomODataQueryValidator>();
            });
            options.RouteOptions.EnableNonParenthesisForEmptyParameterFunction = true;
            options.EnableAttributeRouting = true;

            return options;
        }

        private static DefaultODataBatchHandler GetBatchHandler()
        {
            var batchHandler = new DefaultODataBatchHandler
            {
                MessageQuotas = { MaxNestingDepth = 2, MaxOperationsPerChangeset = 10, MaxReceivedMessageSize = 100 },
            };

            return batchHandler;
        }

        private static EdmModel CreateEdmModel()
        {
            var modelBuilder = new ODataConventionModelBuilder
            {
                Namespace = ODataConfiguration.ODataNamespace,
            };

            ODataAssetsModel.AddAssetModels(modelBuilder);

            _edmModel = (EdmModel)modelBuilder.GetEdmModel();

            ODataAssetsModel.AddAssetNavigationLinks(_edmModel);

            return _edmModel;
        }
    }

    public class CustomODataQueryValidator : ODataQueryValidator
    {
        public override void Validate(ODataQueryOptions options, ODataValidationSettings validationSettings)
        {
            validationSettings.MaxNodeCount = 200;
            try
            {
                base.Validate(options, validationSettings);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
