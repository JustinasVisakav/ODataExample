using Databrowser.Domain.Entities.Assets;
using Databrowser.Domain.Entities.Databrowser;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Databrowser.Domain.Entities.Observations
{
    [ExcludeFromCodeCoverage]
    [Table("capacity_int_observations_databrowser")]
    public class Capacity_Int_Databrowser_Observations
    {
        [Key]
        public string? source_id { get; set; }
        [Key]
        public DateTime? date { get; set; }
        public double? value1 { get; set; }
        public double? value2 { get; set; }
        public double? value3 { get; set; }

        [IgnoreDataMember]
        public Capacity_By_Company_Int_Databrowser Capacity_By_Company_Int_Databrowser { get; set; }

        [IgnoreDataMember]
        public Capacity_By_Shareholder_Int_Databrowser Capacity_By_Shareholder_Int_Databrowser { get; set; }
    }
}
