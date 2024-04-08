using Databrowser.Domain.Entities.Observations.AggregationViews;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Databrowser.EntityContextKeeper.EntityConfigurations
{
    public class Capacity_Int_Databrowser_ObservationsViewConfiguration : IEntityTypeConfiguration<Capacity_Int_Databrowser_ObservationsView>
    {
        public void Configure(EntityTypeBuilder<Capacity_Int_Databrowser_ObservationsView> builder)
        {
            builder.HasKey(e => new { e.source_id, e.date });
        }
    }
}
