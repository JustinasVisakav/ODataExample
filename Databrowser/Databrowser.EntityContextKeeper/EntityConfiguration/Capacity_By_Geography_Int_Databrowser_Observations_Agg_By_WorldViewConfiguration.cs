using Databrowser.Domain.Entities.Observations.AggregationViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Databrowser.EntityContextKeeper.EntityConfigurations
{
    public class Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldViewConfiguration : IEntityTypeConfiguration<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView>
    {
        public void Configure(EntityTypeBuilder<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView> builder)
        {
            builder.HasKey(e => new { e.observations_agg_id_by_geo_by_world, e.date });
        }
    }
}
