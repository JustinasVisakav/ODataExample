using Databrowser.Configuration.Interfaces;
using Databrowser.Domain.Entities.Databrowser;
using Databrowser.Domain.Entities.Observations;
using Databrowser.Domain.Entities.Observations.AggregationViews;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Databrowser.Domain.Entities.Assets;

namespace Databrowser.EntityContextKeeper.DatabaseContexts
{
    [ExcludeFromCodeCoverage]
    public class PostgresContext : DbContext
    {
        private readonly IConfig _config;

        public PostgresContext(DbContextOptions<PostgresContext> options, IConfig config) : base(options)
        {
            this._config = config;
        }

        public DbSet<Capacity_By_Shareholder_Int_Databrowser> Capacity_By_Shareholder_Int_Databrowser { get; set; }
        public DbSet<Capacity_By_Company_Int_Databrowser> Capacity_By_Company_Int_Databrowser { get; set; }

        public DbSet<Capacity_Int_Databrowser_ObservationsView> Capacity_Int_Databrowser_ObservationsView { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_CityView> Capacity_Int_Databrowser_Observations_Agg_By_CityView { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_CountryView> Capacity_Int_Databrowser_Observations_Agg_By_CountryView { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_RegionView> Capacity_Int_Databrowser_Observations_Agg_By_RegionView { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_WorldView> Capacity_Int_Databrowser_Observations_Agg_By_WorldView { get; set; }

        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_City> Capacity_Int_Databrowser_Observations_Agg_By_City { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_Country> Capacity_Int_Databrowser_Observations_Agg_By_Country { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_Region> Capacity_Int_Databrowser_Observations_Agg_By_Region { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations_Agg_By_World> Capacity_Int_Databrowser_Observations_Agg_By_World { get; set; }
        public DbSet<Capacity_Int_Databrowser_Observations> Capacity_Int_Databrowser_Observations { get; set; }
        public DbSet<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country { get; set; }
        public DbSet<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region { get; set; }
        public DbSet<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World { get; set; }
        public DbSet<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView { get; set; }
        public DbSet<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionView> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionView { get; set; }
        public DbSet<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

    }
}