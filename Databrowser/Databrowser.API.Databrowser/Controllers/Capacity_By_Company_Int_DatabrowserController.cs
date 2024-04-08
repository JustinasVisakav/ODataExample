using Databrowser.Domain.Entities.Databrowser;
using Databrowser.Domain.Entities.Observations;
using Databrowser.Configuration.Constants;
using Databrowser.Service.Databrowser.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Swashbuckle.AspNetCore.Annotations;
using System.Diagnostics.CodeAnalysis;

namespace Databrowser.API.Assets.Controllers
{
    [ExcludeFromCodeCoverage]
    public class Capacity_By_Company_Int_DatabrowserController : ODataController
    {
        private readonly Capacity_By_Company_Int_DatabrowserService _service;

        public Capacity_By_Company_Int_DatabrowserController(Capacity_By_Company_Int_DatabrowserService service)
        {
            _service = service;
        }

        [HttpGet, EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_By_Company_Int_Databrowser), 200)]
        public IActionResult Get()
        {
            var result = _service.Get();

            return Ok(result);
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser)+"({source_id})"), EnableQuery]
        [ProducesResponseType(typeof(Capacity_By_Company_Int_Databrowser), 200)]
        public IQueryable<Capacity_By_Company_Int_Databrowser> GetById(

            [FromRoute]
            [SwaggerParameter(Required = true)]
            [FromODataUri] string source_id)
        {
            var result = _service.GetById(source_id);
            return result;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/observations"), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_Int_Databrowser_Observations), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_Int_Databrowser_Observations> GetByIdObservations([FromODataUri] string source_id)
        {
            var records = _service.GetObservations(source_id);

            return records;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/"+nameof(Capacity_By_Company_Int_Databrowser.observations_agg_by_country)), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_Int_Databrowser_Observations_Agg_By_Country), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_Int_Databrowser_Observations_Agg_By_Country> GetObservationsAgrByCountry([FromODataUri] string source_id)
        {
            var records = _service.GetObservationsAggByCountry(source_id);

            return records;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/"+nameof(Capacity_By_Company_Int_Databrowser.observations_agg_by_region)), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_Int_Databrowser_Observations_Agg_By_Region), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_Int_Databrowser_Observations_Agg_By_Region> GetObservationsAgrByRegion([FromODataUri] string source_id)
        {
            var records = _service.GetObservationsAggByRegion(source_id);

            return records;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/"+nameof(Capacity_By_Company_Int_Databrowser.observations_agg_by_world)), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_Int_Databrowser_Observations_Agg_By_World), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_Int_Databrowser_Observations_Agg_By_World> GetObservationsAgrByWorld([FromODataUri] string source_id)
        {
            var records = _service.GetObservationsAggByWorld(source_id);

            return records;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/" + nameof(Capacity_By_Company_Int_Databrowser.observations_agg_by_geo_by_country)), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country> GetObservationsByGeoAgrByCountry([FromODataUri] string source_id)
        {
            var records = _service.GetObservationsByGeoAggByCountry(source_id);

            return records;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/" + nameof(Capacity_By_Company_Int_Databrowser.observations_agg_by_geo_by_region)), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region> GetObservationsByGeoAgrByRegion([FromODataUri] string source_id)
        {
            var records = _service.GetObservationsByGeoAggByRegion(source_id);

            return records;
        }

        [HttpGet(ODataConfiguration.RoutePrefix + "/" + nameof(Capacity_By_Company_Int_Databrowser) + "({source_id})/" + nameof(Capacity_By_Company_Int_Databrowser.observations_agg_by_geo_by_world)), EnableQuery(PageSize = 1000)]
        [ProducesResponseType(typeof(Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World), 200)]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IQueryable<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World> GetObservationsByGeoAgrByWorld([FromODataUri] string source_id)
        {
            var records = _service.GetObservationsByGeoAggByWorld(source_id);

            return records;
        }
    }
}
