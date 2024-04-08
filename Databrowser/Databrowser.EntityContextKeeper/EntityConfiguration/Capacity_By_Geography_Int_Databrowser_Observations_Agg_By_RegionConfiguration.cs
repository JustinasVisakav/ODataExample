using Databrowser.Domain.Entities.Observations;
using Databrowser.Domain.Entities.Observations.AggregationViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Databrowser.EntityContextKeeper.EntityConfigurations
{
    public class Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionConfiguration : IEntityTypeConfiguration<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region>
    {
        public void Configure(EntityTypeBuilder<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region> builder)
        {
            builder.HasKey(e => new { e.observations_agg_id_by_geo_by_region, e.date });
        }
    }
}
