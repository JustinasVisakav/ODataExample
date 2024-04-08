using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Databrowser.Domain.Entities.Observations;

namespace Databrowser.EntityContextKeeper.EntityConfiguration
{
    public class Capacity_Int_Databrowser_ObservationsConfiguration : IEntityTypeConfiguration<Capacity_Int_Databrowser_Observations>
    {
        public void Configure(EntityTypeBuilder<Capacity_Int_Databrowser_Observations> builder)
        {
            builder.HasKey(e => new { e.source_id, e.date });
        }
    }
}
