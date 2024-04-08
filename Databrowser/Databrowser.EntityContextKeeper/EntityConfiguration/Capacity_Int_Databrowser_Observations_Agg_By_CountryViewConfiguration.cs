using Databrowser.Domain.Entities.Observations.AggregationViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Databrowser.EntityContextKeeper.EntityConfigurations
{
    public class Capacity_Int_Databrowser_Observations_Agg_By_CountryViewConfiguration : IEntityTypeConfiguration<Capacity_Int_Databrowser_Observations_Agg_By_CountryView>
    {
        public void Configure(EntityTypeBuilder<Capacity_Int_Databrowser_Observations_Agg_By_CountryView> builder)
        {
            builder.HasKey(e => new { e.observations_agg_id_by_country, e.date });
        }
    }
}
