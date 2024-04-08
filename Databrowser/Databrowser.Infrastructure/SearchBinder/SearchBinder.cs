using Microsoft.AspNetCore.OData.Query.Expressions;
using Microsoft.OData.UriParser;
using Databrowser.Domain.Entities.Assets;
using Databrowser.Domain.Entities.Databrowser;
using Databrowser.Domain.Entities.Observations;
using Databrowser.Domain.Entities.Observations.AggregationViews;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace Databrowser.Infrastructure.SearchBinder
{
    [ExcludeFromCodeCoverage]
    public class SearchBinder : QueryBinder, ISearchBinder
    {
        public Expression BindSearch<T>(SearchClause searchClause, QueryBinderContext context)
        {
            if (!typeof(T).IsAssignableFrom(context.ElementClrType))
            {
                return null;
            }

            SearchTermNode node = searchClause.Expression as SearchTermNode;

            return SearchBinderHelper.BindSearch<T>(node.Text);
        }

        public Expression BindSearch(SearchClause searchClause, QueryBinderContext context)
        {
            switch (System.Type.GetTypeCode(context.ElementClrType))
            {
                case TypeCode.Object:
                    return AssetExpression(searchClause, context);

                default:
                    return null;
            }
        }

        #region BindSearch<T> Config
        
        private Expression AssetExpression(SearchClause searchClause, QueryBinderContext context)
        {
            return BindSearch<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView>(searchClause, context)
                ?? BindSearch<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionView>(searchClause, context)
                ?? BindSearch<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView>(searchClause, context)
                ?? BindSearch<Capacity_By_Company_Int_Databrowser>(searchClause, context)
                ?? BindSearch<Capacity_By_Shareholder_Int_Databrowser>(searchClause, context);
        }
        #endregion
    }
}