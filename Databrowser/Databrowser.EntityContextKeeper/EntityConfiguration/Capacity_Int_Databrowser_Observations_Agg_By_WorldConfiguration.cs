using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Databrowser.Domain.Entities.Observations.AggregationViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Databrowser.Domain.Entities.Observations;

namespace Databrowser.EntityContextKeeper.EntityConfiguration
{
    public class Capacity_Int_Databrowser_Observations_Agg_By_WorldConfiguration : IEntityTypeConfiguration<Capacity_Int_Databrowser_Observations_Agg_By_World>
    {
        public void Configure(EntityTypeBuilder<Capacity_Int_Databrowser_Observations_Agg_By_World> builder)
        {
            builder.HasKey(e => new { e.observations_agg_id_by_world, e.date });
        }
    }
}
