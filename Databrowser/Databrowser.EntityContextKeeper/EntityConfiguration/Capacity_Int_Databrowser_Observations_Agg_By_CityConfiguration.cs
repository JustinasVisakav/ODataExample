using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Databrowser.Domain.Entities.Observations;

namespace Databrowser.EntityContextKeeper.EntityConfiguration
{
    public class Capacity_Int_Databrowser_Observations_Agg_By_CityConfiguration : IEntityTypeConfiguration<Capacity_Int_Databrowser_Observations_Agg_By_City>
    {
        public void Configure(EntityTypeBuilder<Capacity_Int_Databrowser_Observations_Agg_By_City> builder)
        {
            builder.HasKey(e => new { e.observations_agg_id_by_city, e.date });
        }
    }
}
