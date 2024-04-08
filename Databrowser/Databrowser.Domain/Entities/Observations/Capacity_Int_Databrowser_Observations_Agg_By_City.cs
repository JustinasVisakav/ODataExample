
using Databrowser.Domain.Entities.Assets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Databrowser.Domain.Entities.Observations
{
    [ExcludeFromCodeCoverage]
    [Table("capacity_int_obs_agg_by_city_databrowser")]
    public class Capacity_Int_Databrowser_Observations_Agg_By_City
    {
        [Key]
        public string? observations_agg_id_by_city { get; set; }
        [Key]
        public DateTime? date { get; set; }
        public double? value_metric_tons_thousand { get; set; }
        public double? value_short_tons_thousand { get; set; }
        public double? value_pounds_million { get; set; }
        public double? value_dry_short_tons_thousand { get; set; }
        public double? value_gallons_million { get; set; }
        public double? value_bbls_calendar_day_thousand { get; set; }
        public double? value_bbls_calendar_day { get; set; }
        public double? value_bbls_stream_day_thousand { get; set; }
        public double? value_bbls_stream_day { get; set; }
        public double? value_liters_million { get; set; }

        [IgnoreDataMember]
        public Capacity_By_Shareholder_Int_Databrowser Capacity_By_Shareholder_Int_Databrowser { get; set; }
    }
}
