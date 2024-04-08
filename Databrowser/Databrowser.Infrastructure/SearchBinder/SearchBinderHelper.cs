using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq.Expressions;

namespace Databrowser.Infrastructure.SearchBinder
{
    public static class SearchBinderHelper
    {
        public static Expression BindSearch<T>(string searchClause)
        {
            //SearchTermNode node = searchClause.Expression as SearchTermNode;

            var parameterExpression = Expression.Parameter(typeof(T), "record");
            var orExpressions = new List<Expression>();

            foreach (var propertyInfo in typeof(T).GetProperties())
            {
                if (!propertyInfo.HasAttribute<ObsoleteAttribute>() && propertyInfo.PropertyType == typeof(string))
                {
                    var memberExpression = Expression.Property(parameterExpression, propertyInfo);
                    var constantExpression = Expression.Constant(searchClause, typeof(string));
                    var callExpression = Expression.Call(memberExpression, "Contains", Type.EmptyTypes, constantExpression);
                    orExpressions.Add(callExpression);
                }
            }

            if (orExpressions.Count == 0)
            {
                return null;
            }

            var orExpression = orExpressions.Aggregate(Expression.OrElse);
            var predicate = Expression.Lambda<Func<T, bool>>(orExpression, parameterExpression);
            return predicate;
        }
    }
}