using Databrowser.Domain.Entities.Assets;
using Databrowser.Domain.Entities.Databrowser;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Databrowser.Domain.Entities.Observations.AggregationViews
{
    [ExcludeFromCodeCoverage]
    [Table("capacity_int_obs_agg_by_country_databrowser_view")]
    public class Capacity_Int_Databrowser_Observations_Agg_By_CountryView
    {
        [Key]
        [IgnoreDataMember]
        public string? observations_agg_id_by_country { get; set; }
        [Key]
        public DateTime? date { get; set; }
        public double? value1 { get; set; }
        public double? value2 { get; set; }
        public double? value3 { get; set; }
        

        public Capacity_By_Company_Int_Databrowser? Capacity_By_Company_Int_Databrowser { get; set; }

        public Capacity_By_Shareholder_Int_Databrowser? Capacity_By_Shareholder_Int_Databrowser { get; set; }
    }
}
