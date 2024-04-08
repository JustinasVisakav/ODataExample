using Databrowser.Domain.Entities.Observations;
using Databrowser.Domain.Entities.Observations.AggregationViews;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Databrowser.Domain.Entities.Assets
{
    [ExcludeFromCodeCoverage]
    [Table("capacity_by_shareholder_int_databrowser")]
    public class Capacity_By_Shareholder_Int_Databrowser
    {
        [Key]
        public string source_id { get; set; }
        public int? col1 { get; set; }
        public int? col2 { get; set; }
        [IgnoreDataMember]
        public string? observations_agg_id_by_country { get; set; }
        [IgnoreDataMember]
        public string? observations_agg_id_by_region { get; set; }
        [IgnoreDataMember]
        public string? observations_agg_id_by_world { get; set; }

        [IgnoreDataMember]
        public string? observations_agg_id_by_geo_by_country { get; set; }

        [IgnoreDataMember]
        public string? observations_agg_id_by_geo_by_region { get; set; }

        [IgnoreDataMember]
        public string? observations_agg_id_by_geo_by_world { get; set; }

        [IgnoreDataMember]
        public string? observations_agg_id_by_city { get; set; }

        public ICollection<Capacity_Int_Databrowser_Observations> observations { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_ObservationsView> observationsView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_City> observations_agg_by_city { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_CityView> Capacity_Int_Databrowser_Observations_Agg_By_CityView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_Country> observations_agg_by_country { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_CountryView> Capacity_Int_Databrowser_Observations_Agg_By_CountryView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_Region> observations_agg_by_region { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_RegionView> Capacity_Int_Databrowser_Observations_Agg_By_RegionView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_World> observations_agg_by_world { get; set; }

        [IgnoreDataMember]
        public ICollection<Capacity_Int_Databrowser_Observations_Agg_By_WorldView> Capacity_Int_Databrowser_Observations_Agg_By_WorldView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country> observations_agg_by_geo_by_country { get; set; }

        [IgnoreDataMember]
        public ICollection<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region> observations_agg_by_geo_by_region { get; set; }

        [IgnoreDataMember]
        public ICollection<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionView> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_RegionView { get; set; }
        [IgnoreDataMember]
        public ICollection<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World> observations_agg_by_geo_by_world { get; set; }

        [IgnoreDataMember]
        public ICollection<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView> Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_WorldView { get; set; }
    }
}
