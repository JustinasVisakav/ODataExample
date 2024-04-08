using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Databrowser.Domain.Entities.Assets;

namespace Databrowser.EntityContextKeeper.EntityConfiguration
{
    public class Capacity_By_Shareholder_Int_DatabrowserConfiguration : IEntityTypeConfiguration<Capacity_By_Shareholder_Int_Databrowser>
    {
        public void Configure(EntityTypeBuilder<Capacity_By_Shareholder_Int_Databrowser> builder)
        {
            builder
                .HasMany(d => d.observations)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasForeignKey(b => b.source_id);

            builder
                .HasMany(d => d.observations_agg_by_country)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_country)
                .HasForeignKey(b => b.observations_agg_id_by_country);

            builder
                .HasMany(d => d.observations_agg_by_region)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_region)
                .HasForeignKey(b => b.observations_agg_id_by_region);

            builder
                .HasMany(d => d.observations_agg_by_world)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_world)
                .HasForeignKey(b => b.observations_agg_id_by_world);

            builder
                .HasMany(d => d.observations_agg_by_city)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_city)
                .HasForeignKey(b => b.observations_agg_id_by_city);

            builder
                .HasMany(d => d.observationsView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasForeignKey(b => b.source_id);

            builder
                .HasMany(d => d.Capacity_Int_Databrowser_Observations_Agg_By_CountryView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_country)
                .HasForeignKey(b => b.observations_agg_id_by_country);

            builder
                .HasMany(d => d.Capacity_Int_Databrowser_Observations_Agg_By_RegionView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasForeignKey(b => b.observations_agg_id_by_region)
                .HasPrincipalKey(b => b.observations_agg_id_by_region);

            builder
                .HasMany(d => d.Capacity_Int_Databrowser_Observations_Agg_By_WorldView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_world)
                .HasForeignKey(b => b.observations_agg_id_by_world);

            builder
                .HasMany(d => d.Capacity_Int_Databrowser_Observations_Agg_By_CityView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_city)
                .HasForeignKey(b => b.observations_agg_id_by_city);

            builder
                .HasMany(d => d.observations_agg_by_geo_by_country)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_geo_by_country)
                .HasForeignKey(b => b.observations_agg_id_by_geo_by_country);

            builder
                .HasMany(d => d.Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_country)
                .HasForeignKey(b => b.observations_agg_id_by_geo_by_country);

            builder
                .HasMany(d => d.observations_agg_by_geo_by_region)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_geo_by_region)
                .HasForeignKey(b => b.observations_agg_id_by_geo_by_region);

            builder
                .HasMany(d => d.Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_region)
                .HasForeignKey(b => b.observations_agg_id_by_geo_by_region);

            builder
                .HasMany(d => d.observations_agg_by_geo_by_world)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_geo_by_world)
                .HasForeignKey(b => b.observations_agg_id_by_geo_by_world);

            builder
                .HasMany(d => d.Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView)
                .WithOne(d => d.Capacity_By_Shareholder_Int_Databrowser)
                .HasPrincipalKey(b => b.observations_agg_id_by_world)
                .HasForeignKey(b => b.observations_agg_id_by_geo_by_world);
        }
    }
}
