﻿using Databrowser.Domain.Entities.Assets;
using Databrowser.Domain.Entities.Databrowser;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Databrowser.Domain.Entities.Observations
{
    [ExcludeFromCodeCoverage]
    [Table("capacity_by_geo_int_obs_agg_by_region_databrowser")]
    public class Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region
    {
        [Key]
        public string? observations_agg_id_by_geo_by_region { get; set; }
        [Key]
        public DateTime? date { get; set; }
        public double? value1 { get; set; }
        public double? value2 { get; set; }
        public double? value3 { get; set; }

        [IgnoreDataMember]
        public Capacity_By_Company_Int_Databrowser? Capacity_By_Company_Int_Databrowser { get; set; }

        [IgnoreDataMember]
        public Capacity_By_Shareholder_Int_Databrowser? Capacity_By_Shareholder_Int_Databrowser { get; set; }
    }
}
