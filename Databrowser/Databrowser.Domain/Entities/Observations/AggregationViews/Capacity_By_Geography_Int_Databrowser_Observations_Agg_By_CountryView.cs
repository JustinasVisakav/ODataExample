using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations.Schema;
using Databrowser.Domain.Entities.Databrowser;
using Databrowser.Domain.Entities.Assets;

namespace Databrowser.Domain.Entities.Observations.AggregationViews
{
    [ExcludeFromCodeCoverage]
    [Table("capacity_by_geo_int_obs_agg_by_country_databrowser_view")]
    public class Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_CountryView
    {
        [Key]
        [IgnoreDataMember]
        public string? observations_agg_id_by_geo_by_country { get; set; }
        [Key]
        public DateTime? date { get; set; }
        public double? value1 { get; set; }
        public double? value2 { get; set; }
        public double? value3 { get; set; }

        public Capacity_By_Company_Int_Databrowser? Capacity_By_Company_Int_Databrowser { get; set; }

        public Capacity_By_Shareholder_Int_Databrowser? Capacity_By_Shareholder_Int_Databrowser { get; set; }
        
    }
}
