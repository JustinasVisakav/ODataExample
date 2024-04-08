using Microsoft.Extensions.Logging;
using Databrowser.Domain.Entities.Databrowser;
using Databrowser.Domain.Entities.Observations;
using Databrowser.EntityContextKeeper.DatabaseContexts;
using m.Infrastructure.BaseEntities;

namespace Databrowser.Service.Databrowser.Service
{
    public class Capacity_By_Company_Int_DatabrowserService : BaseService
    {
        private readonly PostgresContext _database;

        public Capacity_By_Company_Int_DatabrowserService(ILogger<Capacity_By_Company_Int_DatabrowserService> logger,
                                                 PostgresContext database) : base(logger)
        {
            _database = database;
        }

        public IQueryable<Capacity_By_Company_Int_Databrowser?> Get()
        {
            return _database.Capacity_By_Company_Int_Databrowser.AsQueryable();
        }

        public IQueryable<Capacity_By_Company_Int_Databrowser?> GetById(string source_id)
        {
            var result = Get();

            return result.Where(record => record.source_id == source_id);
        }

        public IQueryable<Capacity_Int_Databrowser_Observations> GetObservations(string source_id)
        {
            var records = _database.Capacity_Int_Databrowser_Observations
                .Where(record => record.source_id == source_id)
                .AsQueryable();

            return records;
        }

        public IQueryable<Capacity_Int_Databrowser_Observations_Agg_By_Country> GetObservationsAggByCountry(string source_id)
        {
            var records = _database.Capacity_Int_Databrowser_Observations_Agg_By_Country
                .Where(record => record.observations_agg_id_by_country == _database.Capacity_By_Company_Int_Databrowser.FirstOrDefault(x => x.source_id == source_id).observations_agg_id_by_country)
                .AsQueryable();

            return records;
        }
        public IQueryable<Capacity_Int_Databrowser_Observations_Agg_By_Region> GetObservationsAggByRegion(string source_id)
        {
            var records = _database.Capacity_Int_Databrowser_Observations_Agg_By_Region
                .Where(record => record.observations_agg_id_by_region == _database.Capacity_By_Company_Int_Databrowser.FirstOrDefault(x => x.source_id == source_id).observations_agg_id_by_region)
                .AsQueryable();

            return records;
        }
        public IQueryable<Capacity_Int_Databrowser_Observations_Agg_By_World> GetObservationsAggByWorld(string source_id)
        {
            var records = _database.Capacity_Int_Databrowser_Observations_Agg_By_World
                .Where(record => record.observations_agg_id_by_world == _database.Capacity_By_Company_Int_Databrowser.FirstOrDefault(x => x.source_id == source_id).observations_agg_id_by_world)
                .AsQueryable();

            return records;
        }

        public IQueryable<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country> GetObservationsByGeoAggByCountry(string source_id)
        {
            var records = _database.Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Country
                .Where(record => record.observations_agg_id_by_geo_by_country == _database.Capacity_By_Company_Int_Databrowser.FirstOrDefault(x => x.source_id == source_id).observations_agg_id_by_geo_by_country)
                .AsQueryable();

            return records;
        }

        public IQueryable<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region> GetObservationsByGeoAggByRegion(string source_id)
        {
            var records = _database.Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_Region
                .Where(record => record.observations_agg_id_by_geo_by_region == _database.Capacity_By_Company_Int_Databrowser.FirstOrDefault(x => x.source_id == source_id).observations_agg_id_by_geo_by_region)
                .AsQueryable();

            return records;
        }

        public IQueryable<Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World> GetObservationsByGeoAggByWorld(string source_id)
        {
            var records = _database.Capacity_By_Geography_Int_Databrowser_Observations_Agg_By_World
                .Where(record => record.observations_agg_id_by_geo_by_world == _database.Capacity_By_Company_Int_Databrowser.FirstOrDefault(x => x.source_id == source_id).observations_agg_id_by_geo_by_world)
                .AsQueryable();

            return records;
        }

        public int Count()
        {
            return _database.Capacity_By_Company_Int_Databrowser.Count();
        }
    }
}
